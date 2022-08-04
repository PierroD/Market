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
            this.BackColor = FormColors.backgroundPrimaryColor;
            labelSettings.ForeColor = FormColors.backgroundSecondaryColor;
            labelDarkMode.ForeColor = FormColors.backgroundSecondaryColor;
            separator.FillColor = FormColors.backgroundSecondaryColor;
            labelVersion.ForeColor = FormColors.backgroundSecondaryColor;
            labelLatestVersion.ForeColor = FormColors.backgroundSecondaryColor;
            buttonUpdate.FillColor = FormColors.backgroundSecondaryColor;
            buttonUpdate.ForeColor = FormColors.backgroundPrimaryColor;
            labelVersions.ForeColor = FormColors.backgroundSecondaryColor;
            separator1.FillColor = FormColors.backgroundSecondaryColor;
            buttonShortcut.ForeColor = FormColors.backgroundPrimaryColor;
            buttonShortcut.FillColor = FormColors.backgroundSecondaryColor;
        }

        private void switchDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            app_settings.darkMode = switchDarkMode.Checked;
            if (switchDarkMode.Checked)
            {
                FormColors.backgroundPrimaryColor = Color.FromArgb(28, 40, 38);
                FormColors.backgroundSecondaryColor = Color.FromArgb(217, 247, 250);
            }
            else
            {
                FormColors.backgroundSecondaryColor = Color.FromArgb(28, 40, 38);
                FormColors.backgroundPrimaryColor = Color.FromArgb(217, 247, 250);
            }
            loadColorTheme();
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            if(app_settings.version != version)
            {
                version = app_settings.version;
            }
            if (app_settings.darkMode != switchDarkMode.Checked)
            {
                switchDarkMode.Checked = app_settings.darkMode;
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
            webBrowser.DocumentText = Markdown.ToHtml(updates + $"<body style='background-color:{ColorTranslator.ToHtml(FormColors.backgroundPrimaryColor)}; color:{ColorTranslator.ToHtml(FormColors.backgroundSecondaryColor)}'></body>");
        }

        void checkLastestVersion()
        {
            if (!app_settings.version.Equals(app_settings.latestVersion))
                buttonUpdate.Visible = true;

            labelVersion.Text = $"Current version : v{app_settings.version}";
            labelLatestVersion.Text = $"Latest version : v{app_settings.latestVersion}";
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