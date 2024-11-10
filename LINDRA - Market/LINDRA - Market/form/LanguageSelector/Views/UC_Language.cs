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

namespace LINDRA___Market.form.LanguageSelector.Views
{
    public partial class UC_Language : UserControl
    {
        public UC_Language()
        {
            InitializeComponent();
        }

        public Language language { get; set; }

        private void UC_Language_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.secondaryColor;
            labelAvailableLanguages.ForeColor = AppColors.textColor;
            labelAvailableLanguages.Text = language.name;

        }
    }
}
