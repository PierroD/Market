using LINDRA___Market.Utils;
using Newtonsoft.Json;
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

namespace LINDRA___Market.form.LanguageSelector.Views
{
    public partial class UC_MapDetails : UserControl
    {
        private Languages languages = new Languages();
        private string languagesPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\bo3\\languages.json";

        public MapDetails mapDetails { get; set; }

        public UC_MapDetails()
        {
            InitializeComponent();
        }
        private void UC_MapDetails_Load(object sender, EventArgs e)
        {

            this.BackColor = AppColors.backgroundColor;
            labelName.ForeColor = AppColors.textColor;
            textBoxDescription.FillColor = AppColors.backgroundColor;
            textBoxDescription.ForeColor = AppColors.textColor;
            textBoxDescription.BorderColor = AppColors.textColor;
            labelAvailableLanguages.ForeColor = AppColors.textColor;
            comboboxLanguage.ForeColor = AppColors.textColor;
            comboboxLanguage.FillColor = AppColors.backgroundColor;
            buttonAddLanguage.FillColor = AppColors.secondaryColor;
            buttonAddLanguage.ForeColor = AppColors.textColor;
            labelOtherData.ForeColor = AppColors.textColor;
            labelPublisherId.ForeColor = AppColors.textColor;
            labelTags.ForeColor = AppColors.textColor;
            labelType.ForeColor = AppColors.textColor;
            labelFolderName.ForeColor = AppColors.textColor;


            this.languages.languages = LoadLanguageJSON();
        }

        public void UpdateMapDetails(MapDetails mapDetails)
        {
            this.mapDetails = mapDetails;
            LoadImage();
            LoadFields();
            LoadAvailableLanguages();
        }

        private void LoadImage()
        {
            List<string> imagesPath = this.mapDetails.directoryFiles.ToList().FindAll(df => df.Contains("previewimage.png") || df.Contains("thumnail.png"));
            if (imagesPath.Count > 0)
            {
                pictureBoxPreview.Image = Image.FromFile(imagesPath[0]);
            }
        }

        private void LoadFields()
        {
            labelName.Text = this.mapDetails.workshopJson.Title;
            textBoxDescription.Text = this.mapDetails.workshopJson.Description;

            labelPublisherId.Text = $"PublisherId : {this.mapDetails.workshopJson.PublisherID}";
            labelTags.Text = $"Tags : {this.mapDetails.workshopJson.Tags}";
            labelType.Text = $"Type : {this.mapDetails.workshopJson.Type}";
            labelFolderName.Text = $"FolderName : {this.mapDetails.workshopJson.FolderName}";

            LoadLanguageCombobox();
            Language language = this.languages.languages.First(l => l.key == LanguageSelectorSettings.favoriteLanguageKey);
            comboboxLanguage.SelectedIndex = comboboxLanguage.Items.IndexOf(language.name); ;

        }

        private void LoadAvailableLanguages()
        {
            List<string> allLanguagesFiles = this.mapDetails.directoryFiles.ToList().FindAll(df => df.EndsWith($"_{this.mapDetails.workshopJson.FolderName}.ff"));
            List<UC_Language> uc_Languages = new List<UC_Language>();
            foreach (string filePath in allLanguagesFiles)
            {
                if (!File.Exists(filePath))
                {
                    continue;
                }
                int fileNameIndex = filePath.LastIndexOf("\\");
                string fileName = filePath.Substring(fileNameIndex + 1);
                string languageKey = fileName.Substring(0, 2);
                try
                {
                    Language language = this.languages.languages.First(l => l.key == languageKey);
                    uc_Languages.Add(new UC_Language
                    {
                        language = language,
                    });
                }
                catch
                {
                    continue;
                }
            }
            DisplayLanguages(uc_Languages);

        }

        private void LoadLanguageCombobox()
        {
            comboboxLanguage.Items.Clear();
            if (this.languages.languages.Count() <= 0)
            {
                Log.Infos("Languages list is empty");
                return;
            }
            foreach (Language language in this.languages.languages)
            {
                comboboxLanguage.Items.Add(language.name);
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

        private void DisplayLanguages(List<UC_Language> languages)
        {
            flowLayoutPanelResults.Controls.Clear();
            flowLayoutPanelResults.SuspendLayout();
            flowLayoutPanelResults.Controls.AddRange(languages.ToArray());
            flowLayoutPanelResults.ResumeLayout();
            this.ResumeLayout();

        }

        private void buttonAddLanguage_Click(object sender, EventArgs e)
        {
            try
            {
                string englishFileName = $"en_{this.mapDetails.workshopJson.FolderName}";
                Language language = this.languages.languages.First(l => l.name == comboboxLanguage.Text);
                List<string> files = this.mapDetails.directoryFiles.ToList().FindAll(df => df.Contains($"{englishFileName}"));
                foreach (string file in files)
                {
                    string newFilePath = file.Replace(englishFileName, $"{language.key}_{this.mapDetails.workshopJson.FolderName}");
                    File.Copy(file, newFilePath);
                }
                Notify($"Language files have been created successfully in {language.name} for {this.mapDetails.workshopJson.Title}", "Market", "Success language files", ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                Log.Error("Error creating language files");
                Notify($"Language files failed to be created in {comboboxLanguage.Text} for {this.mapDetails.workshopJson.Title}", "Market", "Error - language files", ToolTipIcon.Error);
            }
        }

        #region Notify
        /// <summary>
        /// Notify Icon, to inform the user
        /// </summary>
        /// <param name="tipText"></param>
        /// <param name="mainText"></param>
        /// <param name="tipTitle"></param>
        void Notify(string tipText, string mainText, string tipTitle, ToolTipIcon icon)
        {
            notifyIconResult.BalloonTipText = tipText;
            notifyIconResult.Text = mainText;
            notifyIconResult.BalloonTipTitle = tipTitle;
            notifyIconResult.Visible = true;
            notifyIconResult.ShowBalloonTip(1000, tipTitle, tipText, icon);
            notifyIconResult.Visible = false;
        }
        #endregion

    }
}
