using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MarketOffsets;
using LINDRA___Market.Utils;
using Guna.UI2.WinForms.Enums;

namespace LINDRA___Market.form
{
    public partial class fps_unlocker : Form
    {
        Trainer t = new Trainer();
        Thread gameThread;
        Form parent;
        public fps_unlocker(Form parent)
        {
            InitializeComponent();
            buttonVisuals.PerformClick();
            this.parent = parent;
            this.parent.Visible = false;
        }

        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Guna2Button button = ((Guna2Button)sender);
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
        }

        dynamic visuals, disable, feed, settings;

        private void fps_unlocker_Load(object sender, EventArgs e)
        {
            gameThread = new Thread(new ThreadStart(injectInGame));
            gameThread.Start();
            loadColorTheme();
        }

        private void loadColorTheme()
        {
            this.BackColor = AppColors.backgroundColor;
            panelTop.BackColor = AppColors.backgroundTransparencyColor;
            panelBottom.BackColor = Color.Transparent;
            panelMain.BackColor = AppColors.backgroundColor;
            labelTitle.ForeColor = AppColors.textColor;
            buttonVisuals.Image = AppColors.getImage("Camera");
            buttonVisuals.CheckedState.FillColor = AppColors.secondaryColor;
            buttonDisable.Image = AppColors.getImage("Eye");
            buttonDisable.CheckedState.FillColor = AppColors.secondaryColor;
            buttonSettings.Image = AppColors.getImage("Settings");
            buttonSettings.CheckedState.FillColor = AppColors.secondaryColor;
            buttonMinimize.IconColor = AppColors.textColor;
            buttonClose.IconColor = AppColors.textColor;
        }

        private UserControl GetUserControlInstance(string buttonName)
        {
            switch (buttonName)
            {
                case "Visuals":
                    if (visuals == null)
                        visuals = CreateUserControl(buttonName);
                    return visuals;
                case "Disable":
                    if (disable == null)
                        disable = CreateUserControl(buttonName);
                    return disable;
                case "Feed":
                    if (feed == null)
                        feed = CreateUserControl(buttonName);
                    return feed;
                case "Settings":
                    if (settings == null)
                        settings = CreateUserControl(buttonName);
                    return settings;
                default:
                    return null;
            }
        }

        private void fps_unlocker_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameThread.Abort();
            parent.Visible = true;
        }

        private UserControl CreateUserControl(string usercontrolName)
        {
            return (UserControl)Assembly.GetExecutingAssembly().CreateInstance($"LINDRA___Market.form.Views.UC_{usercontrolName}"); ;
        }

        private void injectInGame()
        {
            while (true)
            {
                if (COD.checkGame())
                {
                    labelGameName.Text = COD.LongGameName();
                    labelGameName.ForeColor = AppColors.textColor;
                    dynamic cod = COD.Game();
                    t.Process_Handle(COD.GameName());
                    t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("cg_fov").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fov);
                    t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("cg_fovScale").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_fovScale/1000);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("com_maxfps").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fps);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_lightMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.lightmap);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_specularMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.specularmap);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_filmUseTweaks").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_movie ? 1 : 0);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_fog").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_fog ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_glow").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_glow ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_detail").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_detailMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("cg_brass").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_bullet ? 0 : 1);

                    Thread.Sleep(100);
                } else
                {
                    labelGameName.Text = "No game found";
                    labelGameName.ForeColor = AppColors.secondaryColor;
                }
            }
        }
    }
}
