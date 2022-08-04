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
            switchFog.CheckedState.FillColor = FormColors.gameColor;
            switchGlow.CheckedState.FillColor = FormColors.gameColor;
            switchBullet.CheckedState.FillColor = FormColors.gameColor;
            switchCamos.CheckedState.FillColor = FormColors.gameColor;
        }

        private void switchFog_CheckedChanged(object sender, EventArgs e)
        {
            fps_settings.sw_fog = switchFog.Checked;
        }

        private void switchGlow_CheckedChanged(object sender, EventArgs e)
        {
            fps_settings.sw_glow = switchGlow.Checked;
        }

        private void switchBullet_CheckedChanged(object sender, EventArgs e)
        {
            fps_settings.sw_bullet = switchBullet.Checked;
        }

        private void switchCamos_CheckedChanged(object sender, EventArgs e)
        {
            fps_settings.sw_camos = switchCamos.Checked;
        }
        private void update_timer_Tick(object sender, EventArgs e)
        {
            if (switchFog.Checked != fps_settings.sw_fog) switchFog.Checked = fps_settings.sw_fog;
            if (switchGlow.Checked != fps_settings.sw_glow) switchGlow.Checked = fps_settings.sw_glow;
            if (switchCamos.Checked != fps_settings.sw_camos) switchCamos.Checked = fps_settings.sw_camos;
            if (switchBullet.Checked != fps_settings.sw_bullet) switchBullet.Checked = fps_settings.sw_bullet;

        }
    }
}
