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
using LINDRA___Market.Utils;

namespace LINDRA___Market.form.Views
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }
        private static string config_folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\configs\\";

        private void comboboxLoad_Click(object sender, EventArgs e)
        {
            comboboxLoad.Items.Clear();
            if (Directory.Exists(config_folder))
            {
                IEnumerable<string> configFiles = Directory.GetFiles(config_folder).Where(s => s.ToLower().Contains(".ini")); ;
                foreach (string file in configFiles)
                {
                    comboboxLoad.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            else
                Directory.CreateDirectory(config_folder);

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (comboboxLoad.Text != String.Empty)
            {
                string configFileLoad = config_folder + comboboxLoad.Text + ".ini";
                INIFile ini = new INIFile(configFileLoad); // set this file as a new ini file
                fps_settings.bar_fov = (int.Parse(ini.IniReadValue("Fov&fps", "FieldOfView")));
                fps_settings.bar_fps = (int.Parse(ini.IniReadValue("Fov&fps", "Max_FPS")));
                fps_settings.lightmap = (int.Parse(ini.IniReadValue("Visuals", "LightMap")));
                fps_settings.specularmap = (int.Parse(ini.IniReadValue("Visuals", "SpecularMap")));
                fps_settings.sw_movie = (bool.Parse(ini.IniReadValue("Visuals", "Movie")));
                fps_settings.sw_fog = (bool.Parse(ini.IniReadValue("Disable", "NoFog")));
                fps_settings.sw_glow = (bool.Parse(ini.IniReadValue("Disable", "NoGlow")));
                fps_settings.sw_bullet = (bool.Parse(ini.IniReadValue("Disable", "NoBullet")));
                fps_settings.sw_camos = (bool.Parse(ini.IniReadValue("Disable", "NoSkins")));
                fps_settings.allies_feed = (Color.FromArgb(int.Parse(ini.IniReadValue("Feed", "Allies"))));
                fps_settings.axis_feed = (Color.FromArgb(int.Parse(ini.IniReadValue("Feed", "Axis"))));
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(config_folder))
                Directory.CreateDirectory(config_folder);

            if ((textboxSave.Text.Length != 0 && !(textboxSave.Text.Contains("config name"))))
            {
                string filename = config_folder + textboxSave.Text + ".ini";
                File.Delete(filename);
                using (StreamWriter sw = (File.Exists(filename)) ? File.AppendText(filename) : File.CreateText(filename))
                {
                    sw.WriteLine("[FOV&FPS]");
                    sw.WriteLine("FieldOfView=" + fps_settings.bar_fov);
                    sw.WriteLine("Max_FPS=" + fps_settings.bar_fps);
                    sw.WriteLine("[VISUALS]");
                    sw.WriteLine("LightMap=" + fps_settings.lightmap);
                    sw.WriteLine("SpecularMap=" + fps_settings.specularmap);
                    sw.WriteLine("Movie=" + fps_settings.sw_movie);
                    sw.WriteLine("[DISABLE]");
                    sw.WriteLine("NoFog=" + fps_settings.sw_fog);
                    sw.WriteLine("NoGlow=" + fps_settings.sw_glow);
                    sw.WriteLine("NoBullet=" + fps_settings.sw_bullet);
                    sw.WriteLine("NoSkins=" + fps_settings.sw_bullet);
                    sw.WriteLine("[FEED]");
                    sw.WriteLine("Allies=" + fps_settings.allies_feed.ToArgb());
                    sw.WriteLine("Axis=" + fps_settings.axis_feed.ToArgb());

                    MessageBox.Show("Your config named : " + textboxSave.Text + " has been successfully saved", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verify the name of your config", "WRONG Name !" + "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            buttonLoad.FillColor = FormColors.gameColor;
            buttonSave.FillColor = FormColors.gameColor;
            
        }
    }
}
