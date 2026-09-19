using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Wpf.Ui.Controls;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.Views
{
    /// <summary>
    /// Logique d'interaction pour SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        private static readonly string CurrentVersion = AppVersionHelper.Version;
        private const string LatestVersionUrl = "https://raw.githubusercontent.com/PierroD/Market/main/_readmes/lastestVersion.md";
        private const string ChangelogsUrl = "https://raw.githubusercontent.com/PierroD/Market/main/_readmes/updateChanges.md";

        private static readonly HttpClient HttpClient = new();
        private bool _isInitializingUi = true;

        public SettingsPage()
        {
            InitializeComponent();

            CurrentVersionText.Text = CurrentVersion;

            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            SyncControlsFromSettings();
            await CheckForUpdatesAsync();
            await LoadChangelogsAsync();
        }

        private void SyncControlsFromSettings()
        {
            _isInitializingUi = true;
            try
            {
                // Synchroniser le thème sélectionné
                string currentTheme = AppSettingsManager.CurrentSettings.Theme;
                foreach (ComboBoxItem item in ThemeComboBox.Items)
                {
                    if (string.Equals(item.Tag?.ToString(), currentTheme, StringComparison.OrdinalIgnoreCase))
                    {
                        ThemeComboBox.SelectedItem = item;
                        break;
                    }
                }

                // Synchroniser la langue sélectionnée
                string currentLang = AppSettingsManager.CurrentSettings.Language;
                foreach (ComboBoxItem item in LanguageComboBox.Items)
                {
                    if (string.Equals(item.Tag?.ToString(), currentLang, StringComparison.OrdinalIgnoreCase))
                    {
                        LanguageComboBox.SelectedItem = item;
                        break;
                    }
                }
            }
            finally
            {
                _isInitializingUi = false;
            }
        }

        private async void OnCheckUpdateClick(object sender, RoutedEventArgs e)
        {
            await CheckForUpdatesAsync();
        }

        private async void OnRefreshChangelogsClick(object sender, RoutedEventArgs e)
        {
            await LoadChangelogsAsync();
        }

        private async Task CheckForUpdatesAsync()
        {
            try
            {
                LatestVersionText.Text = "Vérification...";
                var response = await HttpClient.GetStringAsync(LatestVersionUrl);
                var latest = response?.Trim() ?? string.Empty;

                if (string.IsNullOrEmpty(latest))
                {
                    LatestVersionText.Text = "Inconnu";
                    return;
                }

                if (!latest.StartsWith("v", StringComparison.OrdinalIgnoreCase))
                {
                    latest = "v" + latest;
                }

                LatestVersionText.Text = latest;

                if (string.Equals(CurrentVersion, latest, StringComparison.OrdinalIgnoreCase))
                {
                    LatestVersionText.Foreground = (System.Windows.Media.Brush)Application.Current.Resources["TextFillColorSecondaryBrush"];
                }
                else
                {
                    LatestVersionText.Foreground = (System.Windows.Media.Brush)Application.Current.Resources["SystemAccentColorPrimaryBrush"];
                }
            }
            catch
            {
                LatestVersionText.Text = "Erreur réseau";
            }
        }

        private async Task LoadChangelogsAsync()
        {
            try
            {
                ChangelogsTextBox.Text = "Chargement des changelogs depuis GitHub...";
                var changelogs = await HttpClient.GetStringAsync(ChangelogsUrl);
                ChangelogsTextBox.Text = string.IsNullOrWhiteSpace(changelogs) ? "Aucun changelog disponible." : changelogs;
            }
            catch (Exception ex)
            {
                ChangelogsTextBox.Text = $"Impossible de charger les changelogs.\nErreur : {ex.Message}";
            }
        }

        private void OnThemeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isInitializingUi) return;

            if (ThemeComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string tag = selectedItem.Tag?.ToString() ?? "Dark";
                AppSettingsManager.SetTheme(tag);
            }
        }

        private void OnLanguageSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isInitializingUi) return;

            if (LanguageComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string langCode = selectedItem.Tag?.ToString() ?? "fr";
                AppSettingsManager.SetLanguage(langCode);
            }
        }

        private async void OnCreateShortcutClick(object sender, RoutedEventArgs e)
        {
            if (ShortcutHelper.CreateDesktopShortcut(out string? error))
            {
                CreateShortcutButton.Icon = new Wpf.Ui.Controls.SymbolIcon(Wpf.Ui.Controls.SymbolRegular.Checkmark24);
                CreateShortcutButton.SetResourceReference(ContentControl.ContentProperty, "Settings_Shortcut_Success");
                await Task.Delay(2000);
                CreateShortcutButton.Icon = new Wpf.Ui.Controls.SymbolIcon(Wpf.Ui.Controls.SymbolRegular.Link24);
                CreateShortcutButton.SetResourceReference(ContentControl.ContentProperty, "Settings_Shortcut_Btn");
            }
            else
            {
                string format = LanguageManager.GetString("Settings_Shortcut_Error", "Erreur lors de la création du raccourci : {0}");
                System.Windows.MessageBox.Show(
                    string.Format(format, error),
                    LanguageManager.GetString("Settings_Shortcut_Title", "Raccourci"),
                    System.Windows.MessageBoxButton.OK,
                    System.Windows.MessageBoxImage.Error);
            }
        }

        private void Page_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            // Ne pas intercepter si le curseur survole la zone de texte des changelogs
            if (e.OriginalSource is DependencyObject depObj)
            {
                DependencyObject? current = depObj;
                while (current != null)
                {
                    if (current == ChangelogsTextBox)
                        return;
                    current = VisualTreeHelper.GetParent(current);
                }
            }

            if (PageScrollViewer.ScrollableHeight > 0)
            {
                PageScrollViewer.ScrollToVerticalOffset(PageScrollViewer.VerticalOffset - e.Delta * 0.5);
                e.Handled = true;
            }
        }
    }
}
