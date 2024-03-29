﻿using LINDRA___Market.Utils;
using PLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINDRA___Market.Views
{
    public partial class UC_About : UserControl
    {
        public UC_About()
        {
            InitializeComponent();
        }

        Thread colorThread;
        private void loadColorTheme()
        {
            while (true)
            {
                this.BackColor = AppColors.backgroundColor;
                labelReport.ForeColor = AppColors.textColor;
                buttonReport.ForeColor = AppColors.textColor;
                buttonReport.FillColor = AppColors.primaryColor;
                labelDiscord.ForeColor = AppColors.textColor;
                labelDiscordTag.ForeColor = AppColors.primaryColor;
                labelVisit.ForeColor = AppColors.textColor;
                buttonVisit.ForeColor = AppColors.textColor;
                buttonVisit.FillColor = AppColors.primaryColor;
                labelFAQ.ForeColor = AppColors.textColor;
                buttonFAQ.ForeColor = AppColors.textColor;
                buttonFAQ.FillColor = AppColors.primaryColor;
                Thread.Sleep(10);
            }
        }
        private void UC_About_Load(object sender, EventArgs e)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("Start 'About' color thread");
            colorThread = new Thread(new ThreadStart(() => loadColorTheme()));
            colorThread.Start();
        }

        public void stopThreads()
        {
            colorThread.Abort();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("buttonReport Clicked");
            System.Diagnostics.Process.Start("https://github.com/PierroD/Market/issues/new");
        }

        private void buttonVisit_Click(object sender, EventArgs e)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("buttonVisit Clicked");
            System.Diagnostics.Process.Start("https://github.com/PierroD/Market/");
        }

        private void buttonFAQ_Click(object sender, EventArgs e)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("buttonFAQ Clicked");
            System.Diagnostics.Process.Start("https://github.com/PierroD/Market/blob/main/_readmes/FAQ.md");
        }
    }
}
