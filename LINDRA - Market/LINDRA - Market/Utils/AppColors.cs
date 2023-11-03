using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using Markdig.Syntax.Inlines;

namespace LINDRA___Market.Utils
{
    static class AppColors
    {       
        public static Color textColor
        {
            get { return (AppSettings.isDarkMode) ? DarkMode.text : LightMode.text; }
        }
        public static Color backgroundColor
        {
            get { return (AppSettings.isDarkMode) ? DarkMode.background : LightMode.background; }
        }   
        public static Color backgroundTransparencyColor
        {
            get { return (AppSettings.isDarkMode) ? DarkMode.backgroundTransparency : LightMode.backgroundTransparency; }
        }
        public static Color primaryColor
        {
            get { return (AppSettings.isDarkMode) ? DarkMode.primary : LightMode.primary; }
        }
        public static Color secondaryColor
        {
            get { return (AppSettings.isDarkMode) ? DarkMode.secondary : LightMode.secondary; }
        }

        public static Bitmap getImage(string name)
        {
            return (Bitmap)Properties.Resources.ResourceManager.GetObject($"{name}{((AppSettings.isDarkMode) ? "Dark" : "Light")}");
        }
    }

    static class LightMode 
    {
        public static Color text { get; } = Color.FromArgb(19, 6, 14);
        public static Color background { get; } = Color.FromArgb(255, 255, 255);
        public static Color backgroundTransparency { get; } = Color.FromArgb(10, 0, 0, 0);

        public static Color primary { get; } = Color.FromArgb(181, 227, 233);
        public static Color secondary { get; } = Color.FromArgb(230, 168, 205);
        public static Color accent { get; } = Color.FromArgb(174, 55, 127);
    }
    static class DarkMode 
    {
        public static Color text { get; } = Color.FromArgb(249, 236, 244);
        public static Color background { get; } = Color.FromArgb(0, 0, 0);
        public static Color backgroundTransparency { get; } = Color.FromArgb(14, 255, 255, 255);
        public static Color primary { get; } = Color.FromArgb(22, 69, 75);
        public static Color secondary { get; } = Color.FromArgb(87, 25, 62);
        public static Color accent { get; } = Color.FromArgb(200, 81, 152);
    }
}
