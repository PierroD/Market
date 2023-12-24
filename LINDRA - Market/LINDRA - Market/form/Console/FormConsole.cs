using Guna.UI2.WinForms;
using LINDRA___Market.Utils;
using MarketOffsets;
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
using PLogger;

namespace LINDRA___Market.form.Console
{
    public partial class FormConsole : Form
    {
        private Form parent;

        public FormConsole(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormConsole_Load(object sender, EventArgs e)
        {
            Log.setActivityId();
            this.BackColor = AppColors.backgroundColor;
            panelTopLeft.BackColor = AppColors.backgroundTransparencyColor;
            panelTopRight.BackColor = AppColors.backgroundTransparencyColor;
            panelLeft.FillColor = AppColors.backgroundTransparencyColor;
            labelTitle.ForeColor = AppColors.textColor;
            labelPage.ForeColor = AppColors.textColor;
            buttonClose.FillColor = AppColors.backgroundTransparencyColor;
            buttonMinimize.FillColor = AppColors.backgroundTransparencyColor;
            buttonClose.IconColor = AppColors.textColor;
            buttonMinimize.IconColor = AppColors.textColor;
            buttonConsole.Image = AppColors.getImage("Console");
            buttonSearch.Image = AppColors.getImage("Search");
            buttonSettings.Image = AppColors.getImage("Settings");
            labelGameName.ForeColor = AppColors.secondaryColor;

            this.parent.Visible = false;
            buttonConsole.PerformClick();
        }

        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Log.setFunctionPassedThrough();
            Guna2Button button = ((Guna2Button)sender);
            Log.Infos("FormConsoleMenu switch to", button.Name);
            labelPage.Text = button.Name.Replace("button", String.Empty);
            pictureBoxPage.Image = (Bitmap)button.Image;
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
        }

        dynamic console, settings, search;

        private void FormConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("Closing FormConsole");
            Log.setPreviousActivityId();
            parent.Visible = true;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
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

        private UserControl GetUserControlInstance(string buttonName)
        {
            Log.setFunctionPassedThrough();
            Log.Infos("Switch to UC_Instance", buttonName);
            switch (buttonName)
            {
                case "Console":
                    if (console == null)
                        console = CreateUserControl(buttonName);
                    return console;
                case "Search":
                    if (search == null)
                        search = CreateUserControl(buttonName);
                    return search;
                case "Settings":
                    if (settings == null)
                        settings = CreateUserControl(buttonName);
                    return settings;
                default:
                    return null;
            }
        }

        private UserControl CreateUserControl(string usercontrolName)
        {
            return (UserControl)Assembly.GetExecutingAssembly().CreateInstance($"LINDRA___Market.form.Console.Views.UC_{usercontrolName}"); ;
        }
    }
}
