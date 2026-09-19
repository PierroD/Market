using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace Lindra_Market_v3.Tools.Bo3LanguageSelector.Models
{
    public class Bo3MapItem : INotifyPropertyChanged
    {
        public string DirectoryPath { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FolderName { get; set; } = string.Empty;
        public string PublisherId { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
        public string? ThumbnailPath { get; set; }

        public bool HasThumbnail => !string.IsNullOrEmpty(ThumbnailPath) && File.Exists(ThumbnailPath);

        public string SteamWorkshopUrl => !string.IsNullOrEmpty(PublisherId)
            ? $"https://steamcommunity.com/sharedfiles/filedetails/?id={PublisherId}"
            : string.Empty;

        public ObservableCollection<string> InstalledLanguages { get; } = new();

        public string FormattedLanguages => InstalledLanguages.Count > 0
            ? string.Join(", ", InstalledLanguages.Select(l => l.ToUpperInvariant()))
            : "AUCUNE";

        private bool _isTargetLanguageInstalled;
        public bool IsTargetLanguageInstalled
        {
            get => _isTargetLanguageInstalled;
            set
            {
                if (_isTargetLanguageInstalled != value)
                {
                    _isTargetLanguageInstalled = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsTargetLanguageInstalled)));
                }
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsBusy)));
                }
            }
        }

        public bool IsLanguageInstalled(string langKey)
        {
            return InstalledLanguages.Any(l => string.Equals(l, langKey, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateTargetLanguageStatus(string targetLangKey)
        {
            IsTargetLanguageInstalled = IsLanguageInstalled(targetLangKey);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyLanguagesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(InstalledLanguages)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FormattedLanguages)));
        }
    }
}
