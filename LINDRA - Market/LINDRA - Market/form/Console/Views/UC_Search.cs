using Guna.UI2.WinForms.Suite;
using LINDRA___Market.Utils;
using Newtonsoft.Json;
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

namespace LINDRA___Market.form.Console.Views
{
    public partial class UC_Search : UserControl
    {
        public UC_Search()
        {
            InitializeComponent();
        }

        private string dvarPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\dvars";
        private DVARList DvarLists;

        #region DVARList classes
        public class DVARList
        {
            public List<Game> games { get; set; }
        }

        public class Game
        {
            public string gameName { get; set; }
            public List<Command> commands { get; set; }
        }
        public class Command
        {
            public string content { get; set; }
            public string description { get; set; }

        }
        #endregion

        private void UC_Search_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.backgroundColor;
            textBoxSearch.FillColor = AppColors.backgroundColor;
            textBoxSearch.ForeColor = AppColors.textColor;
            textBoxSearch.BorderColor = AppColors.textColor;
            buttonClear.FillColor = AppColors.secondaryColor;
            buttonClear.ForeColor = AppColors.textColor;
            flowLayoutPanelResults.BackColor = AppColors.backgroundColor;
            labelDvarList.ForeColor = AppColors.textColor;
            labelResults.ForeColor = AppColors.textColor;
            comboBoxDvarList.ForeColor = AppColors.textColor;
            comboBoxDvarList.FillColor = AppColors.backgroundColor;
            LoadSelectedDvarList();
            DvarLists = LoadDvarLists();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            buttonClear.Visible = textBoxSearch.Text.Trim() != String.Empty;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (comboBoxDvarList.Text != String.Empty && textBoxSearch.Text != String.Empty)
                    SearchDvars(textBoxSearch.Text);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }


        #region LoadDvarLists
        private DVARList LoadDvarLists()
        {
            string[] folders = Directory.GetDirectories(dvarPath);
            DVARList dvarList = new DVARList();
            foreach (string folderPath in folders)
            {
                Game game = new Game();
                game.gameName = Path.GetFileNameWithoutExtension(folderPath); ;
                string[] files = Directory.GetFiles(folderPath, "*.json");
                foreach (string filePath in files)
                {
                    var commands = JsonConvert.DeserializeObject<List<Command>>(File.ReadAllText(filePath));
                    if (game.commands != null)
                        game.commands.Concat(commands);
                    else
                        game.commands = commands.ToList();
                }
                if (dvarList.games == null)
                    dvarList.games = new List<Game>();

                dvarList.games.Add(game);
            }
            return dvarList;
        }
        #endregion

        #region LoadSelectedDvarList
        void LoadSelectedDvarList()
        {
            string[] games = Directory.GetDirectories(dvarPath);
            foreach (string game in games)
            {
                comboBoxDvarList.Items.Add(new DirectoryInfo(game).Name);
            }
            if (games.Count() > 0)
                comboBoxDvarList.SelectedIndex = 0;
        }
        #endregion

        #region SearchDvars
        async void SearchDvars(string dvar)
        {
            flowLayoutPanelResults.Controls.Clear();
            Game game = DvarLists.games.Where(g => g.gameName == comboBoxDvarList.Text).FirstOrDefault();
            List<Command> commands = game.commands.Where(c => c.content.Contains(dvar) || c.description.Contains(dvar)).ToList();
            List<UC_SearchResult> searchResult = new List<UC_SearchResult>();
            await Task.Run(() =>
            {
                foreach (Command command in commands)
                {
                    searchResult.Add(new UC_SearchResult
                    {
                        dvarName = command.content,
                        dvarDescription = command.description
                    });
                }
            });
            flowLayoutPanelResults.SuspendLayout();
            flowLayoutPanelResults.Controls.AddRange(searchResult.ToArray());
            flowLayoutPanelResults.ResumeLayout();
            this.ResumeLayout();
            labelResults.Text = $"Results : {commands.Count()}/{game.commands.Count()}";
        }
        #endregion

    }
}
