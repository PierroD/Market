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
        private string[] allowedSafeAreaGames = { "iw4mp", "iw5mp" };
        private string previousGame = "";
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

        dynamic visuals, disable, area, settings;

        private void fps_unlocker_Load(object sender, EventArgs e)
        {
            gameThread = new Thread(new ThreadStart(injectInGame));
            gameThread.Start();
            loadColorTheme();
        }

        private bool isGameAllowed(string gameName)
        {
            return allowedSafeAreaGames.Contains(gameName);
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
            buttonArea.Image = AppColors.getImage("FullScreen");
            buttonArea.CheckedState.FillColor = AppColors.secondaryColor;

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
                case "Area":
                    if (area == null)
                        area = CreateUserControl(buttonName);
                    return area;
                case "Settings":
                    if (settings == null)
                        settings = CreateUserControl(buttonName);
                    return settings;
                default:
                    return null;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            try
            {
                string gameName = COD.GameName();
                if (previousGame != gameName)
                {
                    buttonArea.Visible = isGameAllowed(gameName);
                }
                if (COD.checkGame())
                {
                    labelGameName.Text = COD.LongGameName();
                    labelGameName.ForeColor = AppColors.textColor;
                }
                else
                {
                    labelGameName.Text = "No game found";
                    labelGameName.ForeColor = AppColors.secondaryColor;
                }

            }
            catch (Exception ex) { }

        }

        private void fps_unlocker_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameThread.Abort();
            parent.Visible = true;
        }

        private UserControl CreateUserControl(string usercontrolName)
        {
            return (UserControl)Assembly.GetExecutingAssembly().CreateInstance($"LINDRA___Market.form.FpsUnlocker.Views.UC_{usercontrolName}"); ;
        }

        private void injectInGame()
        {
            while (true)
            {
                if (COD.checkGame())
                {
                    dynamic cod = COD.Game();
                    string gameName = COD.GameName();
                    t.Process_Handle(gameName);
                    t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("cg_fov").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fov);
                    t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("cg_fovScale").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_fovScale / 1000);
                    t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("cg_fovMin").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fovMin);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("com_maxfps").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fps);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_lightMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.lightmap);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_specularMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.specularmap);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_filmUseTweaks").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_movie ? 1 : 0);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_fog").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_fog ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_glow").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_glow ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_detail").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_detailMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("cg_brass").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_bullet ? 0 : 1);
                    if (buttonArea.Visible)
                    {
                        t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("profileMenuOption_safeAreaHorz").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_horizontal / 100);
                        t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("profileMenuOption_safeAreaVert").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_vertical / 100);
                    }
                    Thread.Sleep(100);
                }
            }
        }
    }
}
