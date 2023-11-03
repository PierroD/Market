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
    public partial class UC_SearchResult : UserControl
    {
        public UC_SearchResult()
        {
            InitializeComponent();
        }
        public string dvarName { get; set; }
        public string dvarDescription { get; set; }

        private void UC_SearchResult_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            labelDescription.ForeColor = AppColors.textColor;
            labelName.ForeColor = AppColors.textColor;
            buttonCopy.ForeColor = AppColors.textColor;
            buttonCopy.FillColor = AppColors.primaryColor;

            labelName.Text = dvarName;
            labelDescription.Text = dvarDescription;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dvarName);
            Notify($"The following dvar {Environment.NewLine + dvarName} has been copied to the clipboard", "Market", "Copied dvar to the clipboard");
        }
        #region Notify
        /// <summary>
        /// Notify Icon, to inform the user
        /// </summary>
        /// <param name="tipText"></param>
        /// <param name="mainText"></param>
        /// <param name="tipTitle"></param>
        void Notify(string tipText, string mainText, string tipTitle)
        {
            notifyIconResult.BalloonTipText = tipText;
            notifyIconResult.Text = mainText;
            notifyIconResult.BalloonTipTitle = tipTitle;
            notifyIconResult.Visible = true;
            notifyIconResult.ShowBalloonTip(1000, tipTitle, tipText, ToolTipIcon.Info);
            notifyIconResult.Visible = false;
        }
        #endregion
    }
}
