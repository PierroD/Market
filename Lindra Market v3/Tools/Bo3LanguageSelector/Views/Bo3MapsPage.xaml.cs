using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Lindra_Market_v3.Tools.Bo3LanguageSelector.Models;
using Lindra_Market_v3.Tools.Bo3LanguageSelector.Services;

namespace Lindra_Market_v3.Tools.Bo3LanguageSelector.Views
{
    public partial class Bo3MapsPage : Page
    {
        private List<Bo3MapItem> _allMaps = new();
        private string _selectedLangKey = "fr";
        private bool _isBusy = false;

        public static event Action<int>? OnMapCountUpdated;

        public Bo3MapsPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            Bo3SettingsPage.OnWorkshopPathChanged += HandleWorkshopPathChanged;

            // Load languages
            var service = Bo3LanguageService.Instance;
            TargetLangComboBox.ItemsSource = service.AvailableLanguages;

            string favKey = !string.IsNullOrEmpty(service.Settings.FavoriteLanguageKey)
                ? service.Settings.FavoriteLanguageKey
                : "fr";

            var initialLang = service.AvailableLanguages.FirstOrDefault(l =>
                string.Equals(l.Key, favKey, StringComparison.OrdinalIgnoreCase))
                ?? service.AvailableLanguages.FirstOrDefault();

            if (initialLang != null)
            {
                TargetLangComboBox.SelectedItem = initialLang;
                _selectedLangKey = initialLang.Key;
            }

            await LoadMapsAsync();
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            Bo3SettingsPage.OnWorkshopPathChanged -= HandleWorkshopPathChanged;
        }

        private async void HandleWorkshopPathChanged()
        {
            await LoadMapsAsync();
        }

        private async Task LoadMapsAsync()
        {
            if (_isBusy) return;
            _isBusy = true;

            LoadingPanel.Visibility = Visibility.Visible;
            EmptyStatePanel.Visibility = Visibility.Collapsed;
            MapsItemsControl.Visibility = Visibility.Collapsed;

            try
            {
                var service = Bo3LanguageService.Instance;
                var maps = await service.LoadMapsAsync();
                _allMaps = maps.ToList();

                UpdateAllTargetStatuses();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des cartes : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                LoadingPanel.Visibility = Visibility.Collapsed;
                _isBusy = false;
            }
        }

        private void UpdateAllTargetStatuses()
        {
            foreach (var map in _allMaps)
            {
                map.UpdateTargetLanguageStatus(_selectedLangKey);
            }
        }

        private void ApplyFilter()
        {
            string query = SearchTextBox.Text?.Trim() ?? string.Empty;

            IEnumerable<Bo3MapItem> filtered = _allMaps;
            if (!string.IsNullOrWhiteSpace(query))
            {
                filtered = filtered.Where(m =>
                    m.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                    m.FolderName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                    m.Tags.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                    m.PublisherId.Contains(query, StringComparison.OrdinalIgnoreCase));
            }

            var list = filtered.ToList();
            MapsItemsControl.ItemsSource = list;

            if (_allMaps.Count == 0)
            {
                EmptyStatePanel.Visibility = Visibility.Visible;
                MapsItemsControl.Visibility = Visibility.Collapsed;
            }
            else
            {
                EmptyStatePanel.Visibility = Visibility.Collapsed;
                MapsItemsControl.Visibility = Visibility.Visible;
            }

            OnMapCountUpdated?.Invoke(_allMaps.Count);
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilter();
        }

        private void TargetLangComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TargetLangComboBox.SelectedItem is Bo3Language lang)
            {
                _selectedLangKey = lang.Key;
                UpdateAllTargetStatuses();
                ApplyFilter();
            }
        }

        private async void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            await LoadMapsAsync();
        }

        private void BtnPatch_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement elem && elem.Tag is Bo3MapItem map)
            {
                bool success = Bo3LanguageService.Instance.PatchMap(map, _selectedLangKey);
                if (success)
                {
                    map.UpdateTargetLanguageStatus(_selectedLangKey);
                }
                else
                {
                    MessageBox.Show(
                        $"Impossible de patcher la carte \"{map.Title}\".\nVérifiez les permissions d'accès au dossier.",
                        "Erreur",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
            }
        }

        private void BtnUnpatch_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement elem && elem.Tag is Bo3MapItem map)
            {
                bool success = Bo3LanguageService.Instance.UnpatchMap(map, _selectedLangKey);
                if (success)
                {
                    map.UpdateTargetLanguageStatus(_selectedLangKey);
                }
                else
                {
                    MessageBox.Show(
                        $"Impossible de retirer la langue pour \"{map.Title}\".",
                        "Erreur",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
            }
        }

        private async void BtnPatchAll_Click(object sender, RoutedEventArgs e)
        {
            if (_allMaps.Count == 0)
            {
                MessageBox.Show("Aucune carte à patcher.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            string langName = (TargetLangComboBox.SelectedItem as Bo3Language)?.Name ?? _selectedLangKey;

            string title = FindResource("Bo3Lang_PatchAll_Confirm_Title") as string ?? "Confirmation";
            string msgPattern = FindResource("Bo3Lang_PatchAll_Confirm_Msg") as string ?? "Voulez-vous patcher {1} cartes en {0} ?";
            string msg = string.Format(msgPattern, langName, _allMaps.Count);

            var confirm = MessageBox.Show(msg, title, MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (confirm != MessageBoxResult.Yes) return;

            // Start batch patch
            _isBusy = true;
            BtnPatchAll.IsEnabled = false;
            BtnRefresh.IsEnabled = false;
            BatchProgressCard.Visibility = Visibility.Visible;
            BatchProgressBar.Value = 0;

            var progress = new Progress<(int current, int total, string mapTitle)>(report =>
            {
                int pct = (int)((double)report.current / report.total * 100);
                BatchProgressBar.Value = pct;
                TxtBatchPercent.Text = $"{pct}%";
                TxtBatchStatus.Text = $"Patch ({report.current}/{report.total}) : {report.mapTitle}";
            });

            try
            {
                int count = await Bo3LanguageService.Instance.PatchAllMapsAsync(_allMaps, _selectedLangKey, progress);
                UpdateAllTargetStatuses();
                ApplyFilter();

                string successPattern = FindResource("Bo3Lang_PatchAll_Success") as string ?? "Toutes les cartes ont été patchées en {0} !";
                MessageBox.Show(string.Format(successPattern, langName), "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                BatchProgressCard.Visibility = Visibility.Collapsed;
                BtnPatchAll.IsEnabled = true;
                BtnRefresh.IsEnabled = true;
                _isBusy = false;
            }
        }

        private void BtnOpenFolder_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement elem && elem.Tag is Bo3MapItem map)
            {
                if (!string.IsNullOrEmpty(map.DirectoryPath) && Directory.Exists(map.DirectoryPath))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = map.DirectoryPath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Impossible d'ouvrir le dossier : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void BtnOpenWorkshop_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement elem && elem.Tag is Bo3MapItem map)
            {
                if (!string.IsNullOrEmpty(map.SteamWorkshopUrl))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = map.SteamWorkshopUrl,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Impossible d'ouvrir le lien Workshop : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void BtnGoToSettings_Click(object sender, RoutedEventArgs e)
        {
            Bo3LanguageWindow.NavigateToSettingsPage();
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
