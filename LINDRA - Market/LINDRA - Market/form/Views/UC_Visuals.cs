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
            trackbarFov.ThumbColor = FormColors.gameColor;
            trackbarFps.ThumbColor = FormColors.gameColor;
            trackbarFovScale.ThumbColor = FormColors.gameColor;
            switchMovie.CheckedState.FillColor = FormColors.gameColor;
        }

        private void trackbarFov_ValueChanged(object sender, EventArgs e)
        {
            labelFovValue.Text = trackbarFov.Value.ToString();
            fps_settings.bar_fov = trackbarFov.Value;
        }

        private void trackbarFps_ValueChanged(object sender, EventArgs e)
        {
            labelFpsValue.Text = trackbarFps.Value.ToString();
            fps_settings.bar_fps = trackbarFps.Value;
        }

        private void comboBoxSpecularMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            fps_settings.specularmap = comboBoxSpecularMap.SelectedIndex;
        }

        private void comboBoxLightMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            fps_settings.lightmap = comboBoxLightMap.SelectedIndex;
        }

        private void switchMovie_CheckedChanged(object sender, EventArgs e)
        {
            fps_settings.sw_movie = switchMovie.Checked;
        }

        private void update_timer_Tick(object sender, EventArgs e)
        {
            if (trackbarFov.Value != fps_settings.bar_fov) trackbarFov.Value = fps_settings.bar_fov;
            if (trackbarFovScale.Value != fps_settings.bar_fovScale) trackbarFovScale.Value = fps_settings.bar_fovScale;
            if (trackbarFps.Value != fps_settings.bar_fps) trackbarFps.Value = fps_settings.bar_fps;
            if (comboBoxLightMap.SelectedIndex != fps_settings.lightmap) comboBoxLightMap.SelectedIndex = fps_settings.lightmap;
            if (comboBoxSpecularMap.SelectedIndex != fps_settings.specularmap) comboBoxSpecularMap.SelectedIndex = fps_settings.specularmap;
            if (switchMovie.Checked != fps_settings.sw_movie) switchMovie.Checked = fps_settings.sw_movie;
        }

        private void trackbarFovScale_ValueChanged(object sender, EventArgs e)
        {
            labelFovScaleValue.Text = $"{(double)trackbarFovScale.Value / 1000}";
            fps_settings.bar_fovScale = trackbarFovScale.Value;
        }
    }
}
