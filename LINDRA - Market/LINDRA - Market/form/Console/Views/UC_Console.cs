using LINDRA___Market.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINDRA___Market.form.Console.Views
{
    public partial class UC_Console : UserControl
    {
        public UC_Console()
        {
            InitializeComponent();
        }
        private string configPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\configs";

        private void UC_Console_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            textBoxEntry.FillColor = AppColors.backgroundColor;
            textBoxEntry.ForeColor = AppColors.textColor; 
            buttonClear.FillColor = AppColors.secondaryColor;
            buttonClear.ForeColor = AppColors.textColor;
            buttonSend.FillColor = AppColors.primaryColor;
            buttonSend.ForeColor = AppColors.textColor;
            buttonLoad.FillColor = AppColors.primaryColor;
            buttonLoad.ForeColor = AppColors.textColor;
            buttonSave.FillColor = AppColors.primaryColor;
            buttonSave.ForeColor = AppColors.textColor;
            labelConfigName.ForeColor = AppColors.textColor;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = String.Empty;
            labelConfigName.Text = "Configs :";
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                buttonSave.PerformClick();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ExternalConsole.Send($"{textBoxEntry.Text};");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DoesDirectoryExist();
            openFileDialogConfig.InitialDirectory = configPath;
            openFileDialogConfig.FileName = String.Empty;
            if (openFileDialogConfig.ShowDialog() == DialogResult.OK)
            {
                LoadConfigFile(openFileDialogConfig.FileNames);
            }
        }

        void LoadConfigFile(string[] filenames)
        {
            foreach (string file in filenames)
            {
                labelConfigName.Text += $" {Path.GetFileName(file)}";
                textBoxEntry.Text += File.ReadAllText(file);
                textBoxEntry.Text += Environment.NewLine;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxEntry.Text.Trim() != String.Empty)
            {
                DoesDirectoryExist();
                saveFileDialogConfig.InitialDirectory = configPath;
                openFileDialogConfig.FileName = String.Empty;
                if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialogConfig.FileName, textBoxEntry.Text);
                    MessageBox.Show($"Successfully saved file {saveFileDialogConfig.FileName}", "Saving file completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DoesDirectoryExist()
        {
            if (!Directory.Exists(configPath))
                Directory.CreateDirectory(configPath);
        }
    }
}

