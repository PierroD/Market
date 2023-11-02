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
    public partial class UC_Visuals : UserControl
    {
        public UC_Visuals()
        {
            InitializeComponent();
        }

        private void UC_Visuals_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            trackbarFov.ThumbColor = AppColors.primaryColor;
            trackbarFps.ThumbColor = AppColors.primaryColor;
            trackbarFovScale.ThumbColor = AppColors.primaryColor ;
            switchMovie.CheckedState.FillColor = AppColors.primaryColor;
            labelFov.ForeColor = AppColors.textColor;
            labelFovValue.ForeColor = AppColors.textColor;
            labelFps.ForeColor = AppColors.textColor;
            labelFpsValue.ForeColor = AppColors.textColor;
            labelFovScale.ForeColor = AppColors.textColor;
            labelFovScaleValue.ForeColor = AppColors.textColor;
            labelLightmap.ForeColor = AppColors.textColor;
            labelSpecularmap.ForeColor = AppColors.textColor;
            labelMovie.ForeColor = AppColors.textColor;
            comboBoxLightMap.FillColor = AppColors.backgroundColor;
            comboBoxLightMap.ForeColor = AppColors.textColor;
            comboBoxSpecularMap.FillColor = AppColors.backgroundColor;
            comboBoxSpecularMap.ForeColor = AppColors.textColor;
        }

        private void trackbarFov_ValueChanged(object sender, EventArgs e)
        {
            labelFovValue.Text = trackbarFov.Value.ToString();
            FpsSettings.bar_fov = trackbarFov.Value;
        }

        private void trackbarFps_ValueChanged(object sender, EventArgs e)
        {
            labelFpsValue.Text = trackbarFps.Value.ToString();
            FpsSettings.bar_fps = trackbarFps.Value;
        }

        private void comboBoxSpecularMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            FpsSettings.specularmap = comboBoxSpecularMap.SelectedIndex;
        }

        private void comboBoxLightMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            FpsSettings.lightmap = comboBoxLightMap.SelectedIndex;
        }

        private void switchMovie_CheckedChanged(object sender, EventArgs e)
        {
            FpsSettings.sw_movie = switchMovie.Checked;
        }

        private void update_timer_Tick(object sender, EventArgs e)
        {
            if (trackbarFov.Value != FpsSettings.bar_fov) trackbarFov.Value = FpsSettings.bar_fov;
            if (trackbarFovScale.Value != FpsSettings.bar_fovScale) trackbarFovScale.Value = FpsSettings.bar_fovScale;
            if (trackbarFps.Value != FpsSettings.bar_fps) trackbarFps.Value = FpsSettings.bar_fps;
            if (comboBoxLightMap.SelectedIndex != FpsSettings.lightmap) comboBoxLightMap.SelectedIndex = FpsSettings.lightmap;
            if (comboBoxSpecularMap.SelectedIndex != FpsSettings.specularmap) comboBoxSpecularMap.SelectedIndex = FpsSettings.specularmap;
            if (switchMovie.Checked != FpsSettings.sw_movie) switchMovie.Checked = FpsSettings.sw_movie;
        }

        private void trackbarFovScale_ValueChanged(object sender, EventArgs e)
        {
            labelFovScaleValue.Text = $"{(double)trackbarFovScale.Value / 1000}";
            FpsSettings.bar_fovScale = trackbarFovScale.Value;
        }
    }
}
