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
using PLogger;

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
            Log.setFunctionPassedThrough();
            Log.Infos("Clear configs");
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
            Log.setFunctionPassedThrough();
            Log.Infos("Sent through the console :", $"{textBoxEntry.Text};");
            ExternalConsole.Send($"{textBoxEntry.Text};");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DoesDirectoryExist();
            openFileDialogConfig.InitialDirectory = configPath;
            openFileDialogConfig.FileName = String.Empty;
            if (openFileDialogConfig.ShowDialog() == DialogResult.OK)
            {
                Log.setFunctionPassedThrough();
                Log.Infos("Open files :", String.Join(",", openFileDialogConfig.FileNames));
                LoadConfigFile(openFileDialogConfig.FileNames);
            }
        }

        void LoadConfigFile(string[] filenames)
        {
            Log.setFunctionPassedThrough();
            foreach (string file in filenames)
            {
                Log.Infos("Load config file :", file);
                labelConfigName.Text += $" {Path.GetFileName(file)}";
                textBoxEntry.Text += File.ReadAllText(file);
                textBoxEntry.Text += Environment.NewLine;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxEntry.Text.Trim() != String.Empty)
            {
                Log.setFunctionPassedThrough();
                DoesDirectoryExist();
                saveFileDialogConfig.InitialDirectory = configPath;
                openFileDialogConfig.FileName = String.Empty;
                if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialogConfig.FileName, textBoxEntry.Text);
                    Log.Infos("Save config file :", saveFileDialogConfig.FileName);
                    MessageBox.Show($"Successfully saved file {saveFileDialogConfig.FileName}", "Saving file completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DoesDirectoryExist()
        {
            Log.setFunctionPassedThrough();
            Log.Infos("DoesDirectoryExist :", Directory.Exists(configPath));
            if (!Directory.Exists(configPath))
                Directory.CreateDirectory(configPath);
        }
    }
}

