using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MarketOffsets.Engine;
using MarketOffsets.Models;
using MarketOffsets.Profiles;

namespace MarketOffsets.Services;

public sealed class GameMemoryService : IDisposable
{
    private static readonly Lazy<GameMemoryService> _instance = new(() => new GameMemoryService());
    public static GameMemoryService Instance => _instance.Value;

    private readonly MemoryEngine _memoryEngine;
    private readonly ProcessMonitorService _monitorService;
    private CancellationTokenSource? _keepAliveCts;
    private Task? _keepAliveTask;

    public IMemoryEngine Memory => _memoryEngine;
    public IGameProfile? CurrentProfile { get; private set; }
    public Process? CurrentProcess { get; private set; }
    public bool IsGameAttached => _memoryEngine.IsAttached && CurrentProfile != null;

    public string CurrentGameName => CurrentProfile?.DisplayName ?? "No game detected";

    public IVisualsSettings? CurrentSettings { get; set; }

    public event EventHandler? StateChanged;

    public GameMemoryService()
    {
        _memoryEngine = new MemoryEngine();
        _monitorService = new ProcessMonitorService(TimeSpan.FromMilliseconds(1000));

        _monitorService.GameAttached += OnGameAttached;
        _monitorService.GameDetached += OnGameDetached;
    }

    public void Start()
    {
        _monitorService.Start();
        StartKeepAliveLoop();
    }

    public void Stop()
    {
        StopKeepAliveLoop();
        _monitorService.Stop();
        _memoryEngine.Detach();
        CurrentProfile = null;
        CurrentProcess = null;
        StateChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnGameAttached(object? sender, (IGameProfile Profile, Process Process) e)
    {
        if (_memoryEngine.Attach(e.Process, e.Profile.Is64Bit))
        {
            CurrentProfile = e.Profile;
            CurrentProcess = e.Process;

            if (CurrentSettings != null)
            {
                ApplySettings(CurrentSettings);
            }

            StateChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    private void OnGameDetached(object? sender, EventArgs e)
    {
        _memoryEngine.Detach();
        CurrentProfile = null;
        CurrentProcess = null;
        StateChanged?.Invoke(this, EventArgs.Empty);
    }

    public void ApplySettings(IVisualsSettings settings)
    {
        CurrentSettings = settings;

        if (!IsGameAttached || CurrentProfile == null) return;

        try
        {
            CurrentProfile.ApplyVisualsConfig(_memoryEngine, settings);
        }
        catch
        {
            // Fail safely if game process became unreachable
        }
    }

    public void ApplyCurrentSettings()
    {
        if (CurrentSettings != null)
        {
            ApplySettings(CurrentSettings);
        }
    }

    public bool SendConsoleCommand(string command)
    {
        if (!IsGameAttached || CurrentProfile == null || !CurrentProfile.Cbuf_AddText.HasValue)
            return false;

        return _memoryEngine.ExecuteCommand(
            CurrentProfile.Cbuf_AddText.Value,
            command,
            CurrentProfile.NopAddress ?? 0);
    }

    private void StartKeepAliveLoop()
    {
        if (_keepAliveTask != null && !_keepAliveTask.IsCompleted) return;

        _keepAliveCts = new CancellationTokenSource();
        _keepAliveTask = Task.Run(() => KeepAliveLoopAsync(_keepAliveCts.Token));
    }

    private void StopKeepAliveLoop()
    {
        if (_keepAliveCts != null)
        {
            _keepAliveCts.Cancel();
            _keepAliveCts.Dispose();
            _keepAliveCts = null;
        }

        _keepAliveTask = null;
    }

    private async Task KeepAliveLoopAsync(CancellationToken ct)
    {
        using var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(500));

        while (!ct.IsCancellationRequested)
        {
            try
            {
                if (IsGameAttached && CurrentSettings != null)
                {
                    ApplySettings(CurrentSettings);
                }

                await timer.WaitForNextTickAsync(ct).ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
                break;
            }
            catch
            {
                // Resilient
            }
        }
    }

    public void Dispose()
    {
        Stop();
        _monitorService.Dispose();
        _memoryEngine.Dispose();
    }
}
