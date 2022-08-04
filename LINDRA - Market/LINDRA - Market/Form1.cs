using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LINDRA___Market.Utils;
using Guna.UI2.WinForms;
using System.Reflection;
using System.Threading;
using System.IO;
using LINDRA___Market.Utils;

namespace LINDRA___Market
{
    public partial class form_market : Form
    {
        Thread colorThread;

        public form_market()
        {
            InitializeComponent();
        }


        private void form_market_Load(object sender, EventArgs e)
        {
            loadConfig();
            colorThread = new Thread(new ThreadStart(loadColorTheme));
            colorThread.Start();
            buttonHome.PerformClick();
        }

        private void loadColorTheme()
        {
            while (true)
            {
                this.BackColor = FormColors.backgroundPrimaryColor;
                panelMain.BackColor = FormColors.backgroundPrimaryColor;
                panelLeft.BackColor = FormColors.backgroundSecondaryColor;
                panelTop.BackColor = FormColors.backgroundSecondaryColor;
                buttonMinimize.FillColor = FormColors.backgroundSecondaryColor;
                buttonClose.FillColor = FormColors.backgroundSecondaryColor;
                buttonMinimize.IconColor = FormColors.backgroundPrimaryColor;
                buttonClose.IconColor = FormColors.backgroundPrimaryColor;
                labelTitle.ForeColor = FormColors.backgroundSecondaryColor;
                labelSignature.ForeColor = FormColors.backgroundSecondaryColor;
                Thread.Sleep(100);
            }

        }

        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Guna2Button button = ((Guna2Button)sender);
            buttonSettings.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(buttonSettings.Name == button.Name ? "settings_on" : "settings_off");
            buttonHome.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(buttonHome.Name == button.Name ? "home_on" : "home_off");
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
        }

        dynamic home, settings;
        private UserControl GetUserControlInstance(string buttonName)
        {
            switch (buttonName)
            {
                case "Home":
                    if (home == null)
                        home = CreateUserControl(buttonName);
                    return home;
                case "Settings":
                    if (settings == null)
                        settings = CreateUserControl(buttonName);
                    return settings;
                default:
                    return null;
            }
        }

        private void form_market_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (colorThread.IsAlive || colorThread.IsBackground)
            {
                colorThread.Abort();
            }
            home.stopThreads();
            saveSettings();
        }

        private UserControl CreateUserControl(string usercontrolName)
        {
            return (UserControl)Assembly.GetExecutingAssembly().CreateInstance($"LINDRA___Market.Views.UC_{usercontrolName}"); ;
        }

        private static string config_folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
        private void loadConfig()
        {
            string configFileLoad = config_folder + "app.ini";
            if (File.Exists(configFileLoad))
            {
                INIFile ini = new INIFile(configFileLoad);
                
                app_settings.version = ini.IniReadValue("Version", "AppVersion");
                app_settings.darkMode = bool.Parse(ini.IniReadValue("Settings", "DarkMode"));
                using (var wc = new System.Net.WebClient())
                    app_settings.latestVersion = wc.DownloadString(ini.IniReadValue("Version", "LastestVersionUrl"));
                    buttonUpdate.Visible = (app_settings.version != app_settings.latestVersion);

                if (app_settings.darkMode)
                {
                    FormColors.backgroundPrimaryColor = Color.FromArgb(28, 40, 38);
                    FormColors.backgroundSecondaryColor = Color.FromArgb(217, 247, 250);
                }
                else
                {
                    FormColors.backgroundSecondaryColor = Color.FromArgb(28, 40, 38);
                    FormColors.backgroundPrimaryColor = Color.FromArgb(217, 247, 250);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonSettings.PerformClick();
        }

        private void saveSettings()
        {
            string configFileLoad = config_folder + "app.ini";
            INIFile ini = new INIFile(configFileLoad);

            ini.IniWriteValue("Version", "AppVersion", app_settings.version);
            ini.IniWriteValue("Settings", "DarkMode", app_settings.darkMode.ToString());
        }

    }
}
