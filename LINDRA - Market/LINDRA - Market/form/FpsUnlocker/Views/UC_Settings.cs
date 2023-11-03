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

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            buttonLoad.FillColor = AppColors.primaryColor;
            buttonLoad.ForeColor = AppColors.textColor;
            buttonSave.FillColor = AppColors.primaryColor;
            buttonSave.ForeColor = AppColors.textColor;
            labelLoad.ForeColor = AppColors.textColor;
            labelSave.ForeColor = AppColors.textColor;
            comboboxLoad.FillColor = AppColors.backgroundColor;
            comboboxLoad.ForeColor = AppColors.textColor;
            textboxSave.FillColor = AppColors.backgroundColor;
            textboxSave.ForeColor = AppColors.textColor; 
        }

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
                FpsSettings.bar_fov = (int.Parse(ini.IniReadValue("Fov&fps", "FieldOfView")));
                FpsSettings.bar_fps = (int.Parse(ini.IniReadValue("Fov&fps", "Max_FPS")));
                FpsSettings.lightmap = (int.Parse(ini.IniReadValue("Visuals", "LightMap")));
                FpsSettings.specularmap = (int.Parse(ini.IniReadValue("Visuals", "SpecularMap")));
                FpsSettings.sw_movie = (bool.Parse(ini.IniReadValue("Visuals", "Movie")));
                FpsSettings.sw_fog = (bool.Parse(ini.IniReadValue("Disable", "NoFog")));
                FpsSettings.sw_glow = (bool.Parse(ini.IniReadValue("Disable", "NoGlow")));
                FpsSettings.sw_bullet = (bool.Parse(ini.IniReadValue("Disable", "NoBullet")));
                FpsSettings.sw_camos = (bool.Parse(ini.IniReadValue("Disable", "NoSkins")));
                FpsSettings.allies_feed = (Color.FromArgb(int.Parse(ini.IniReadValue("Feed", "Allies"))));
                FpsSettings.axis_feed = (Color.FromArgb(int.Parse(ini.IniReadValue("Feed", "Axis"))));
                try
                {
                    FpsSettings.bar_fovScale = (int.Parse(ini.IniReadValue("Fov&fps", "FovScale")));
                }
                catch { }
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
                    sw.WriteLine("FieldOfView=" + FpsSettings.bar_fov);
                    sw.WriteLine("FovScale=" + FpsSettings.bar_fovScale);
                    sw.WriteLine("Max_FPS=" + FpsSettings.bar_fps);
                    sw.WriteLine("[VISUALS]");
                    sw.WriteLine("LightMap=" + FpsSettings.lightmap);
                    sw.WriteLine("SpecularMap=" + FpsSettings.specularmap);
                    sw.WriteLine("Movie=" + FpsSettings.sw_movie);
                    sw.WriteLine("[DISABLE]");
                    sw.WriteLine("NoFog=" + FpsSettings.sw_fog);
                    sw.WriteLine("NoGlow=" + FpsSettings.sw_glow);
                    sw.WriteLine("NoBullet=" + FpsSettings.sw_bullet);
                    sw.WriteLine("NoSkins=" + FpsSettings.sw_bullet);
                    sw.WriteLine("[FEED]");
                    sw.WriteLine("Allies=" + FpsSettings.allies_feed.ToArgb());
                    sw.WriteLine("Axis=" + FpsSettings.axis_feed.ToArgb());

                    MessageBox.Show("Your config named : " + textboxSave.Text + " has been successfully saved", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verify the name of your config", "WRONG Name !" + "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
