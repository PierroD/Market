using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Lindra_Market_v3.Tools.Bo3LanguageSelector.Services
{
    public static class SteamPathDetector
    {
        private const string Bo3AppId = "311210";

        public static string? DetectBo3WorkshopPath()
        {
            var libraryRoots = GetSteamLibraryFolders();

            foreach (var root in libraryRoots)
            {
                string workshopPath = Path.Combine(root, "steamapps", "workshop", "content", Bo3AppId);
                if (Directory.Exists(workshopPath))
                {
                    return workshopPath;
                }
            }

            // Fallback: search common drive roots
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (!drive.IsReady) continue;

                string[] candidates = new[]
                {
                    Path.Combine(drive.RootDirectory.FullName, "Jeux", "Steam", "steamapps", "workshop", "content", Bo3AppId),
                    Path.Combine(drive.RootDirectory.FullName, "Games", "Steam", "steamapps", "workshop", "content", Bo3AppId),
                    Path.Combine(drive.RootDirectory.FullName, "SteamLibrary", "steamapps", "workshop", "content", Bo3AppId),
                    Path.Combine(drive.RootDirectory.FullName, "Program Files (x86)", "Steam", "steamapps", "workshop", "content", Bo3AppId),
                    Path.Combine(drive.RootDirectory.FullName, "Steam", "steamapps", "workshop", "content", Bo3AppId)
                };

                foreach (var candidate in candidates)
                {
                    if (Directory.Exists(candidate))
                        return candidate;
                }
            }

            return null;
        }

        private static List<string> GetSteamLibraryFolders()
        {
            var folders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            string? steamRoot = GetSteamInstallPath();
            if (!string.IsNullOrEmpty(steamRoot) && Directory.Exists(steamRoot))
            {
                folders.Add(steamRoot);

                string vdfPath = Path.Combine(steamRoot, "steamapps", "libraryfolders.vdf");
                if (File.Exists(vdfPath))
                {
                    try
                    {
                        string content = File.ReadAllText(vdfPath);
                        // Regex matches "path" "D:\\SteamLibrary"
                        var matches = Regex.Matches(content, @"""path""\s+""([^""]+)""", RegexOptions.IgnoreCase);
                        foreach (Match m in matches)
                        {
                            if (m.Groups.Count > 1)
                            {
                                string libPath = m.Groups[1].Value.Replace(@"\\", @"\");
                                if (Directory.Exists(libPath))
                                {
                                    folders.Add(libPath);
                                }
                            }
                        }
                    }
                    catch
                    {
                        // Ignore parsing errors
                    }
                }
            }

            return new List<string>(folders);
        }

        private static string? GetSteamInstallPath()
        {
            try
            {
                using var key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam");
                if (key?.GetValue("SteamPath") is string steamPath && Directory.Exists(steamPath))
                {
                    return steamPath.Replace('/', '\\');
                }
            }
            catch
            {
                // Registry read might be restricted
            }

            try
            {
                using var key64 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Valve\Steam");
                if (key64?.GetValue("InstallPath") is string installPath && Directory.Exists(installPath))
                {
                    return installPath;
                }
            }
            catch
            {
                // Ignore
            }

            return null;
        }
    }
}
