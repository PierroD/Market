using System;
using System.Windows;
using Wpf.Ui.Controls;
using Lindra_Market_v3.Tools.Bo3LanguageSelector.Services;
using Lindra_Market_v3.Tools.Bo3LanguageSelector.Views;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.Tools.Bo3LanguageSelector
{
    public partial class Bo3LanguageWindow : FluentWindow
    {
        private static Bo3LanguageWindow? _currentInstance;

        public static void NavigateToSettingsPage()
        {
            _currentInstance?.RootNavigation.Navigate(typeof(Bo3SettingsPage));
        }

        public Bo3LanguageWindow()
        {
            InitializeComponent();
            _currentInstance = this;

            if (Application.Current?.MainWindow != null && Application.Current.MainWindow != this)
            {
                Owner = Application.Current.MainWindow;
            }

            Loaded += OnLoaded;
            Closed += OnClosed;

            AppSettingsManager.ThemeChanged += OnSettingsThemeChanged;
            LanguageManager.LanguageChanged += OnLanguageChanged;
            Bo3MapsPage.OnMapCountUpdated += OnMapCountUpdated;
            Bo3SettingsPage.OnWorkshopPathChanged += OnWorkshopPathChanged;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            AppSettingsManager.ApplyThemeToWindow(this);
            RootNavigation.Navigate(typeof(Bo3MapsPage));

            UpdateFooterPath();
        }

        private void OnClosed(object? sender, EventArgs e)
        {
            AppSettingsManager.ThemeChanged -= OnSettingsThemeChanged;
            LanguageManager.LanguageChanged -= OnLanguageChanged;
            Bo3MapsPage.OnMapCountUpdated -= OnMapCountUpdated;
            Bo3SettingsPage.OnWorkshopPathChanged -= OnWorkshopPathChanged;

            if (_currentInstance == this)
            {
                _currentInstance = null;
            }
        }

        private void OnSettingsThemeChanged(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                AppSettingsManager.ApplyThemeToWindow(this);
            });
        }

        private void OnLanguageChanged(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                UpdateFooterPath();
            });
        }

        private void OnWorkshopPathChanged()
        {
            Dispatcher.Invoke(UpdateFooterPath);
        }

        private void UpdateFooterPath()
        {
            string path = Bo3LanguageService.Instance.Settings.WorkshopPath;
            if (string.IsNullOrWhiteSpace(path))
            {
                TxtFooterPath.Text = "Workshop: Non configuré";
            }
            else
            {
                TxtFooterPath.Text = $"Workshop: {path}";
            }
        }

        private void OnMapCountUpdated(int count)
        {
            Dispatcher.Invoke(() =>
            {
                string pattern = FindResource("Bo3Lang_Maps_Count") as string ?? "Cartes détectées : {0}";
                TxtFooterCount.Text = string.Format(pattern, count);
            });
        }
    }
}
