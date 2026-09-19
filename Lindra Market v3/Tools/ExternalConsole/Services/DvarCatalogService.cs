using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Lindra_Market_v3.Tools.ExternalConsole.Models;

namespace Lindra_Market_v3.Tools.ExternalConsole.Services
{
    public class DvarCatalogService
    {
        private static DvarCatalogService? _instance;
        public static DvarCatalogService Instance => _instance ??= new DvarCatalogService();

        private readonly Dictionary<string, List<DvarItem>> _catalog = new(StringComparer.OrdinalIgnoreCase);
        private bool _isLoaded;
        private readonly object _lock = new();

        private class RawDvar
        {
            [JsonPropertyName("Content")]
            public string? Content { get; set; }

            [JsonPropertyName("Description")]
            public string? Description { get; set; }
        }

        public async Task EnsureLoadedAsync()
        {
            if (_isLoaded) return;

            await Task.Run(() =>
            {
                lock (_lock)
                {
                    if (_isLoaded) return;

                    string? basePath = FindDvarsDirectory();
                    if (basePath == null || !Directory.Exists(basePath))
                    {
                        _isLoaded = true;
                        return;
                    }

                    var gameDirs = Directory.GetDirectories(basePath);
                    foreach (var gameDir in gameDirs)
                    {
                        string gameName = Path.GetFileName(gameDir);
                        var jsonFiles = Directory.GetFiles(gameDir, "*.json");
                        var list = new List<DvarItem>();

                        foreach (var jsonFile in jsonFiles)
                        {
                            try
                            {
                                string json = File.ReadAllText(jsonFile);
                                var items = JsonSerializer.Deserialize<List<RawDvar>>(json);
                                if (items != null)
                                {
                                    foreach (var item in items)
                                    {
                                        string name = (item.Content ?? string.Empty).Trim();
                                        if (string.IsNullOrWhiteSpace(name)) continue;

                                        string desc = (item.Description ?? string.Empty).Trim();
                                        list.Add(new DvarItem
                                        {
                                            Name = name,
                                            Description = desc,
                                            Game = gameName
                                        });
                                    }
                                }
                            }
                            catch
                            {
                                // Skip corrupted or unreadable files safely
                            }
                        }

                        if (list.Count > 0)
                        {
                            _catalog[gameName] = list;
                        }
                    }

                    _isLoaded = true;
                }
            });
        }

        public IReadOnlyList<string> GetAvailableGames()
        {
            return _catalog.Keys.OrderBy(k => k).ToList();
        }

        public IReadOnlyList<DvarItem> Search(string game, string query, int maxResults = 300)
        {
            if (!_catalog.TryGetValue(game, out var list))
                return Array.Empty<DvarItem>();

            if (string.IsNullOrWhiteSpace(query))
                return list.Take(maxResults).ToList();

            var trimmed = query.Trim();

            // Order: StartsWith in Name first, then Contains in Name, then Contains in Description
            return list
                .Where(d => d.Name.Contains(trimmed, StringComparison.OrdinalIgnoreCase) ||
                            d.Description.Contains(trimmed, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(d => d.Name.StartsWith(trimmed, StringComparison.OrdinalIgnoreCase))
                .ThenByDescending(d => d.Name.Contains(trimmed, StringComparison.OrdinalIgnoreCase))
                .Take(maxResults)
                .ToList();
        }

        public int GetTotalCount(string game)
        {
            return _catalog.TryGetValue(game, out var list) ? list.Count : 0;
        }

        public string? ResolveGameKey(string? gameNameOrProcess)
        {
            if (string.IsNullOrWhiteSpace(gameNameOrProcess))
                return null;

            string lower = gameNameOrProcess.ToLowerInvariant();

            if (lower.Contains("blackops") || lower.Contains("black ops") || lower.Contains("bo1") || lower.Contains("t5"))
                return _catalog.ContainsKey("BO1") ? "BO1" : null;

            if (lower.Contains("iw3") || lower.Contains("cod4") || lower.Contains("modern warfare ") || lower.Contains("call of duty 4"))
                return _catalog.ContainsKey("COD4") ? "COD4" : null;

            if (lower.Contains("iw4") || lower.Contains("mw2") || lower.Contains("modern warfare 2"))
                return _catalog.ContainsKey("MW2") ? "MW2" : null;

            if (lower.Contains("iw5") || lower.Contains("mw3") || lower.Contains("modern warfare 3"))
                return _catalog.ContainsKey("MW3") ? "MW3" : null;

            return null;
        }

        private static string? FindDvarsDirectory()
        {
            // 1. Output directory Resources/Dvars
            string p1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Dvars");
            if (Directory.Exists(p1)) return p1;

            // 2. Output directory dvars
            string p2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dvars");
            if (Directory.Exists(p2)) return p2;

            // 3. Project directory fallback
            string current = AppDomain.CurrentDomain.BaseDirectory;
            for (int i = 0; i < 4; i++)
            {
                var parent = Directory.GetParent(current);
                if (parent == null) break;
                current = parent.FullName;

                string candidate = Path.Combine(current, "Lindra Market v3", "Resources", "Dvars");
                if (Directory.Exists(candidate)) return candidate;

                string candidateDirect = Path.Combine(current, "Resources", "Dvars");
                if (Directory.Exists(candidateDirect)) return candidateDirect;
            }

            return null;
        }
    }
}
