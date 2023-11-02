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
    public partial class UC_Search : UserControl
    {
        public UC_Search()
        {
            InitializeComponent();
        }

        private void UC_Search_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            textBoxSearch.FillColor = AppColors.backgroundColor;
            textBoxSearch.ForeColor = AppColors.textColor;
            textBoxSearch.BorderColor = AppColors.textColor;
            buttonClear.FillColor = AppColors.secondaryColor;
            buttonClear.ForeColor = AppColors.textColor;
            listViewResults.BackColor = AppColors.backgroundColor;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSearch.Text.Trim() != String.Empty) {
                buttonClear.Visible = true;
            }
        }

    }
}
