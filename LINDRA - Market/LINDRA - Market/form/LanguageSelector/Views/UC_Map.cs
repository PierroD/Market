using LINDRA___Market.Utils;
using Newtonsoft.Json;
using PLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINDRA___Market.form.LanguageSelector.Views
{
    public partial class UC_Map : UserControl
    {
        public UC_Map()
        {
            InitializeComponent();
        }

        public delegate void MapDetailsSelectedEventHandler(object sender, MapDetails mapDetails);
        public event MapDetailsSelectedEventHandler MapDetailsSelected;

        protected virtual void OnMapDetailsSelectedd(MapDetails mapDetails)
        {
            MapDetailsSelected?.Invoke(this, mapDetails);
        }

        public string directory { get; set; }
        public string[] directoryFiles { get; set; }
        public string workshopJsonPath { get; set; }

        public string title { get; set; }

        private WorkshopJson workshopJson { get; set; }
        private string publisherId { get; set; }
        private string technicalFileName { get; set; }

        private void UC_Map_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            labelDescription.ForeColor = AppColors.textColor;
            labelName.ForeColor = AppColors.textColor;
            buttonView.ForeColor = AppColors.textColor;
            buttonView.FillColor = AppColors.secondaryColor;

            this.workshopJson = LoadDataFromJson();
            labelName.Text = workshopJson.Title;
            labelDescription.Text = workshopJson.Description;

            this.publisherId = workshopJson.PublisherID;
            this.technicalFileName = workshopJson.FolderName;
            this.title = workshopJson.Title;

            LoadImage();
        }

        private WorkshopJson LoadDataFromJson()
        {
            if (!File.Exists(workshopJsonPath))
            {
                Log.Infos("Workshop map doesn't exists", workshopJsonPath);
                return new WorkshopJson();
            }
            WorkshopJson workshopJson = JsonConvert.DeserializeObject<WorkshopJson>(File.ReadAllText(workshopJsonPath));
            if (workshopJson == null)
            {
                Log.Error("Error during the json deserialization", workshopJsonPath);
                return new WorkshopJson();

            }
            return workshopJson;
        }

        private void LoadImage()
        {
            List<string> imagesPath = directoryFiles.ToList().FindAll(df => df.Contains("previewimage.png") || df.Contains("thumnail.png"));
            if (imagesPath.Count > 0)
            {
                pictureBoxPreview.Image = Image.FromFile(imagesPath[0]);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            MapDetails mapDetails = new MapDetails
            {
                workshopJson = workshopJson,
                directory = directory,
                directoryFiles = directoryFiles,
            };
            OnMapDetailsSelectedd(mapDetails);
        }
    }
}
