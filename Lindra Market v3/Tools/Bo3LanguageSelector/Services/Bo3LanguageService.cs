using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Lindra_Market_v3.Tools.Bo3LanguageSelector.Models;

namespace Lindra_Market_v3.Tools.Bo3LanguageSelector.Services
{
    public class Bo3LanguageService
    {
        private static Bo3LanguageService? _instance;
        public static Bo3LanguageService Instance => _instance ??= new Bo3LanguageService();

        private readonly string _settingsFilePath;
        private readonly List<Bo3Language> _availableLanguages = new();
        private readonly List<Bo3MapItem> _loadedMaps = new();

        public Bo3Settings Settings { get; private set; } = new();
        public IReadOnlyList<Bo3Language> AvailableLanguages => _availableLanguages;
        public IReadOnlyList<Bo3MapItem> LoadedMaps => _loadedMaps;

        private class RawWorkshopJson
        {
            public string? Title { get; set; }
            public string? Description { get; set; }
            public string? FolderName { get; set; }
            public string? PublisherID { get; set; }
            public string? Tags { get; set; }
            public string? Thumbnail { get; set; }
            public string? Type { get; set; }
        }

        public Bo3LanguageService()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folder = Path.Combine(appData, "LindraMarket");
            Directory.CreateDirectory(folder);
            _settingsFilePath = Path.Combine(folder, "bo3_settings.json");

            LoadSettings();
            LoadLanguages();
        }

        public void LoadSettings()
        {
            try
            {
                if (File.Exists(_settingsFilePath))
                {
                    string json = File.ReadAllText(_settingsFilePath);
                    var loaded = JsonSerializer.Deserialize<Bo3Settings>(json);
                    if (loaded != null)
                    {
                        Settings = loaded;
                    }
                }
            }
            catch
            {
                Settings = new Bo3Settings();
            }

            if (string.IsNullOrWhiteSpace(Settings.WorkshopPath) || !Directory.Exists(Settings.WorkshopPath))
            {
                string? detected = SteamPathDetector.DetectBo3WorkshopPath();
                if (!string.IsNullOrEmpty(detected))
                {
                    Settings.WorkshopPath = detected;
                    SaveSettings();
                }
            }
        }

        public void SaveSettings()
        {
            try
            {
                string json = JsonSerializer.Serialize(Settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_settingsFilePath, json);
            }
            catch
            {
                // Ignore save errors
            }
        }

        private void LoadLanguages()
        {
            _availableLanguages.Clear();
            string? langFilePath = FindLanguagesFile();

            if (!string.IsNullOrEmpty(langFilePath) && File.Exists(langFilePath))
            {
                try
                {
                    string json = File.ReadAllText(langFilePath);
                    var list = JsonSerializer.Deserialize<List<Bo3Language>>(json);
                    if (list != null)
                    {
                        _availableLanguages.AddRange(list.OrderBy(l => l.Name));
                    }
                }
                catch
                {
                    // Fallback to basic list below
                }
            }

            if (_availableLanguages.Count == 0)
            {
                _availableLanguages.AddRange(new[]
                {
                    new Bo3Language { Key = "fr", Name = "Français" },
                    new Bo3Language { Key = "en", Name = "English" },
                    new Bo3Language { Key = "de", Name = "Deutsch" },
                    new Bo3Language { Key = "es", Name = "Español" },
                    new Bo3Language { Key = "it", Name = "Italiano" },
                    new Bo3Language { Key = "ru", Name = "Русский" },
                    new Bo3Language { Key = "pl", Name = "Polski" },
                    new Bo3Language { Key = "ja", Name = "日本語" },
                    new Bo3Language { Key = "zh", Name = "中文" }
                });
            }
        }

        public Task<List<Bo3MapItem>> LoadMapsAsync() => ScanMapsAsync();

        public async Task<List<Bo3MapItem>> ScanMapsAsync()
        {
            return await Task.Run(() =>
            {
                _loadedMaps.Clear();

                if (string.IsNullOrWhiteSpace(Settings.WorkshopPath) || !Directory.Exists(Settings.WorkshopPath))
                {
                    return _loadedMaps;
                }

                var dirs = Directory.GetDirectories(Settings.WorkshopPath);
                foreach (var dir in dirs)
                {
                    try
                    {
                        string workshopJsonPath = Path.Combine(dir, "workshop.json");
                        if (!File.Exists(workshopJsonPath)) continue;

                        string json = File.ReadAllText(workshopJsonPath);
                        var raw = JsonSerializer.Deserialize<RawWorkshopJson>(json);
                        if (raw == null || string.IsNullOrWhiteSpace(raw.FolderName)) continue;

                        var mapItem = new Bo3MapItem
                        {
                            DirectoryPath = dir,
                            Title = raw.Title ?? Path.GetFileName(dir),
                            Description = raw.Description ?? string.Empty,
                            FolderName = raw.FolderName,
                            PublisherId = raw.PublisherID ?? Path.GetFileName(dir),
                            Tags = raw.Tags ?? string.Empty,
                            ThumbnailPath = FindThumbnail(dir)
                        };

                        // Scan for fastfiles to detect installed languages
                        ScanInstalledLanguages(mapItem);

                        _loadedMaps.Add(mapItem);
                    }
                    catch
                    {
                        // Skip corrupted workshop entry
                    }
                }

                return _loadedMaps.OrderBy(m => m.Title).ToList();
            });
        }

        public bool PatchMap(Bo3MapItem map, string targetLangKey)
        {
            if (string.IsNullOrWhiteSpace(map.DirectoryPath) || !Directory.Exists(map.DirectoryPath))
                return false;

            if (string.Equals(targetLangKey, "en", StringComparison.OrdinalIgnoreCase))
                return true; // English is base

            try
            {
                var files = Directory.GetFiles(map.DirectoryPath, $"*_{map.FolderName}*.ff", SearchOption.AllDirectories);
                string enPrefix = $"en_{map.FolderName}";
                string targetPrefix = $"{targetLangKey}_{map.FolderName}";

                var enFiles = files.Where(f => Path.GetFileName(f).Contains(enPrefix, StringComparison.OrdinalIgnoreCase)).ToList();

                if (enFiles.Count == 0)
                {
                    // If no explicit en_ prefix found, look for any .ff
                    enFiles = files.Where(f => !Path.GetFileName(f).StartsWith($"{targetLangKey}_", StringComparison.OrdinalIgnoreCase)).ToList();
                }

                foreach (var file in enFiles)
                {
                    string dir = Path.GetDirectoryName(file)!;
                    string fileName = Path.GetFileName(file);
                    string targetFileName;

                    if (fileName.Contains(enPrefix, StringComparison.OrdinalIgnoreCase))
                    {
                        // Replace en_<folder> with <lang>_<folder>
                        int idx = fileName.IndexOf(enPrefix, StringComparison.OrdinalIgnoreCase);
                        targetFileName = fileName.Substring(0, idx) + targetPrefix + fileName.Substring(idx + enPrefix.Length);
                    }
                    else
                    {
                        targetFileName = $"{targetLangKey}_{fileName}";
                    }

                    string targetPath = Path.Combine(dir, targetFileName);
                    File.Copy(file, targetPath, overwrite: true);
                }

                ScanInstalledLanguages(map);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UnpatchMap(Bo3MapItem map, string targetLangKey)
        {
            if (string.Equals(targetLangKey, "en", StringComparison.OrdinalIgnoreCase))
                return false; // Cannot delete source English files

            try
            {
                var files = Directory.GetFiles(map.DirectoryPath, $"{targetLangKey}_{map.FolderName}*.ff", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    File.Delete(file);
                }

                ScanInstalledLanguages(map);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<int> PatchAllMapsAsync(IEnumerable<Bo3MapItem> maps, string targetLangKey, IProgress<(int current, int total, string mapTitle)>? progress = null)
        {
            return await Task.Run(() =>
            {
                var list = maps.ToList();
                int total = list.Count;
                int patchedCount = 0;

                for (int i = 0; i < total; i++)
                {
                    var map = list[i];
                    progress?.Report((i + 1, total, map.Title));

                    if (PatchMap(map, targetLangKey))
                    {
                        patchedCount++;
                    }
                }

                return patchedCount;
            });
        }

        private void ScanInstalledLanguages(Bo3MapItem map)
        {
            try
            {
                var files = Directory.GetFiles(map.DirectoryPath, $"*_{map.FolderName}*.ff", SearchOption.AllDirectories);
                var langs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var file in files)
                {
                    string name = Path.GetFileName(file);
                    // Match prefix like "fr_zm_map.ff" -> prefix is "fr"
                    int separatorIdx = name.IndexOf('_');
                    if (separatorIdx > 0 && separatorIdx <= 3)
                    {
                        string candidate = name.Substring(0, separatorIdx).ToLowerInvariant();
                        if (_availableLanguages.Any(l => string.Equals(l.Key, candidate, StringComparison.OrdinalIgnoreCase)))
                        {
                            langs.Add(candidate);
                        }
                    }
                }

                void UpdateCollection()
                {
                    map.InstalledLanguages.Clear();
                    foreach (var l in langs.OrderBy(x => x))
                    {
                        map.InstalledLanguages.Add(l);
                    }
                    map.NotifyLanguagesChanged();
                }

                if (System.Windows.Application.Current?.Dispatcher != null &&
                    !System.Windows.Application.Current.Dispatcher.CheckAccess())
                {
                    System.Windows.Application.Current.Dispatcher.Invoke(UpdateCollection);
                }
                else
                {
                    UpdateCollection();
                }
            }
            catch
            {
                // Ignore
            }
        }

        private static string? FindThumbnail(string dir)
        {
            string[] candidates = new[]
            {
                Path.Combine(dir, "previewimage.png"),
                Path.Combine(dir, "thumbnail.png"),
                Path.Combine(dir, "preview.png"),
                Path.Combine(dir, "preview.jpg"),
                Path.Combine(dir, "thumb.jpg")
            };

            foreach (var c in candidates)
            {
                if (File.Exists(c)) return c;
            }

            return null;
        }

        private static string? FindLanguagesFile()
        {
            string p1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Bo3", "languages.json");
            if (File.Exists(p1)) return p1;

            string p2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bo3", "languages.json");
            if (File.Exists(p2)) return p2;

            string current = AppDomain.CurrentDomain.BaseDirectory;
            for (int i = 0; i < 4; i++)
            {
                var parent = Directory.GetParent(current);
                if (parent == null) break;
                current = parent.FullName;

                string candidate = Path.Combine(current, "Lindra Market v3", "Resources", "Bo3", "languages.json");
                if (File.Exists(candidate)) return candidate;
            }

            return null;
        }
    }
}
