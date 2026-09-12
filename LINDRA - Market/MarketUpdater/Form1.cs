using MarketUpdater.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketUpdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            LoadingCircleAnimation();
        }
        #region circle animation
        int direction = 1;
        void LoadingCircleAnimation()
        {
            if (progressBarLoading.Value == 70 || progressBarLoading.Value == 0)
                direction = (direction == 1) ? -1 : 1; // change direction

            progressBarLoading.Value += direction;
        }
        #endregion

        private static string configIniPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\app.ini";
        INIFile ini = new INIFile(configIniPath);
        private string tempFolder = Path.GetTempPath() + "Market";
        private string zipPath = "";
        private void update()
        {
            string[] updateDownload;
            string downloadUrl = ini.IniReadValue("Version", "UpdateDownloadUrl");
            using (var wc = new WebClient())
                updateDownload = wc.DownloadString(downloadUrl).Split(new[] { '\r', '\n' });

            string latestUpdate = updateDownload[0];

            if (!Directory.Exists(tempFolder))
            {
                Directory.CreateDirectory(tempFolder);
                labelMainText.Text = "Create temp download folder";
            }
            zipPath = tempFolder + "\\" + Guid.NewGuid() + ".zip";
            labelMainText.Text = ("Downloading update");
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                wc.DownloadFileAsync(
                    // download link
                    new Uri(latestUpdate),
                    // physical link
                    zipPath
                    );
            }
            labelMainText.Text = ("Extracting files and updating Market");

        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string install_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (var strm = File.OpenRead(zipPath))
            using (ZipArchive archive = new ZipArchive(strm))
                ZipArchiveExtensions.ExtractToDirectory(archive, install_path, true);

            labelMainText.Text = ("Updating Market config file");
            ini.IniWriteValue("Version", "AppVersion", new WebClient().DownloadString(ini.IniReadValue("VERSION", "LastestVersionUrl")));
            labelMainText.Text = ("Update is done");
            timerLoading.Stop();
            buttonStart.Enabled = true;

        }

        // Event to track the progress
        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            labelProgress.Text = $"{e.ProgressPercentage}%";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            update();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Process.Start($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\LINDRA - Market.exe");
            Application.Exit();

        }
    }
}
