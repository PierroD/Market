using System;
using System.Windows;
using System.Windows.Controls;
using MarketOffsets.Services;
using Lindra_Market_v3.Tools.FpsUnlocker.Services;

namespace Lindra_Market_v3.Tools.FpsUnlocker.Views
{
    public partial class VisualsPage : Page
    {
        private bool _isUpdatingUi = false;

        public VisualsPage()
        {
            InitializeComponent();

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;

            // Wire up event handlers for UI changes
            FieldOfViewSlider.ValueChanged += (_, _) => UpdateConfigFromUi();
            MaxFpsSlider.ValueChanged += (_, _) => UpdateConfigFromUi();
            FovScaleSlider.ValueChanged += (_, _) => UpdateConfigFromUi();
            FovMinimumSlider.ValueChanged += (_, _) => UpdateConfigFromUi();

            LightMapComboBox.SelectionChanged += (_, _) => UpdateConfigFromUi();
            SpecularMapComboBox.SelectionChanged += (_, _) => UpdateConfigFromUi();

            MovieToggle.Click += (_, _) => UpdateConfigFromUi();
            NoFogToggle.Click += (_, _) => UpdateConfigFromUi();
            NoGlowToggle.Click += (_, _) => UpdateConfigFromUi();
            NoBulletToggle.Click += (_, _) => UpdateConfigFromUi();
            NoCamosToggle.Click += (_, _) => UpdateConfigFromUi();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            VisualsConfigManager.ConfigChanged += OnConfigChanged;
            GameMemoryService.Instance.StateChanged += OnGameStateChanged;
            ApplyConfigToUi();
            AdaptControlsToGame();
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            VisualsConfigManager.ConfigChanged -= OnConfigChanged;
            GameMemoryService.Instance.StateChanged -= OnGameStateChanged;
        }

        private void OnGameStateChanged(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(AdaptControlsToGame);
        }

        private void AdaptControlsToGame()
        {
            var profile = GameMemoryService.Instance.CurrentProfile;
            if (profile != null)
            {
                LightMapComboBox.IsEnabled = profile.SupportsLightMap;
                SpecularMapComboBox.IsEnabled = profile.SupportsSpecularMap;
                MovieToggle.IsEnabled = profile.SupportsFilmUseTweaks;
                NoFogToggle.IsEnabled = profile.R_Fog.HasValue;
                NoGlowToggle.IsEnabled = profile.R_Glow.HasValue;
                NoBulletToggle.IsEnabled = profile.Cg_Brass.HasValue;
                NoCamosToggle.IsEnabled = profile.R_Detail.HasValue;
            }
            else
            {
                LightMapComboBox.IsEnabled = true;
                SpecularMapComboBox.IsEnabled = true;
                MovieToggle.IsEnabled = true;
                NoFogToggle.IsEnabled = true;
                NoGlowToggle.IsEnabled = true;
                NoBulletToggle.IsEnabled = true;
                NoCamosToggle.IsEnabled = true;
            }
        }

        private void OnConfigChanged(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(ApplyConfigToUi);
        }

        private void ApplyConfigToUi()
        {
            _isUpdatingUi = true;
            try
            {
                var cfg = VisualsConfigManager.CurrentConfig;
                FieldOfViewSlider.Value = cfg.FieldOfView;
                MaxFpsSlider.Value = cfg.MaxFps;
                FovScaleSlider.Value = cfg.FovScale;
                FovMinimumSlider.Value = cfg.FovMinimum;

                if (cfg.LightMapIndex >= 0 && cfg.LightMapIndex < LightMapComboBox.Items.Count)
                    LightMapComboBox.SelectedIndex = cfg.LightMapIndex;

                if (cfg.SpecularMapIndex >= 0 && cfg.SpecularMapIndex < SpecularMapComboBox.Items.Count)
                    SpecularMapComboBox.SelectedIndex = cfg.SpecularMapIndex;

                MovieToggle.IsChecked = cfg.IsMovieEnabled;
                NoFogToggle.IsChecked = cfg.IsNoFogEnabled;
                NoGlowToggle.IsChecked = cfg.IsNoGlowEnabled;
                NoBulletToggle.IsChecked = cfg.IsNoBulletEnabled;
                NoCamosToggle.IsChecked = cfg.IsNoCamosEnabled;
            }
            finally
            {
                _isUpdatingUi = false;
            }
        }

        private void UpdateConfigFromUi()
        {
            if (_isUpdatingUi) return;

            var cfg = VisualsConfigManager.CurrentConfig;
            cfg.FieldOfView = FieldOfViewSlider.Value;
            cfg.MaxFps = MaxFpsSlider.Value;
            cfg.FovScale = FovScaleSlider.Value;
            cfg.FovMinimum = FovMinimumSlider.Value;

            cfg.LightMapIndex = LightMapComboBox.SelectedIndex;
            cfg.SpecularMapIndex = SpecularMapComboBox.SelectedIndex;

            cfg.IsMovieEnabled = MovieToggle.IsChecked ?? false;
            cfg.IsNoFogEnabled = NoFogToggle.IsChecked ?? false;
            cfg.IsNoGlowEnabled = NoGlowToggle.IsChecked ?? false;
            cfg.IsNoBulletEnabled = NoBulletToggle.IsChecked ?? false;
            cfg.IsNoCamosEnabled = NoCamosToggle.IsChecked ?? false;

            VisualsConfigManager.AutoSave();
            GameMemoryService.Instance.ApplySettings(cfg);
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
