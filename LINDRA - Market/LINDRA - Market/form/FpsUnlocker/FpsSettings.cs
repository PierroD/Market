using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LINDRA___Market.form
{
    public class FpsSettings
    {
        public static int bar_fov { get; set; } = 65;

        public static int bar_fovScale { get; set; } = 1000;
        public static int bar_fps { get; set; } = 90;
        public static int specularmap { get; set; } = 1;
        public static int lightmap { get; set; } = 1;
        public static bool sw_movie { get; set; } = false;
        public static bool sw_fog { get; set; } = false;
        public static bool sw_glow { get; set; } = false;
        public static bool sw_camos { get; set; } = false;
        public static bool sw_bullet { get; set; } = false;

        public static Color allies_feed { get; set; } = Color.FromArgb(153, 163, 176);
        public static Color axis_feed { get; set; } = Color.FromArgb(166, 145, 105); //"0.64999998 0.56999999 0.41";
    }

}
