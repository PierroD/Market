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
using PLogger;
using LINDRA___Market.form.FpsUnlocker.Views;

namespace LINDRA___Market.form
{
    public partial class fps_unlocker : Form
    {
        Trainer trainer = new Trainer();

        Thread gameThread;
        Form parent;
        private string[] allowedSafeAreaGames = { "iw4mp", "iw5mp" };
        private string previousGame = "";
        private bool safeAreaPreviousState = false;
        public fps_unlocker(Form parent)
        {
            InitializeComponent();
            buttonVisuals.PerformClick();
            this.parent = parent;
            this.parent.Visible = false;
        }

        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Log.setFunctionPassedThrough();
            Guna2Button button = ((Guna2Button)sender);
            Log.Infos("FpsUnlocker switch view to :", button.Name);
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
        }

        private void fps_unlocker_Load(object sender, EventArgs e)
        {
            Log.setActivityId();
            gameThread = new Thread(new ThreadStart(injectInGame));
            gameThread.Start();
            loadColorTheme();
        }

        private bool isGameAllowed(string gameName)
        {
            Log.setFunctionPassedThrough();
            bool isGameAllwed = allowedSafeAreaGames.Contains(gameName);
            if (buttonArea.Visible != safeAreaPreviousState)
            {
                safeAreaPreviousState = isGameAllwed;
                Log.Infos("isGame :", gameName, "AllowedToUseSafeArea :", allowedSafeAreaGames.Contains(gameName));
            }
            return isGameAllwed;
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

        UC_Visuals visuals;
        UC_Disable disable;
        UC_Area area;
        UC_Settings settings;
        private UserControl GetUserControlInstance(string buttonName)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("Switch to UC_Instance", buttonName);
            switch (buttonName)
            {
                case "Visuals":
                    if (visuals == null)
                        visuals = CreateUserControl<UC_Visuals>(buttonName);
                    return visuals;
                case "Disable":
                    if (disable == null)
                        disable = CreateUserControl<UC_Disable>(buttonName);
                    return disable;
                case "Area":
                    if (area == null)
                        area = CreateUserControl<UC_Area>(buttonName);
                    return area;
                case "Settings":
                    if (settings == null)
                        settings = CreateUserControl<UC_Settings>(buttonName);
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
                if (previousGame != gameName && gameName != null)
                {
                    Log.Trace("Previous Game", previousGame, "Game Name", gameName);
                    buttonArea.Visible = isGameAllowed(gameName);
                }
                if (COD.checkGame())
                {
                    if (labelGameName.Text != COD.LongGameName())
                    {
                        Log.setFunctionPassedThrough();
                        Log.Infos("Game detected", COD.LongGameName());
                        labelGameName.Text = COD.LongGameName();
                        labelGameName.ForeColor = AppColors.textColor;
                    }
                }
                else
                {
                    if (labelGameName.Text != "No game found")
                    {
                        Log.setFunctionPassedThrough();
                        Log.Infos("No game detected");
                        labelGameName.Text = "No game found";
                        labelGameName.ForeColor = AppColors.secondaryColor;
                    }
                }

            }
            catch (Exception ex) { }

        }

        private void fps_unlocker_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameThread.Abort();
            parent.Visible = true;
            Log.setFunctionPassedThrough();
            Log.Infos("Closing fps_unlocker");
            Log.setPreviousActivityId();
        }

        private T CreateUserControl<T>(string usercontrolName)
        {
            return (T)Assembly.GetExecutingAssembly().CreateInstance($"LINDRA___Market.form.FpsUnlocker.Views.UC_{usercontrolName}"); ;
        }

        private void injectInGame()
        {
            while (true)
            {
                if (COD.checkGame())
                {
                    dynamic cod = COD.Game();
                    string gameName = COD.GameName();
                    trainer.Process_Handle(gameName);
                    if (COD.Is64BitGame())
                    {
                        trainer.WriteFloat(trainer.ReadLong(cod.GetType().GetProperty("cg_fov").GetValue(cod)) + (long)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fov);
                        trainer.WriteFloat(trainer.ReadLong(cod.GetType().GetProperty("cg_fovScale").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_fovScale / 1000);
                        trainer.WriteFloat(trainer.ReadLong(cod.GetType().GetProperty("cg_fovMin").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fovMin);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("com_maxfps").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fps);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("r_lightMap").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.lightmap);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("r_specularMap").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.specularmap);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("r_filmUseTweaks").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_movie ? 1 : 0);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("r_fog").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_fog ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("r_glow").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_glow ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("r_detail").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("r_detailMap").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadLong(cod.GetType().GetProperty("cg_brass").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_bullet ? 0 : 1);
                        if (buttonArea.Visible)
                        {
                            trainer.WriteFloat(trainer.ReadLong(cod.GetType().GetProperty("profileMenuOption_safeAreaHorz").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_horizontal / 100);
                            trainer.WriteFloat(trainer.ReadLong(cod.GetType().GetProperty("profileMenuOption_safeAreaVert").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_vertical / 100);
                        }
                    }
                    else
                    {
                        trainer.WriteFloat(trainer.ReadInteger(cod.GetType().GetProperty("cg_fov").GetValue(cod)) + (long)cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fov);
                        trainer.WriteFloat(trainer.ReadInteger(cod.GetType().GetProperty("cg_fovScale").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_fovScale / 1000);
                        trainer.WriteFloat(trainer.ReadInteger(cod.GetType().GetProperty("cg_fovMin").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fovMin);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("com_maxfps").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.bar_fps);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("r_lightMap").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.lightmap);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("r_specularMap").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.specularmap);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("r_filmUseTweaks").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_movie ? 1 : 0);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("r_fog").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_fog ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("r_glow").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_glow ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("r_detail").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("r_detailMap").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_camos ? 0 : 1);
                        trainer.WriteInteger(trainer.ReadInteger(cod.GetType().GetProperty("cg_brass").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), FpsSettings.sw_bullet ? 0 : 1);
                        if (buttonArea.Visible)
                        {
                            trainer.WriteFloat(trainer.ReadInteger(cod.GetType().GetProperty("profileMenuOption_safeAreaHorz").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_horizontal / 100);
                            trainer.WriteFloat(trainer.ReadInteger(cod.GetType().GetProperty("profileMenuOption_safeAreaVert").GetValue(cod)) + cod.GetType().GetProperty("dvar").GetValue(cod), (float)FpsSettings.bar_vertical / 100);
                        }

                    }
                    Thread.Sleep(100);
                }
            }
        }
    }
}
