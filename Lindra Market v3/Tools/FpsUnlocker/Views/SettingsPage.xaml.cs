using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using Wpf.Ui.Controls;
using Lindra_Market_v3.Tools.FpsUnlocker.Services;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.Tools.FpsUnlocker.Views
{
    /// <summary>
    /// Logique d'interaction pour SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SaveConfig_Click(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = LanguageManager.GetString("FpsSettings_Dialog_JsonFilter", "Fichier JSON (*.json)|*.json|Tous les fichiers (*.*)|*.*"),
                DefaultExt = ".json",
                FileName = "visuals_preset.json"
            };

            if (sfd.ShowDialog() == true)
            {
                if (VisualsConfigManager.SaveToFile(sfd.FileName))
                {
                    StatusInfoBar.Severity = InfoBarSeverity.Success;
                    StatusInfoBar.Title = LanguageManager.GetString("FpsSettings_Save_Success_Title", "Sauvegarde réussie");
                    StatusInfoBar.Message = $"{LanguageManager.GetString("FpsSettings_Info_Saved", "Configuration enregistrée dans ")}{Path.GetFileName(sfd.FileName)}";
                }
                else
                {
                    StatusInfoBar.Severity = InfoBarSeverity.Error;
                    StatusInfoBar.Title = LanguageManager.GetString("FpsSettings_Save_Error_Title", "Erreur de sauvegarde");
                    StatusInfoBar.Message = LanguageManager.GetString("FpsSettings_Save_Error_Msg", "Impossible d'écrire le fichier JSON sur le disque.");
                }
            }
        }

        private void LoadConfig_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = LanguageManager.GetString("FpsSettings_Dialog_JsonFilter", "Fichier JSON (*.json)|*.json|Tous les fichiers (*.*)|*.*")
            };

            if (ofd.ShowDialog() == true)
            {
                if (VisualsConfigManager.LoadFromFile(ofd.FileName))
                {
                    VisualsConfigManager.AutoSave();
                    StatusInfoBar.Severity = InfoBarSeverity.Success;
                    StatusInfoBar.Title = LanguageManager.GetString("FpsSettings_Load_Success_Title", "Chargement réussi");
                    StatusInfoBar.Message = $"{LanguageManager.GetString("FpsSettings_Info_Loaded", "Configuration chargée depuis ")}{Path.GetFileName(ofd.FileName)}";
                }
                else
                {
                    StatusInfoBar.Severity = InfoBarSeverity.Error;
                    StatusInfoBar.Title = LanguageManager.GetString("FpsSettings_Load_Error_Title", "Erreur de chargement");
                    StatusInfoBar.Message = LanguageManager.GetString("FpsSettings_Load_Error_Msg", "Le fichier sélectionné n'est pas un fichier JSON de configuration valide.");
                }
            }
        }

        private void ResetConfig_Click(object sender, RoutedEventArgs e)
        {
            VisualsConfigManager.ResetToDefaults();
            StatusInfoBar.Severity = InfoBarSeverity.Warning;
            StatusInfoBar.Title = LanguageManager.GetString("FpsSettings_Reset_Title_Notif", "Valeurs réinitialisées");
            StatusInfoBar.Message = LanguageManager.GetString("FpsSettings_Info_Reset", "Tous les paramètres visuels ont été remis à leurs valeurs par défaut.");
        }

        private void Page_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (PageScrollViewer.ScrollableHeight > 0)
            {
                PageScrollViewer.ScrollToVerticalOffset(PageScrollViewer.VerticalOffset - e.Delta * 0.5);
                e.Handled = true;
            }
        }
    }
}
