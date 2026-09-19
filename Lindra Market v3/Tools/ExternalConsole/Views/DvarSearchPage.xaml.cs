using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MarketOffsets.Services;
using Lindra_Market_v3.Tools.ExternalConsole.Services;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.Tools.ExternalConsole.Views
{
    public partial class DvarSearchPage : Page
    {
        private bool _isInitializing = true;

        public DvarSearchPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            _isInitializing = true;
            await DvarCatalogService.Instance.EnsureLoadedAsync();

            var games = DvarCatalogService.Instance.GetAvailableGames();
            GameComboBox.ItemsSource = games;

            string? detectedGame = null;
            if (GameMemoryService.Instance.IsGameAttached)
            {
                detectedGame = DvarCatalogService.Instance.ResolveGameKey(
                    GameMemoryService.Instance.CurrentGameName ?? GameMemoryService.Instance.CurrentProcess?.ProcessName);
            }

            if (!string.IsNullOrEmpty(detectedGame) && games.Contains(detectedGame))
            {
                GameComboBox.SelectedItem = detectedGame;
            }
            else if (games.Count > 0)
            {
                GameComboBox.SelectedIndex = 0;
            }

            _isInitializing = false;
            ExecuteSearch();
        }

        private void GameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!_isInitializing)
            {
                ExecuteSearch();
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_isInitializing)
            {
                ExecuteSearch();
            }
        }

        private void ExecuteSearch()
        {
            string? selectedGame = GameComboBox.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedGame))
            {
                DvarsListView.ItemsSource = null;
                UpdateCount(0, 0);
                EmptyStateText.Visibility = Visibility.Visible;
                return;
            }

            string query = SearchTextBox.Text ?? string.Empty;
            var results = DvarCatalogService.Instance.Search(selectedGame, query);
            int total = DvarCatalogService.Instance.GetTotalCount(selectedGame);

            DvarsListView.ItemsSource = results;
            UpdateCount(results.Count, total);
            EmptyStateText.Visibility = results.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        private void UpdateCount(int count, int total)
        {
            string format = LanguageManager.GetString("DvarSearch_Results_Count", "Résultats : {0} / {1}");
            ResultsCountText.Text = string.Format(format, count, total);
        }

        private async void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Wpf.Ui.Controls.Button btn && btn.Tag is string dvarName)
            {
                Clipboard.SetText(dvarName);
                btn.SetResourceReference(ContentControl.ContentProperty, "DvarSearch_Btn_Copied");
                await Task.Delay(1200);
                btn.SetResourceReference(ContentControl.ContentProperty, "DvarSearch_Btn_Copy");
            }
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement elem && elem.Tag is string dvarName)
            {
                ConsoleWindow.InsertCommand(dvarName);
            }
        }

        private void BtnExecute_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement elem && elem.Tag is string dvarName)
            {
                if (GameMemoryService.Instance.IsGameAttached)
                {
                    GameMemoryService.Instance.SendConsoleCommand(dvarName);
                }

                // Also insert and view in console so user sees execution history
                ConsoleWindow.InsertCommand(dvarName);
            }
        }
    }
}
