using Guna.UI2.WinForms;
using LINDRA___Market.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINDRA___Market.form.Console
{
    public partial class FormConsole : Form
    {
        public FormConsole(Form parent)
        {
            InitializeComponent();
        }

        private void FormConsole_Load(object sender, EventArgs e)
        {
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
            buttonConsole.PerformClick();
        }


        private void buttons_SideBar_Click(object sender, EventArgs e)
        {
            Guna2Button button = ((Guna2Button)sender);
            labelPage.Text = button.Name.Replace("button", String.Empty);
            pictureBoxPage.Image = (Bitmap)button.Image;
            SwitchUserControl.SwitchUserControl.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
        }

        dynamic console, settings, search;
        private UserControl GetUserControlInstance(string buttonName)
        {
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
