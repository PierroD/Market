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
using LINDRA___Market.Utils;
using LINDRA___Market.form;

namespace LINDRA___Market.Views
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        
        Thread colorThread;
        /// <summary>
        /// This function change the UI based on the theme selected in the settings
        /// </summary>
        private void loadColorTheme()
        {
            while (true)
            {
                panelMain.BackColor = AppColors.backgroundColor;
                #region FpsUnclocker
                panelFps.FillColor = AppColors.backgroundTransparencyColor;
                pictureBoxFps.FillColor = AppColors.primaryColor;
                labelFpsTitle.ForeColor = AppColors.primaryColor;
                labelFpsDescription.ForeColor = AppColors.textColor;
                buttonFpsRun.ForeColor = AppColors.textColor;
                buttonFpsRun.FillColor = AppColors.primaryColor;
                #endregion
                #region ExternalConsole
                panelConsole.FillColor = AppColors.backgroundTransparencyColor;
                pictureBoxConsole.FillColor = AppColors.secondaryColor;
                labelConsoleTitle.ForeColor = AppColors.secondaryColor;
                labelConsoleDescription.ForeColor = AppColors.textColor;
                labelInProgress.ForeColor = AppColors.secondaryColor;
                #endregion
                Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Start color thread on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Home_Load(object sender, EventArgs e)
        {
            colorThread = new Thread(new ThreadStart(() => loadColorTheme()));
            colorThread.Start();
        }

        public void stopThreads()
        {
            colorThread.Abort();
        }

        private void buttonFpsRun_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fps_unlocker>().Count() <= 0)
            {
                fps_unlocker form = new fps_unlocker((this.Parent.Parent as Form));
                form.Show();
            }

        }
    }
}
