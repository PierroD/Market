using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using LINDRA___Market.Utils;
using Markdig;

namespace LINDRA___Market.Views
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private string version = "1.0";

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            checkUpdates();
            checkLastestVersion();
            loadColorTheme();
        }

        protected override void OnLoad(EventArgs e)
        {
            checkUpdates();
            checkLastestVersion();
            loadColorTheme();
            base.OnLoad(e);
        }

        private void loadColorTheme()
        {
            this.BackColor = AppColors.backgroundColor;
            labelDarkMode.ForeColor = AppColors.textColor;
            labelVersion.ForeColor = AppColors.textColor;
            labelLatestVersion.ForeColor = AppColors.textColor;
            buttonUpdate.FillColor = AppColors.primaryColor;
            buttonUpdate.ForeColor = AppColors.textColor;
            labelVersions.ForeColor = AppColors.textColor;
            separator1.FillColor = AppColors.textColor;
            buttonShortcut.ForeColor = AppColors.textColor;
            buttonShortcut.FillColor = AppColors.primaryColor;
            switchDarkMode.CheckedState.FillColor = AppColors.primaryColor;
        }

        private void switchDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.darkMode = switchDarkMode.Checked;
            loadColorTheme();
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            if(AppSettings.version != version)
            {
                version = AppSettings.version;
            }
            if (AppSettings.darkMode != switchDarkMode.Checked)
            {
                switchDarkMode.Checked = AppSettings.darkMode;
                loadColorTheme();
            }
        }

        private static string config_folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
        private void checkUpdates()
        {
            string configFileLoad = config_folder + "app.ini";
            INIFile ini = new INIFile(configFileLoad);
            string updates;
            using (var wc = new System.Net.WebClient())
                updates = wc.DownloadString(ini.IniReadValue("Version", "UpdateChangesUrl"));
            webBrowser.DocumentText = Markdown.ToHtml(updates + $"<body style='background-color:{ColorTranslator.ToHtml(AppColors.backgroundColor)}; color:{ColorTranslator.ToHtml(AppColors.textColor)}'></body>");
        }

        void checkLastestVersion()
        {
            if (!AppSettings.version.Equals(AppSettings.latestVersion))
                buttonUpdate.Visible = true;

            labelVersion.Text = $"Current version : v{AppSettings.version}";
            labelLatestVersion.Text = $"Latest version : v{AppSettings.latestVersion}";
        }

        private void buttonShortcut_Click(object sender, EventArgs e)
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\LINDRA - Market.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "New shortcut for Market by LINDRA";
            shortcut.TargetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\LINDRA - Market.exe";
            shortcut.Save();
            MessageBox.Show("Shortcut successfully created on your desktop", "Shortcut", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Process.Start($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\MarketUpdater.exe");
            Application.Exit();
        }
    }
}