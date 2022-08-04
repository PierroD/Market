using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LINDRA___Market.Utils
{
    static class FormColors
    {

        private static Color bgPrimaryColor = Color.FromArgb(217, 247, 250);
        private static Color bgSecondaryColor = Color.FromArgb(28, 40, 38);
        private static Color gmColor = Color.FromArgb(87, 204, 153);
        public static Color backgroundPrimaryColor
        {
            get { return bgPrimaryColor; }
            set { bgPrimaryColor = value; }
        }
        public static Color backgroundSecondaryColor
        {
            get { return bgSecondaryColor; }
            set { bgSecondaryColor = value; }
        }
        public static Color gameColor
        {
            get { return gmColor; }
            set { gmColor = value; }
        }
    }
}
