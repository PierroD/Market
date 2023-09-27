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

namespace LINDRA___Market.form
{
    public partial class fps_unlocker : Form
    {
        Trainer t = new Trainer();
        Thread gameThread;
        private string gameName;
        Form parent;
        public fps_unlocker(Form parent, string game)
        {
            InitializeComponent();
            gameName = game;
            Console.WriteLine(game);
            buttonVisuals.PerformClick();
            this.parent = parent;
            this.parent.Visible = false;
        }

        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Guna2Button button = ((Guna2Button)sender);
            updateButton(button.Name);
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
        }

        dynamic visuals, disable, feed, settings;

        private void fps_unlocker_Load(object sender, EventArgs e)
        {
            gameThread = new Thread(new ThreadStart(injectInGame));
            gameThread.Start();
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

        private void updateButton(string buttonName)
        {
            buttonVisuals.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(buttonVisuals.Name == buttonName ? $"video_on_{gameName}" : "video_off");
            buttonDisable.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(buttonDisable.Name == buttonName ? $"eye_on_{gameName}" : "eye_off");
            buttonFeed.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(buttonFeed.Name == buttonName ? $"align-left_on_{gameName}" : "align-left_off");
            buttonSettings.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(buttonSettings.Name == buttonName ? $"sliders_on_{gameName}" : "sliders_off");
        }

        private void injectInGame()
        {
            while (true)
            {
                if (COD.checkGame())
                {
                    dynamic cod = COD.Game();
                    t.Process_Handle(COD.GameName());
                    t.WriteFloat(t.ReadInteger((int)cod.GetType().GetProperty("cg_fov").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.bar_fov);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("com_maxfps").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.bar_fps);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_lightMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.lightmap);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_specularMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.specularmap);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_filmUseTweaks").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.sw_movie ? 1 : 0);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_fog").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.sw_fog ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_glow").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.sw_glow ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_detail").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.sw_camos ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("r_detailMap").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.sw_camos ? 0 : 1);
                    t.WriteInteger(t.ReadInteger((int)cod.GetType().GetProperty("cg_brass").GetValue(cod)) + (int)cod.GetType().GetProperty("dvar").GetValue(cod), fps_settings.sw_bullet ? 0 : 1);

                    Thread.Sleep(100);
                }
            }

        }
    }
}
