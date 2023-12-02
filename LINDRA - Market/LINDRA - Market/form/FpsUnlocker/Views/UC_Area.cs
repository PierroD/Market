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

namespace LINDRA___Market.form.FpsUnlocker.Views
{
    public partial class UC_Area : UserControl
    {
        public UC_Area()
        {
            InitializeComponent();
        }

        private void UC_Area_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            labelSafeArea.ForeColor = AppColors.textColor;
            labelSafeAreaXValue.ForeColor = AppColors.textColor;
            labelSafeAreaYValue.ForeColor = AppColors.textColor;
            trackbarSafeAreaX.ThumbColor = AppColors.primaryColor;
            trackbarSafeAreaY.ThumbColor = AppColors.primaryColor;
        }

        private void update_timer_Tick(object sender, EventArgs e)
        {
            if (trackbarSafeAreaX.Value != FpsSettings.bar_horizontal) trackbarSafeAreaX.Value = FpsSettings.bar_horizontal;
            if (trackbarSafeAreaY.Value != FpsSettings.bar_vertical) trackbarSafeAreaY.Value = FpsSettings.bar_vertical;
        }

        private void trackbarSafeAreaX_ValueChanged(object sender, EventArgs e)
        {
            labelSafeAreaXValue.Text = $"{(double)trackbarSafeAreaX.Value / 100}";
            FpsSettings.bar_horizontal = trackbarSafeAreaX.Value;
        }

        private void trackbarSafeAreaY_ValueChanged(object sender, EventArgs e)
        {
            labelSafeAreaYValue.Text = $"{(double)trackbarSafeAreaY.Value / 100}";
            FpsSettings.bar_vertical = trackbarSafeAreaY.Value;

        }
    }
}
