namespace LINDRA___Market.form.Console.Views
{
    partial class UC_Search
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonClear = new Guna.UI2.WinForms.Guna2Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(423, 36);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BorderRadius = 8;
            this.buttonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(429, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(38, 36);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "✕";
            this.buttonClear.Visible = false;
            // 
            // listViewResults
            // 
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(3, 45);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(464, 255);
            this.listViewResults.TabIndex = 2;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(470, 320);
            this.Load += new System.EventHandler(this.UC_Search_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private System.Windows.Forms.ListView listViewResults;
    }
}
