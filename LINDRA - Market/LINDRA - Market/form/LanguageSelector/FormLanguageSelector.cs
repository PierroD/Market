using Guna.UI2.WinForms;
using LINDRA___Market.form.LanguageSelector.Views;
using LINDRA___Market.Properties;
using LINDRA___Market.Utils;
using Newtonsoft.Json;
using PLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINDRA___Market.form.LanguageSelector
{
    public partial class FormLanguageSelector : Form
    {
        private Form parent;
        private string settingsPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\bo3\\settings.json";
        public FormLanguageSelector(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormLanguageSelector_Load(object sender, EventArgs e)
        {
            Log.setActivityId();
            LoadSettings();
            this.BackColor = AppColors.backgroundColor;
            panelTopLeft.BackColor = AppColors.backgroundTransparencyColor;
            panelTopRight.BackColor = AppColors.backgroundTransparencyColor;
            panelLeft.FillColor = AppColors.backgroundTransparencyColor;
            labelTitle.ForeColor = AppColors.textColor;
            labelPage.ForeColor = AppColors.textColor;
            buttonClose.FillColor = AppColors.backgroundTransparencyColor;
            buttonMinimize.FillColor = AppColors.backgroundTransparencyColor;
            buttonClose.IconColor = AppColors.textColor;
            buttonMinimize.IconColor = AppColors.textColor;
            buttonMaps.Image = AppColors.getImage("Maps");
            labelFolderPath.ForeColor = AppColors.secondaryColor;

            this.parent.Visible = false;
            //ttonMapDetails.PerformClick();
            buttonMaps.PerformClick();

        }


        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Log.setFunctionPassedThrough();
            Guna2Button button = ((Guna2Button)sender);
            Log.Infos("FormLanguageSelector switch to", button.Name);
            labelPage.Text = button.Name.Replace("button", String.Empty);
            pictureBoxPage.Image = (Bitmap)button.Image;
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));

        }

        private void FormLanguageSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            this.parent.Visible = true;
        }

        UC_MapDetails mapDetails;
        UC_Maps maps;
        UC_Settings settings;
        private UserControl GetUserControlInstance(string buttonName)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("Switch to UC_Instance", buttonName);
            switch (buttonName)
            {
                case "Maps":
                    if (maps == null)
                        maps = new UC_Maps();
                    maps.MapDetailsSelected += MapDetailsSelectedEvent;
                    return maps;
                case "MapDetails":
                    if (mapDetails == null)
                        mapDetails = new UC_MapDetails();
                    return mapDetails;
                case "Settings":
                    if (settings == null)
                        settings = new UC_Settings();
                    return settings;
                default:
                    return null;
            }
        }

        private void LoadSettings()
        {
            if (!File.Exists(this.settingsPath))
            {
                Log.Infos("FormLanguageSelector : No settings file found");
                return;
            }
            Settings settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(this.settingsPath));

            if (settings == null)
            {
                Log.Infos("Unable to load settings");
                return;
            }
            LanguageSelectorSettings.folderPath = settings.FolderPath;
            LanguageSelectorSettings.favoriteLanguageKey = settings.FavoriteLanguageKey;
            labelFolderPath.Text = settings.FolderPath.Length > 0 ? settings.FolderPath : "No workshop folder selected";
        }

        private void SaveSettings()
        {
            if (File.Exists(this.settingsPath))
                File.Delete(this.settingsPath);

            Settings settings = new Settings();
            JsonSerializer serializer = new JsonSerializer();

            settings.FolderPath = LanguageSelectorSettings.folderPath;
            settings.FavoriteLanguageKey = LanguageSelectorSettings.favoriteLanguageKey;
            using (StreamWriter file = File.CreateText(this.settingsPath))
            {
                using (JsonTextWriter jsonWriter = new JsonTextWriter(file))
                {
                    serializer.Serialize(jsonWriter, settings);
                }
            }
        }

        private void MapDetailsSelectedEvent(object sender, MapDetails mapDetails)
        {
            buttonMapDetails.PerformClick();
            buttonMapDetails.Visible = true;
            this.mapDetails.UpdateMapDetails(mapDetails);
        }
    }
}
