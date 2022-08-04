using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LINDRA___Market.Utils;
using MarketOffsets;

namespace LINDRA___Market.form.Views
{
    public partial class UC_Feed : UserControl
    {
        public UC_Feed()
        {
            InitializeComponent();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            setColor(Color.FromArgb(153, 163, 176), Color.FromArgb(166, 145, 105));
        }


        private void openColorDialog(object sender, EventArgs e)
        {
            Guna2Panel panel = (Guna2Panel)sender;
            if (panel.Name.Contains("Allies"))
            {
                if (colorDialogAllies.ShowDialog() == DialogResult.OK)
                {
                    setColor(colorDialogAllies.Color, fps_settings.axis_feed);
                }
            }
            else
            {
                if (colorDialogAxis.ShowDialog() == DialogResult.OK)
                {
                    setColor(fps_settings.allies_feed, colorDialogAxis.Color);
                }

            }
        }

        private void setColor(Color allies, Color axis)
        {
            fps_settings.allies_feed = allies;
            fps_settings.axis_feed = axis;

            panelAllies.BackColor = fps_settings.allies_feed;
            panelAxis.BackColor = fps_settings.axis_feed;

        }

        private void UC_Feed_Load(object sender, EventArgs e)
        {
            buttonSetFeedColor.FillColor = FormColors.gameColor;
        }

        private void buttonSetFeedColor_Click(object sender, EventArgs e)
        {
            if (COD.GameName() == "iw4mp")
            {
                ExternalConsole.Send($"g_teamcolor_axis {fps_settings.axis_feed.R / 255} {fps_settings.axis_feed.G / 255} {fps_settings.axis_feed.B / 255}; g_teamcolor_allies {fps_settings.allies_feed.R / 255} {fps_settings.allies_feed.G / 255} {fps_settings.allies_feed.B / 255}");
            }
            else
            {
                ExternalConsole.Send($"cg_teamcolor_axis {fps_settings.axis_feed.R / 255} {fps_settings.axis_feed.G / 255} {fps_settings.axis_feed.B / 255}; cg_teamcolor_allies {fps_settings.allies_feed.R / 255} {fps_settings.allies_feed.G / 255} {fps_settings.allies_feed.B / 255}");
            }
        }

        private void update_timer_Tick(object sender, EventArgs e)
        {
            if (panelAllies.BackColor != fps_settings.allies_feed || panelAxis.BackColor != fps_settings.axis_feed)
            {
                panelAllies.BackColor = fps_settings.allies_feed;
                panelAxis.BackColor = fps_settings.axis_feed;
                buttonSetFeedColor.PerformClick();
            }

        }
    }
}
