using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Lindra_Market_v3.Tools.Bo3LanguageSelector.Models;
using Lindra_Market_v3.Tools.Bo3LanguageSelector.Services;
using Microsoft.Win32;

namespace Lindra_Market_v3.Tools.Bo3LanguageSelector.Views
{
    public partial class Bo3SettingsPage : Page
    {
        private bool _isInitializing = true;
        public static event Action? OnWorkshopPathChanged;

        public Bo3SettingsPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            _isInitializing = true;
            try
            {
                var service = Bo3LanguageService.Instance;

                // Load languages in ComboBox
                CmbFavLanguage.ItemsSource = service.AvailableLanguages;
                if (service.AvailableLanguages.Count > 0)
                {
                    var selected = service.AvailableLanguages.FirstOrDefault(l =>
                        string.Equals(l.Key, service.Settings.FavoriteLanguageKey, StringComparison.OrdinalIgnoreCase))
                        ?? service.AvailableLanguages.FirstOrDefault();

                    CmbFavLanguage.SelectedItem = selected;
                }

                // Load current workshop path
                TxtWorkshopPath.Text = service.Settings.WorkshopPath;
                UpdatePathStatus(TxtWorkshopPath.Text);
            }
            finally
            {
                _isInitializing = false;
            }
        }

        private void BtnAutoDetect_Click(object sender, RoutedEventArgs e)
        {
            string? detected = SteamPathDetector.DetectBo3WorkshopPath();
            if (!string.IsNullOrEmpty(detected) && Directory.Exists(detected))
            {
                TxtWorkshopPath.Text = detected;
                SavePath(detected);
            }
            else
            {
                MessageBox.Show(
                    "Impossible de détecter automatiquement le dossier Steam Workshop de Black Ops III (311210).\nVeuillez le spécifier manuellement.",
                    "Détection automatique",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
        }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new OpenFolderDialog
                {
                    Title = "Sélectionner le dossier Workshop BO3 (steamapps/workshop/content/311210)",
                    InitialDirectory = Directory.Exists(TxtWorkshopPath.Text) ? TxtWorkshopPath.Text : null
                };

                if (dialog.ShowDialog() == true)
                {
                    TxtWorkshopPath.Text = dialog.FolderName;
                    SavePath(dialog.FolderName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection du dossier : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TxtWorkshopPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_isInitializing) return;

            string path = TxtWorkshopPath.Text.Trim();
            UpdatePathStatus(path);
            SavePath(path);
        }

        private void SavePath(string path)
        {
            var service = Bo3LanguageService.Instance;
            if (service.Settings.WorkshopPath != path)
            {
                service.Settings.WorkshopPath = path;
                service.SaveSettings();
                OnWorkshopPathChanged?.Invoke();
            }
        }

        private void UpdatePathStatus(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                IconPathStatus.Symbol = Wpf.Ui.Controls.SymbolRegular.Warning24;
                IconPathStatus.Foreground = (Brush)FindResource("SystemFillColorCautionBrush");
                TxtPathStatus.Foreground = (Brush)FindResource("SystemFillColorCautionBrush");
                TxtPathStatus.Text = "Aucun dossier configuré";
                return;
            }

            if (Directory.Exists(path))
            {
                int subDirs = 0;
                try
                {
                    subDirs = Directory.GetDirectories(path).Length;
                }
                catch { }

                IconPathStatus.Symbol = Wpf.Ui.Controls.SymbolRegular.CheckmarkCircle24;
                IconPathStatus.Foreground = (Brush)FindResource("SystemFillColorSuccessBrush");
                TxtPathStatus.Foreground = (Brush)FindResource("SystemFillColorSuccessBrush");
                TxtPathStatus.Text = $"Dossier valide ({subDirs} éléments détectés)";
            }
            else
            {
                IconPathStatus.Symbol = Wpf.Ui.Controls.SymbolRegular.DismissCircle24;
                IconPathStatus.Foreground = (Brush)FindResource("SystemFillColorCriticalBrush");
                TxtPathStatus.Foreground = (Brush)FindResource("SystemFillColorCriticalBrush");
                TxtPathStatus.Text = "Ce dossier n'existe pas ou est inaccessible";
            }
        }

        private void CmbFavLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isInitializing) return;

            if (CmbFavLanguage.SelectedItem is Bo3Language lang)
            {
                var service = Bo3LanguageService.Instance;
                service.Settings.FavoriteLanguageKey = lang.Key;
                service.SaveSettings();
            }
        }

        private void Page_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (PageScrollViewer.ScrollableHeight > 0)
            {
                PageScrollViewer.ScrollToVerticalOffset(PageScrollViewer.VerticalOffset - e.Delta * 0.5);
                e.Handled = true;
            }
        }
    }
}
