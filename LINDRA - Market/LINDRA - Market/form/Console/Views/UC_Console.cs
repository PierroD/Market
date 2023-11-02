using LINDRA___Market.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void UC_Console_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            textBoxEntry.FillColor = AppColors.backgroundColor;
            buttonClear.FillColor = AppColors.secondaryColor;
            buttonClear.ForeColor = AppColors.textColor;
            buttonSend.FillColor = AppColors.primaryColor;
            buttonSend.ForeColor = AppColors.textColor;
            buttonLoad.FillColor = AppColors.primaryColor;
            buttonLoad.ForeColor = AppColors.textColor;
            buttonBindMacro.FillColor = AppColors.primaryColor;
            buttonBindMacro.ForeColor = AppColors.textColor;
            buttonSave.FillColor = AppColors.primaryColor;
            buttonSave.ForeColor = AppColors.textColor;
            textBoxName.FillColor = AppColors.backgroundColor;
            comboBoxMacro.FillColor = AppColors.backgroundColor;
            comboBoxMacro.ForeColor = AppColors.textColor;
            labelMacro.ForeColor = AppColors.textColor;
            separator.FillColor= AppColors.textColor;

        }
    }
}
