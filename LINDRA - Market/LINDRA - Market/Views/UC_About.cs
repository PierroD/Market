using LINDRA___Market.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void UC_About_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            labelReport.ForeColor = AppColors.textColor;
            buttonReport.ForeColor = AppColors.textColor;
            buttonReport.FillColor = AppColors.primaryColor;
            labelDiscord.ForeColor = AppColors.textColor;
            labelDiscordTag.ForeColor = AppColors.primaryColor;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PierroD/Market/issues/new");
        }

    }
}
