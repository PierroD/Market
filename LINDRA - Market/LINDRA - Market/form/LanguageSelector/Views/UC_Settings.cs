using LINDRA___Market.Utils;
using PLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TheArtOfDevHtmlRenderer.Core;

namespace LINDRA___Market.form.LanguageSelector.Views
{
    public partial class UC_Settings : UserControl
    {
        private Languages languages = new Languages();
        private string languagesPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\bo3\\languages.json";

        public UC_Settings()
        {
            InitializeComponent();
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            Log.setActivityId();
            this.BackColor = AppColors.backgroundColor;
            textBoxFolderPath.FillColor = AppColors.backgroundColor;
            textBoxFolderPath.ForeColor = AppColors.textColor;
            textBoxFolderPath.BorderColor = AppColors.textColor;
            buttonSelectFolderPath.FillColor = AppColors.secondaryColor;
            buttonSelectFolderPath.ForeColor = AppColors.textColor;
            labelDescription.ForeColor = AppColors.textColor;
            labelFavoriteLanguage.ForeColor = AppColors.textColor;
            comboboxFavoriteLanguage.ForeColor = AppColors.textColor;
            comboboxFavoriteLanguage.FillColor = AppColors.backgroundColor;
            buttonSetFavoriteLanguage.FillColor = AppColors.secondaryColor;
            buttonSetFavoriteLanguage.ForeColor = AppColors.textColor;
            this.languages.languages = LoadLanguageJSON();

            if (LanguageSelectorSettings.folderPath.Trim().Length > 0)
                textBoxFolderPath.Text = LanguageSelectorSettings.folderPath;
            if (LanguageSelectorSettings.favoriteLanguageKey.Trim().Length > 0)
            {
                LoadLanguageCombobox();
                Language language = this.languages.languages.First(l => l.key == LanguageSelectorSettings.favoriteLanguageKey);
                comboboxFavoriteLanguage.SelectedIndex = comboboxFavoriteLanguage.Items.IndexOf(language.name); ;
            }

        }

        private void buttonSelectFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select workshop folder path";
            using (dialog)
            {
                DialogResult result = dialog.ShowDialog();
                string selectedPath = dialog.SelectedPath;
                if (result != DialogResult.OK && string.IsNullOrEmpty(selectedPath) && !selectedPath.EndsWith("311210"))
                {
                    return;
                }
                textBoxFolderPath.Text = selectedPath;
                LanguageSelectorSettings.folderPath = selectedPath;
                Log.Infos("Folder path been set to :", selectedPath);
            }
        }

        private void buttonSetFavoriteLanguage_Click(object sender, EventArgs e)
        {
            Log.Infos("Set Favorite Language");
            if (comboboxFavoriteLanguage.Text.Length < 2)
            {
                Log.Infos("Failed to set favorite language");
                return;
            }
            Language selectedLanguage = this.languages.languages.First(language => language.name == comboboxFavoriteLanguage.Text);
            LanguageSelectorSettings.favoriteLanguageKey = selectedLanguage.key;
            Log.Infos("Favorite language set to :", selectedLanguage.key, selectedLanguage.name);
        }

        private void comboboxFavoriteLanguage_Click(object sender, EventArgs e)
        {
            LoadLanguageCombobox();
        }

        private void LoadLanguageCombobox()
        {
            comboboxFavoriteLanguage.Items.Clear();
            if (this.languages.languages.Count() <= 0)
            {
                Log.Infos("Languages list is empty");
                return;
            }
            foreach (Language language in this.languages.languages)
            {
                comboboxFavoriteLanguage.Items.Add(language.name);
            }

        }

        private List<Language> LoadLanguageJSON()
        {
            if (!File.Exists(this.languagesPath))
            {
                Log.Infos("Languages Path not found", this.languagesPath);
                return new List<Language>();
            }
            Log.Infos("Languages Path sucessfully loaded", this.languagesPath);
            var languagesObject = JsonConvert.DeserializeObject<List<Language>>(File.ReadAllText(this.languagesPath));
            return languagesObject;

        }

    }
}
