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

namespace LINDRA___Market.form.Views
{
    public partial class UC_Disable : UserControl
    {
        public UC_Disable()
        {
            InitializeComponent();
        }

        private void UC_Disable_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            switchFog.CheckedState.FillColor = AppColors.primaryColor;
            switchGlow.CheckedState.FillColor = AppColors.primaryColor;
            switchBullet.CheckedState.FillColor = AppColors.primaryColor;
            switchCamos.CheckedState.FillColor = AppColors.primaryColor;
            labelFog.ForeColor = AppColors.textColor;
            labelGlow.ForeColor = AppColors.textColor;
            labelBullet.ForeColor = AppColors.textColor;
            labelCamos.ForeColor = AppColors.textColor;
        }

        private void switchFog_CheckedChanged(object sender, EventArgs e)
        {
            FpsSettings.sw_fog = switchFog.Checked;
        }

        private void switchGlow_CheckedChanged(object sender, EventArgs e)
        {
            FpsSettings.sw_glow = switchGlow.Checked;
        }

        private void switchBullet_CheckedChanged(object sender, EventArgs e)
        {
            FpsSettings.sw_bullet = switchBullet.Checked;
        }

        private void switchCamos_CheckedChanged(object sender, EventArgs e)
        {
            FpsSettings.sw_camos = switchCamos.Checked;
        }
        private void update_timer_Tick(object sender, EventArgs e)
        {
            if (switchFog.Checked != FpsSettings.sw_fog) switchFog.Checked = FpsSettings.sw_fog;
            if (switchGlow.Checked != FpsSettings.sw_glow) switchGlow.Checked = FpsSettings.sw_glow;
            if (switchCamos.Checked != FpsSettings.sw_camos) switchCamos.Checked = FpsSettings.sw_camos;
            if (switchBullet.Checked != FpsSettings.sw_bullet) switchBullet.Checked = FpsSettings.sw_bullet;

        }
    }
}
