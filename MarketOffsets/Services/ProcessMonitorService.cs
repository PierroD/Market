using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MarketOffsets.Profiles;

namespace MarketOffsets.Services;

public sealed class ProcessMonitorService : IDisposable
{
    private CancellationTokenSource? _cts;
    private Task? _monitorTask;
    private readonly TimeSpan _pollingInterval;
    private int _lastProcessId = 0;

    public event EventHandler<(IGameProfile Profile, Process Process)>? GameAttached;
    public event EventHandler? GameDetached;

    public bool IsRunning => _monitorTask != null && !_monitorTask.IsCompleted;

    public ProcessMonitorService(TimeSpan? pollingInterval = null)
    {
        _pollingInterval = pollingInterval ?? TimeSpan.FromMilliseconds(1000);
    }

    public void Start()
    {
        if (IsRunning) return;

        _cts = new CancellationTokenSource();
        _monitorTask = Task.Run(() => MonitorLoopAsync(_cts.Token));
    }

    public void Stop()
    {
        if (_cts != null)
        {
            _cts.Cancel();
            _cts.Dispose();
            _cts = null;
        }

        _monitorTask = null;
        _lastProcessId = 0;
    }

    private async Task MonitorLoopAsync(CancellationToken ct)
    {
        using var timer = new PeriodicTimer(_pollingInterval);

        while (!ct.IsCancellationRequested)
        {
            try
            {
                var (profile, process) = GameRegistry.FindRunningGame();

                if (profile != null && process != null)
                {
                    if (_lastProcessId != process.Id)
                    {
                        _lastProcessId = process.Id;
                        GameAttached?.Invoke(this, (profile, process));
                    }
                }
                else
                {
                    if (_lastProcessId != 0)
                    {
                        _lastProcessId = 0;
                        GameDetached?.Invoke(this, EventArgs.Empty);
                    }
                }

                await timer.WaitForNextTickAsync(ct).ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
                break;
            }
            catch
            {
                // Resilient to transient process query errors
            }
        }
    }

    public void Dispose()
    {
        Stop();
    }
}
