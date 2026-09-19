using System;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace Lindra_Market_v3.Utils
{
    public static class AppVersionHelper
    {
        private static string? _version;

        /// <summary>
        /// Version courante de l'application (ex: "v3.0.0").
        /// Résolue dynamiquement à partir de :
        /// 1. AppContext / runtimeconfig.json configProperties ("AppVersion") - fonctionne en standalone et non-standalone
        /// 2. Fichier *.runtimeconfig.json sur disque (si présent en mode non-standalone)
        /// 3. Métadonnées d'assembly (.csproj <Version> / <InformationalVersion>)
        /// </summary>
        public static string Version => _version ??= ResolveVersion();

        private static string ResolveVersion()
        {
            // 1. Lire depuis AppContext (chargé automatiquement par le runtime .NET depuis runtimeconfig.json,
            // y compris lorsque l'application est compilée en standalone single-file bundle)
            object? runtimeConfigVal = AppContext.GetData("AppVersion");
            if (runtimeConfigVal != null)
            {
                string s = runtimeConfigVal.ToString()?.Trim() ?? string.Empty;
                if (!string.IsNullOrEmpty(s))
                {
                    return FormatVersion(s);
                }
            }

            // 2. Tenter de lire directement le fichier *.runtimeconfig.json sur disque (mode non-standalone)
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string appName = Assembly.GetEntryAssembly()?.GetName().Name ?? "Lindra Market v3";
                string jsonPath = Path.Combine(baseDir, $"{appName}.runtimeconfig.json");
                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    using var doc = JsonDocument.Parse(json);
                    if (doc.RootElement.TryGetProperty("runtimeOptions", out var ro) &&
                        ro.TryGetProperty("configProperties", out var cp) &&
                        cp.TryGetProperty("AppVersion", out var av))
                    {
                        string? verStr = av.GetString();
                        if (!string.IsNullOrWhiteSpace(verStr))
                        {
                            return FormatVersion(verStr);
                        }
                    }
                }
            }
            catch
            {
                // Ignorer et passer au fallback
            }

            // 3. Fallback sur les attributs d'assembly (.csproj <Version> / <InformationalVersion>)
            try
            {
                var asm = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
                var infoAttr = asm.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
                if (!string.IsNullOrWhiteSpace(infoAttr?.InformationalVersion))
                {
                    string clean = infoAttr.InformationalVersion.Split('+')[0].Trim();
                    return FormatVersion(clean);
                }

                var asmVer = asm.GetName().Version;
                if (asmVer != null)
                {
                    return $"v{asmVer.Major}.{asmVer.Minor}.{asmVer.Build}";
                }
            }
            catch
            {
                // Fallback
            }

            return "v3.0.0";
        }

        private static string FormatVersion(string version)
        {
            version = version.Trim();
            if (!version.StartsWith('v') && !version.StartsWith('V'))
            {
                return "v" + version;
            }
            return version;
        }
    }
}
