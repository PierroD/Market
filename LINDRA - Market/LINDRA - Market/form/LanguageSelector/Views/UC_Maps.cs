using LINDRA___Market.Utils;
using PLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINDRA___Market.form.LanguageSelector.Views
{
    public partial class UC_Maps : UserControl
    {
        List<UC_Map> maps = new List<UC_Map>();
        private int directoriesCount = 0;
        public UC_Maps()
        {
            InitializeComponent();
        }

        public delegate void MapDetailsSelectedEventHandler(object sender, MapDetails mapDetails);
        public event MapDetailsSelectedEventHandler MapDetailsSelected;

        protected virtual void OnMapDetailsSelected(MapDetails mapDetails)
        {
            MapDetailsSelected?.Invoke(this, mapDetails);
        }

        private void UC_Maps_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            textBoxSearch.FillColor = AppColors.backgroundColor;
            textBoxSearch.ForeColor = AppColors.textColor;
            textBoxSearch.BorderColor = AppColors.textColor;
            buttonClear.FillColor = AppColors.secondaryColor;
            buttonClear.ForeColor = AppColors.textColor;

            LoadMaps();
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            buttonClear.Visible = textBoxSearch.Text.Trim() != String.Empty;
            DisplayMaps(this.maps);
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBoxSearch.Text != String.Empty && maps.Count() > 0)
                {
                    List<UC_Map> mapsFound = new List<UC_Map>();
                    mapsFound = this.maps.FindAll(map => map.title.ToLower().Contains(textBoxSearch.Text.ToLower()));
                    DisplayMaps(mapsFound);
                }
                else
                {
                    DisplayMaps(this.maps);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void LoadMaps()
        {
            if (!Directory.Exists(LanguageSelectorSettings.folderPath))
            {
                Log.Infos("Couldn't find workshop folder path", LanguageSelectorSettings.folderPath);
                MessageBox.Show($"Your steam workshop folder isn't set yet \n Please, go to the settings and set the path of your steam folder.", "Set your workshop folder path first", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.maps = new List<UC_Map>();

            string[] directories = Directory.GetDirectories(LanguageSelectorSettings.folderPath);

            if (directories.Length < 0)
            {
                Log.Infos("Workshop directory is detected as empty");
                return;
            }

            directoriesCount = directories.Length;

            foreach (string directory in directories)
            {
                if (!Directory.Exists(directory))
                {
                    Log.Infos("Directory doesn't exists", directory);
                    continue;
                }
                string[] directoryFiles = Directory.GetFiles(directory);
                if (directoryFiles.Length == 0)
                {
                    Log.Infos("The directory is empty", directory);
                    continue;
                }
                try
                {
                    string workshopJsonPath = directoryFiles.First(df => df.Contains(".json"));
                    UC_Map map = new UC_Map
                    {
                        directory = directory,
                        directoryFiles = directoryFiles,
                        workshopJsonPath = workshopJsonPath,
                    };
                    map.MapDetailsSelected += MapDetailsSelectedEvent;
                    this.maps.Add(map);
                }
                catch (Exception ex)
                {
                    Log.Infos("Couldn't find workshop.json file", directory);
                    continue;
                }
            }
            DisplayMaps(maps);
        }

        private void MapDetailsSelectedEvent(object sender, MapDetails mapDetails)
        {
            OnMapDetailsSelected(mapDetails); // Bubble up the event
        }

        private void DisplayMaps(List<UC_Map> maps)
        {
            flowLayoutPanelResults.Controls.Clear();
            flowLayoutPanelResults.SuspendLayout();
            flowLayoutPanelResults.Controls.AddRange(maps.ToArray());
            flowLayoutPanelResults.ResumeLayout();
            this.ResumeLayout();
            labelResults.Text = $"Results : {maps.Count()}/{this.directoriesCount}";

        }

    }
}
