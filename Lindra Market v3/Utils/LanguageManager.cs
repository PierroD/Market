using System;
using System.Linq;
using System.Windows;

namespace Lindra_Market_v3.Utils;

public static class LanguageManager
{
    public static string CurrentLanguage { get; private set; } = "fr";

    public static event EventHandler? LanguageChanged;

    public static string GetString(string key, string fallback = "")
    {
        if (Application.Current?.TryFindResource(key) is string val)
        {
            return val;
        }
        return fallback;
    }

    public static void SetLanguage(string languageCode)
    {
        try
        {
            var uri = new Uri($"pack://application:,,,/Resources/Languages/Strings.{languageCode}.xaml", UriKind.Absolute);
            var newDict = new ResourceDictionary { Source = uri };

            var merged = Application.Current.Resources.MergedDictionaries;

            for (int i = merged.Count - 1; i >= 0; i--)
            {
                if (merged[i].Source != null && merged[i].Source.OriginalString.Contains("/Resources/Languages/Strings."))
                {
                    merged.RemoveAt(i);
                }
            }

            merged.Add(newDict);
            CurrentLanguage = languageCode;
            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }
        catch
        {
            // Ignore if failed
        }
    }
}
