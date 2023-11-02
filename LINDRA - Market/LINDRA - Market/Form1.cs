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
                #region leftPanelButtons
                buttonSettings.Image = AppColors.getImage("Settings");
                buttonSettings.CheckedState.FillColor = AppColors.secondaryColor;
                buttonHome.Image = AppColors.getImage("Home");
                buttonHome.CheckedState.FillColor = AppColors.secondaryColor;
                buttonUpdate.Image = AppColors.getImage("Updates");
                buttonAbout.Image = AppColors.getImage("Info");
                labelPage.ForeColor = AppColors.textColor;
                #endregion
                this.BackColor = AppColors.backgroundColor;
                panelMain.BackColor = AppColors.backgroundColor;
                panelLeft.BackColor = AppColors.backgroundTransparencyColor;
                panelTop.BackColor = AppColors.backgroundTransparencyColor;
                buttonMinimize.FillColor = AppColors.backgroundTransparencyColor;
                buttonClose.FillColor = AppColors.backgroundTransparencyColor;
                buttonMinimize.IconColor = AppColors.textColor;
                buttonClose.IconColor = AppColors.textColor;
                labelTitle.ForeColor = AppColors.textColor;
                labelSignature.ForeColor = AppColors.textColor;
                /*  scrollBarPanel.FillColor = FormColors.backgroundSecondaryColor;
                  scrollBarPanel.ThumbColor = FormColors.backgroundPrimaryColor;*/
                Thread.Sleep(10);
            }

        }

        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Guna2Button button = ((Guna2Button)sender);
            labelPage.Text = button.Name.Replace("button", String.Empty);
            pictureBoxPage.Image = (Bitmap)button.Image;
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
        }

        dynamic home, settings, about;
        private UserControl GetUserControlInstance(string buttonName)
        {
            switch (buttonName)
            {
                case "Home":
                    if (home == null)
                        home = CreateUserControl(buttonName);
                    panelMain.AutoScrollMinSize = new Size(1, 1); // change to 609 to add scrollbar to the page
                    return home;
                case "Settings":
                    if (settings == null)
                        settings = CreateUserControl(buttonName);
                    panelMain.AutoScrollMinSize = new Size(1, 1);
                    return settings;
                case "About":
                    if (about == null)
                        about = CreateUserControl(buttonName);
                    return about;

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
                
                AppSettings.version = ini.IniReadValue("Version", "AppVersion");
                AppSettings.isDarkMode = bool.Parse(ini.IniReadValue("Settings", "DarkMode"));
                using (var wc = new System.Net.WebClient())
                    AppSettings.latestVersion = wc.DownloadString(ini.IniReadValue("Version", "LastestVersionUrl"));
                    buttonUpdate.Visible = (AppSettings.version != AppSettings.latestVersion);
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

            ini.IniWriteValue("Version", "AppVersion", AppSettings.version);
            ini.IniWriteValue("Settings", "DarkMode", AppSettings.isDarkMode.ToString());
        }

    }
}
