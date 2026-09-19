using System;
using System.Windows;
using System.Windows.Media;
using Wpf.Ui.Controls;
using MarketOffsets.Services;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.Tools.FpsUnlocker
{
    /// <summary>
    /// Logique d'interaction pour FpsUnlocker.xaml
    /// </summary>
    public partial class FpsUnlocker : FluentWindow
    {
        private static readonly SolidColorBrush ConnectedBrush = new(Color.FromRgb(16, 185, 129));

        public FpsUnlocker()
        {
            InitializeComponent();

            if (Application.Current?.MainWindow != null && Application.Current.MainWindow != this)
            {
                Owner = Application.Current.MainWindow;
            }

            Loaded += OnLoaded;
            Closed += OnClosed;

            AppSettingsManager.ThemeChanged += OnSettingsThemeChanged;
            LanguageManager.LanguageChanged += OnLanguageChanged;
            GameMemoryService.Instance.StateChanged += OnGameStateChanged;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            AppSettingsManager.ApplyThemeToWindow(this);
            RootNavigation.Navigate(typeof(Views.VisualsPage));

            GameMemoryService.Instance.Start();
            UpdateStatusUi();
        }

        private void OnClosed(object? sender, EventArgs e)
        {
            AppSettingsManager.ThemeChanged -= OnSettingsThemeChanged;
            LanguageManager.LanguageChanged -= OnLanguageChanged;
            GameMemoryService.Instance.StateChanged -= OnGameStateChanged;
            GameMemoryService.Instance.Stop();
        }

        private void OnSettingsThemeChanged(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                AppSettingsManager.ApplyThemeToWindow(this);
                UpdateStatusUi();
            });
        }

        private void OnLanguageChanged(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(UpdateStatusUi);
        }

        private void OnGameStateChanged(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(UpdateStatusUi);
        }

        private void UpdateStatusUi()
        {
            if (GameMemoryService.Instance.IsGameAttached)
            {
                StatusIndicatorDot.Fill = ConnectedBrush;
                string prefix = LanguageManager.GetString("FpsUnlocker_Status_Connected", "Connecté :");
                string gameName = GameMemoryService.Instance.CurrentGameName;
                StatusGameText.Text = $"{prefix} {gameName}";
                StatusGameText.Foreground = (Brush)FindResource("TextFillColorPrimaryBrush");
                StatusPidText.Text = $"PID: {GameMemoryService.Instance.CurrentProcess?.Id}";
            }
            else
            {
                StatusIndicatorDot.Fill = (Brush)FindResource("TextFillColorTertiaryBrush");
                StatusGameText.Text = LanguageManager.GetString("FpsUnlocker_Status_Waiting", "En attente d'un jeu...");
                StatusGameText.Foreground = (Brush)FindResource("TextFillColorSecondaryBrush");
                StatusPidText.Text = string.Empty;
            }
        }
    }
}
