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

namespace LINDRA___Market.form.FpsUnlocker.Views
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
            labelLightmap.ForeColor = AppColors.textColor;
            labelSpecularmap.ForeColor = AppColors.textColor;
            labelMovie.ForeColor = AppColors.textColor;
            comboBoxLightMap.FillColor = AppColors.backgroundColor;
            comboBoxLightMap.ForeColor = AppColors.textColor;
            comboBoxSpecularMap.FillColor = AppColors.backgroundColor;
            comboBoxSpecularMap.ForeColor = AppColors.textColor;
            switchMovie.CheckedState.FillColor = AppColors.primaryColor;
        }

        private void comboBoxLightMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            FpsSettings.lightmap = comboBoxLightMap.SelectedIndex;
        }
        private void comboBoxSpecularMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            FpsSettings.specularmap = comboBoxSpecularMap.SelectedIndex;
        }

        private void switchMovie_CheckedChanged(object sender, EventArgs e)
        {
            FpsSettings.sw_movie = switchMovie.Checked;
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
            if (comboBoxLightMap.SelectedIndex != FpsSettings.lightmap) comboBoxLightMap.SelectedIndex = FpsSettings.lightmap;
            if (comboBoxSpecularMap.SelectedIndex != FpsSettings.specularmap) comboBoxSpecularMap.SelectedIndex = FpsSettings.specularmap;
            if (switchMovie.Checked != FpsSettings.sw_movie) switchMovie.Checked = FpsSettings.sw_movie;
        }

    }
}
