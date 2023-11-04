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
            trackbarFovScale.ThumbColor = AppColors.primaryColor;
            trackbarFovMinimum.ThumbColor = AppColors.primaryColor;
            labelFov.ForeColor = AppColors.textColor;
            labelFovValue.ForeColor = AppColors.textColor;
            labelFps.ForeColor = AppColors.textColor;
            labelFpsValue.ForeColor = AppColors.textColor;
            labelFovScale.ForeColor = AppColors.textColor;
            labelFovScaleValue.ForeColor = AppColors.textColor;
            labelFovMinimum.ForeColor = AppColors.textColor;
            labelFovMinimumValue.ForeColor = AppColors.textColor;
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

        private void trackbarFovScale_ValueChanged(object sender, EventArgs e)
        {
            labelFovScaleValue.Text = $"{(double)trackbarFovScale.Value / 1000}";
            FpsSettings.bar_fovScale = trackbarFovScale.Value;
        }

        private void trackbarFovMinimum_ValueChanged(object sender, EventArgs e)
        {
            labelFovMinimumValue.Text = trackbarFovMinimum.Value.ToString();
            FpsSettings.bar_fovMin = trackbarFovMinimum.Value;
        }

        private void update_timer_Tick(object sender, EventArgs e)
        {
            if (trackbarFov.Value != FpsSettings.bar_fov) trackbarFov.Value = FpsSettings.bar_fov;
            if (trackbarFps.Value != FpsSettings.bar_fps) trackbarFps.Value = FpsSettings.bar_fps;
            if (trackbarFovScale.Value != FpsSettings.bar_fovScale) trackbarFovScale.Value = FpsSettings.bar_fovScale;
            if (trackbarFovMinimum.Value != FpsSettings.bar_fovMin) trackbarFovMinimum.Value = FpsSettings.bar_fovMin;
        }

    }
}
