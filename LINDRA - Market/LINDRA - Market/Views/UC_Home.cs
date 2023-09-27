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

                panelMain.BackColor = FormColors.backgroundPrimaryColor;
                panelContainerMW2.BackColor = FormColors.backgroundPrimaryColor;
                panelContainerMW3.BackColor = FormColors.backgroundPrimaryColor;
                panelContainerBO1.BackColor = FormColors.backgroundPrimaryColor;
                panelContainerCOD4.BackColor = FormColors.backgroundPrimaryColor;
                panelBottomMW2.BackColor = FormColors.backgroundSecondaryColor;
                panelBottomMW3.BackColor = FormColors.backgroundSecondaryColor;
                panelBottomBO1.BackColor = FormColors.backgroundSecondaryColor;
                panelBottomCOD4.BackColor = FormColors.backgroundSecondaryColor;
                labelFpsUnlocker.ForeColor = FormColors.backgroundSecondaryColor;
                separator.FillColor = FormColors.backgroundSecondaryColor;
                labelTitleMW2.ForeColor = FormColors.backgroundPrimaryColor;
                labelTitleMW3.ForeColor = FormColors.backgroundPrimaryColor;
                labelTitleBO1.ForeColor = FormColors.backgroundPrimaryColor;
                labelTitleCOD4.ForeColor = FormColors.backgroundPrimaryColor;
                Thread.Sleep(100);
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

        private void buttonLaunchMW3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fps_unlocker>().Count() <= 0)
            {
                fps_unlocker form = new fps_unlocker((this.Parent.Parent as Form), "mw3");
                FormColors.gameColor = Color.FromArgb(87, 204, 153);
                form.Show();
            }
        }

        private void buttonLaunchMW2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fps_unlocker>().Count() <= 0)
            {
                fps_unlocker form = new fps_unlocker((this.Parent.Parent as Form), "mw2");
                FormColors.gameColor = Color.FromArgb(221, 164, 72);
                form.Show();
            }
         }

        private void buttonLaunchBO1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fps_unlocker>().Count() <= 0)
            {
                fps_unlocker form = new fps_unlocker((this.Parent.Parent as Form), "bo1");
                FormColors.gameColor = Color.FromArgb(69, 76, 214);
                form.Show();
            }
        }

        private void buttonLaunchCOD4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fps_unlocker>().Count() <= 0)
            {
                fps_unlocker form = new fps_unlocker((this.Parent.Parent as Form), "cod4");
                FormColors.gameColor = Color.FromArgb(221, 164, 72);
                form.Show();
            }
        }
    }
}
