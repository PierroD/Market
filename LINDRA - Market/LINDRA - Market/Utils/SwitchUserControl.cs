using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SwitchUserControl
{
    public static class SwitchUserControl
    {
        public static void Switch(Panel pnl, UserControl uc)
        {
            if (!pnl.Controls.Contains(uc))
            {
                pnl.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }
    }
}

