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
        Trainer t = new Trainer();
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
                    t.Process_Handle(gameName);

                    long dvar = Convert.ToInt64(cod.GetType().GetProperty("dvar").GetValue(cod));
                    long moduleBase = COD.ModuleBase;

                    long cg_fov = DvarObject(cod, "cg_fov", moduleBase);
                    long cg_fovScale = DvarObject(cod, "cg_fovScale", moduleBase);
                    long cg_fovMin = DvarObject(cod, "cg_fovMin", moduleBase);
                    long com_maxfps = DvarObject(cod, "com_maxfps", moduleBase);
                    long r_lightMap = DvarObject(cod, "r_lightMap", moduleBase);
                    long r_specularMap = DvarObject(cod, "r_specularMap", moduleBase);
                    long r_filmUseTweaks = DvarObject(cod, "r_filmUseTweaks", moduleBase);
                    long r_fog = DvarObject(cod, "r_fog", moduleBase);
                    long r_glow = DvarObject(cod, "r_glow", moduleBase);
                    long r_detail = DvarObject(cod, "r_detail", moduleBase);
                    long r_detailMap = DvarObject(cod, "r_detailMap", moduleBase);
                    long cg_brass = DvarObject(cod, "cg_brass", moduleBase);

                    if (cg_fov != 0) t.WriteFloat(cg_fov + dvar, FpsSettings.bar_fov);
                    if (cg_fovScale != 0) t.WriteFloat(cg_fovScale + dvar, (float)FpsSettings.bar_fovScale / 1000);
                    if (cg_fovMin != 0) t.WriteFloat(cg_fovMin + dvar, FpsSettings.bar_fovMin);
                    if (com_maxfps != 0) t.WriteInteger(com_maxfps + dvar, FpsSettings.bar_fps);
                    if (r_lightMap != 0) t.WriteInteger(r_lightMap + dvar, FpsSettings.lightmap);
                    if (r_specularMap != 0) t.WriteInteger(r_specularMap + dvar, FpsSettings.specularmap);
                    if (r_filmUseTweaks != 0) t.WriteInteger(r_filmUseTweaks + dvar, FpsSettings.sw_movie ? 1 : 0);
                    if (r_fog != 0) t.WriteInteger(r_fog + dvar, FpsSettings.sw_fog ? 0 : 1);
                    if (r_glow != 0) t.WriteInteger(r_glow + dvar, FpsSettings.sw_glow ? 0 : 1);
                    if (r_detail != 0) t.WriteInteger(r_detail + dvar, FpsSettings.sw_camos ? 0 : 1);
                    if (r_detailMap != 0) t.WriteInteger(r_detailMap + dvar, FpsSettings.sw_camos ? 0 : 1);
                    if (cg_brass != 0) t.WriteInteger(cg_brass + dvar, FpsSettings.sw_bullet ? 0 : 1);
                    if (buttonArea.Visible)
                    {
                        long safeAreaHorz = DvarObject(cod, "profileMenuOption_safeAreaHorz", moduleBase);
                        long safeAreaVert = DvarObject(cod, "profileMenuOption_safeAreaVert", moduleBase);
                        if (safeAreaHorz != 0) t.WriteFloat(safeAreaHorz + dvar, (float)FpsSettings.bar_horizontal / 100);
                        if (safeAreaVert != 0) t.WriteFloat(safeAreaVert + dvar, (float)FpsSettings.bar_vertical / 100);
                    }
                    Thread.Sleep(100);
                }
            }
        }

        /// <summary>
        /// Resolves the address of the dvar_t structure for a named dvar.
        /// 32-bit games : the offset is already an absolute address that stores a 4-byte pointer.
        /// 64-bit games : the offset is an RVA from the module base that stores an 8-byte pointer.
        /// Returns 0 when the dvar has not been registered yet.
        /// </summary>
        private long DvarObject(dynamic cod, string dvarName, long moduleBase)
        {
            long offset = Convert.ToInt64(cod.GetType().GetProperty(dvarName).GetValue(cod));
            if (offset == 0) return 0;
            if (COD.Is64Bit) return t.ReadPointer(moduleBase + offset);
            return t.ReadInteger(offset);
        }
    }
}
