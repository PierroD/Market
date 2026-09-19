using System;
using System.Diagnostics;
using System.IO;

namespace Lindra_Market_v3.Utils
{
    public static class ShortcutHelper
    {
        public static bool CreateDesktopShortcut(out string? error)
        {
            error = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                if (string.IsNullOrEmpty(desktopPath) || !Directory.Exists(desktopPath))
                {
                    desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }

                if (string.IsNullOrEmpty(desktopPath) || !Directory.Exists(desktopPath))
                {
                    error = "Impossible de localiser le dossier Bureau.";
                    return false;
                }

                string shortcutPath = Path.Combine(desktopPath, "Lindra Market.lnk");

                string? exePath = Environment.ProcessPath;
                if (string.IsNullOrEmpty(exePath) || !File.Exists(exePath))
                {
                    using var proc = Process.GetCurrentProcess();
                    exePath = proc.MainModule?.FileName;
                }

                if (string.IsNullOrEmpty(exePath) || !File.Exists(exePath))
                {
                    error = "Impossible de localiser l'exécutable de l'application.";
                    return false;
                }

                string workingDir = Path.GetDirectoryName(exePath) ?? AppDomain.CurrentDomain.BaseDirectory;

                Type? shellType = Type.GetTypeFromProgID("WScript.Shell");
                if (shellType == null)
                {
                    error = "Le composant système WScript.Shell est indisponible.";
                    return false;
                }

                dynamic shell = Activator.CreateInstance(shellType)!;
                dynamic shortcut = shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = exePath;
                shortcut.WorkingDirectory = workingDir;
                shortcut.Description = "Lindra Market v3";
                shortcut.IconLocation = $"{exePath},0";
                shortcut.Save();

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
