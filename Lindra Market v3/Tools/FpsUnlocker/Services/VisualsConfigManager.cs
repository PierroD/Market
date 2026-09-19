using System;
using System.IO;
using System.Text.Json;
using Lindra_Market_v3.Tools.FpsUnlocker.Models;
using MarketOffsets.Services;

namespace Lindra_Market_v3.Tools.FpsUnlocker.Services;

public static class VisualsConfigManager
{
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };
    private static readonly string DefaultConfigPath;

    public static VisualsConfig CurrentConfig { get; set; } = new();

    public static event EventHandler? ConfigChanged;

    static VisualsConfigManager()
    {
        string appDataFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "LindraMarketV3"
        );

        if (!Directory.Exists(appDataFolder))
        {
            Directory.CreateDirectory(appDataFolder);
        }

        DefaultConfigPath = Path.Combine(appDataFolder, "visuals_config.json");
        LoadAutoSaved();

        GameMemoryService.Instance.CurrentSettings = CurrentConfig;
    }

    public static void NotifyConfigChanged()
    {
        ConfigChanged?.Invoke(null, EventArgs.Empty);
        GameMemoryService.Instance.ApplySettings(CurrentConfig);
    }

    public static void AutoSave()
    {
        SaveToFile(DefaultConfigPath);
        GameMemoryService.Instance.ApplySettings(CurrentConfig);
    }

    public static void LoadAutoSaved()
    {
        if (File.Exists(DefaultConfigPath))
        {
            LoadFromFile(DefaultConfigPath);
        }
    }

    public static bool SaveToFile(string filePath)
    {
        try
        {
            var json = JsonSerializer.Serialize(CurrentConfig, JsonOptions);
            File.WriteAllText(filePath, json);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool LoadFromFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath)) return false;
            var json = File.ReadAllText(filePath);
            var loaded = JsonSerializer.Deserialize<VisualsConfig>(json, JsonOptions);
            if (loaded != null)
            {
                CurrentConfig = loaded;
                NotifyConfigChanged();
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public static void ResetToDefaults()
    {
        CurrentConfig = new VisualsConfig();
        AutoSave();
        NotifyConfigChanged();
    }
}
