using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using Wpf.Ui.Controls;
using Wpf.Ui.Input;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.ViewModels
{
    public class AppTile : INotifyPropertyChanged
    {
        public string TitleKey { get; init; } = "";
        public string SubtitleKey { get; init; } = "";
        public string CategoryKey { get; init; } = "";
        public required SymbolRegular IconSymbol { get; init; }
        public required Brush AccentBrush { get; init; }
        public required bool IsAvailable { get; init; }
        public ICommand? LaunchCommand { get; init; }

        public string Title => LanguageManager.GetString(TitleKey, TitleKey);
        public string Subtitle => LanguageManager.GetString(SubtitleKey, SubtitleKey);
        public string Category => LanguageManager.GetString(CategoryKey, CategoryKey);
        public string StatusBadge => IsAvailable
            ? LanguageManager.GetString("Home_Status_Available", "Disponible")
            : LanguageManager.GetString("Home_Status_Soon", "Bientôt");

        public string ButtonText => IsAvailable
            ? LanguageManager.GetString("Home_Btn_Launch", "Lancer l'outil")
            : LanguageManager.GetString("Home_Btn_InDev", "En développement");

        public event PropertyChangedEventHandler? PropertyChanged;

        public void RefreshTranslations()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Subtitle)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Category)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusBadge)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonText)));
        }
    }

    public class HomePageViewModel : INotifyPropertyChanged
    {
        private readonly List<AppTile> _allApps;

        public ObservableCollection<AppTile> FilteredApps { get; } = new();

        private string _searchText = string.Empty;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchText)));
                ApplyFilter();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public HomePageViewModel()
        {
            _allApps = new List<AppTile>
            {
                new AppTile
                {
                    TitleKey = "Tool_FpsUnlocker_Title",
                    SubtitleKey = "Tool_FpsUnlocker_Subtitle",
                    CategoryKey = "Tool_FpsUnlocker_Category",
                    IconSymbol = SymbolRegular.Flash24,
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#38B6FF")),
                    IsAvailable = true,
                    LaunchCommand = new RelayCommand(_ => LaunchFpsUnlocker())
                },
                new AppTile
                {
                    TitleKey = "Tool_Console_Title",
                    SubtitleKey = "Tool_Console_Subtitle",
                    CategoryKey = "Tool_Console_Category",
                    IconSymbol = SymbolRegular.WindowDevTools24,
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D98CC0")),
                    IsAvailable = true,
                    LaunchCommand = new RelayCommand(_ => LaunchConsole())
                },
                new AppTile
                {
                    TitleKey = "Tool_Bo3Lang_Title",
                    SubtitleKey = "Tool_Bo3Lang_Subtitle",
                    CategoryKey = "Tool_Bo3Lang_Category",
                    IconSymbol = SymbolRegular.Globe24,
                    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7EC8CC")),
                    IsAvailable = true,
                    LaunchCommand = new RelayCommand(_ => LaunchBo3LanguageSelector())
                },
                //new AppTile
                //{
                //    TitleKey = "Tool_Texture_Title",
                //    SubtitleKey = "Tool_Texture_Subtitle",
                //    CategoryKey = "Tool_Texture_Category",
                //    IconSymbol = SymbolRegular.PaintBrush24,
                //    AccentBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F39C12")),
                //    IsAvailable = false
                //}
            };

            LanguageManager.LanguageChanged += OnLanguageChanged;
            ApplyFilter();
        }

        private void OnLanguageChanged(object? sender, EventArgs e)
        {
            foreach (var app in _allApps)
            {
                app.RefreshTranslations();
            }
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            FilteredApps.Clear();
            var query = _searchText.Trim().ToLower();

            var matches = string.IsNullOrWhiteSpace(query)
                ? _allApps
                : _allApps.Where(a =>
                    a.Title.ToLower().Contains(query) ||
                    a.Subtitle.ToLower().Contains(query) ||
                    a.Category.ToLower().Contains(query));

            foreach (var app in matches)
            {
                FilteredApps.Add(app);
            }
        }

        private static void LaunchFpsUnlocker()
        {
            var window = new Tools.FpsUnlocker.FpsUnlocker();
            if (System.Windows.Application.Current?.MainWindow != null)
            {
                window.Owner = System.Windows.Application.Current.MainWindow;
            }
            window.Show();
        }

        private static void LaunchConsole()
        {
            var window = new Tools.ExternalConsole.ConsoleWindow();
            if (System.Windows.Application.Current?.MainWindow != null)
            {
                window.Owner = System.Windows.Application.Current.MainWindow;
            }
            window.Show();
        }

        private static void LaunchBo3LanguageSelector()
        {
            var window = new Tools.Bo3LanguageSelector.Bo3LanguageWindow();
            if (System.Windows.Application.Current?.MainWindow != null)
            {
                window.Owner = System.Windows.Application.Current.MainWindow;
            }
            window.Show();
        }
    }
}
