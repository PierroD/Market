using System;
using System.IO;
using System.Text.Json;
using System.Windows;
using Wpf.Ui.Appearance;
using Lindra_Market_v3.Models;

namespace Lindra_Market_v3.Utils;

public static class AppSettingsManager
{
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };
    private static readonly string SettingsFilePath;

    public static AppSettings CurrentSettings { get; private set; } = new();

    static AppSettingsManager()
    {
        string appDataFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "LindraMarketV3"
        );

        if (!Directory.Exists(appDataFolder))
        {
            Directory.CreateDirectory(appDataFolder);
        }

        SettingsFilePath = Path.Combine(appDataFolder, "settings.json");
    }

    public static void Initialize()
    {
        Load();
        ApplySettings();
    }

    public static void Load()
    {
        try
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                var loaded = JsonSerializer.Deserialize<AppSettings>(json, JsonOptions);
                if (loaded != null)
                {
                    CurrentSettings = loaded;
                }
            }
        }
        catch
        {
            // Fallback to default if read/parse fails
            CurrentSettings = new AppSettings();
        }
    }

    public static void Save()
    {
        try
        {
            string json = JsonSerializer.Serialize(CurrentSettings, JsonOptions);
            File.WriteAllText(SettingsFilePath, json);
        }
        catch
        {
            // Ignore write errors if any
        }
    }

    public static event EventHandler? ThemeChanged;

    public static void SetTheme(string theme)
    {
        CurrentSettings.Theme = theme;
        ApplyTheme(theme);
        Save();
    }

    public static void SetLanguage(string language)
    {
        CurrentSettings.Language = language;
        LanguageManager.SetLanguage(language);
        Save();
    }

    public static void ApplySettings()
    {
        ApplyTheme(CurrentSettings.Theme);
        LanguageManager.SetLanguage(CurrentSettings.Language);
    }

    public static bool IsDarkTheme()
    {
        string theme = CurrentSettings.Theme;
        if (string.Equals(theme, "Light", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }
        if (string.Equals(theme, "Dark", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        // "Follow Windows"
        return ApplicationThemeManager.IsMatchedDark();
    }

    public static void ApplyThemeToWindow(Window? window)
    {
        if (window == null) return;

        try
        {
            if (IsDarkTheme())
            {
                WindowBackgroundManager.ApplyDarkThemeToWindow(window);
            }
            else
            {
                WindowBackgroundManager.RemoveDarkThemeFromWindow(window);
            }
        }
        catch
        {
            // Ignore if window handle is not yet available
        }
    }

    public static void ApplyTheme(string theme)
    {
        switch (theme)
        {
            case "Light":
                ApplicationThemeManager.Apply(ApplicationTheme.Light);
                break;
            case "Dark":
                ApplicationThemeManager.Apply(ApplicationTheme.Dark);
                break;
            case "Follow Windows":
                ApplicationThemeManager.ApplySystemTheme();
                break;
            default:
                ApplicationThemeManager.Apply(ApplicationTheme.Dark);
                break;
        }

        if (Application.Current != null)
        {
            foreach (Window win in Application.Current.Windows)
            {
                ApplyThemeToWindow(win);
            }
        }

        ThemeChanged?.Invoke(null, EventArgs.Empty);
    }
}
