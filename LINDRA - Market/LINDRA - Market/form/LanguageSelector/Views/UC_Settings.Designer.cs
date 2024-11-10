namespace LINDRA___Market.form.LanguageSelector.Views
{
    partial class UC_Settings
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
            this.textBoxFolderPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonSelectFolderPath = new Guna.UI2.WinForms.Guna2Button();
            this.labelFavoriteLanguage = new System.Windows.Forms.Label();
            this.comboboxFavoriteLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonSetFavoriteLanguage = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFolderPath.DefaultText = "";
            this.textBoxFolderPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFolderPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFolderPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFolderPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFolderPath.Enabled = false;
            this.textBoxFolderPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxFolderPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFolderPath.Location = new System.Drawing.Point(23, 16);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.PasswordChar = '\0';
            this.textBoxFolderPath.PlaceholderText = "Workshop folder path ...";
            this.textBoxFolderPath.SelectedText = "";
            this.textBoxFolderPath.Size = new System.Drawing.Size(359, 36);
            this.textBoxFolderPath.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(23, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(359, 43);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "You have to set the following folder :\r\nSteam > steamapps > workshop > content > " +
    "311210\r\n";
            // 
            // buttonSelectFolderPath
            // 
            this.buttonSelectFolderPath.BorderRadius = 8;
            this.buttonSelectFolderPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectFolderPath.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSelectFolderPath.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSelectFolderPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSelectFolderPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSelectFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSelectFolderPath.ForeColor = System.Drawing.Color.White;
            this.buttonSelectFolderPath.Location = new System.Drawing.Point(388, 16);
            this.buttonSelectFolderPath.Name = "buttonSelectFolderPath";
            this.buttonSelectFolderPath.Size = new System.Drawing.Size(65, 35);
            this.buttonSelectFolderPath.TabIndex = 6;
            this.buttonSelectFolderPath.Text = "Select";
            this.buttonSelectFolderPath.Click += new System.EventHandler(this.buttonSelectFolderPath_Click);
            // 
            // labelFavoriteLanguage
            // 
            this.labelFavoriteLanguage.AutoSize = true;
            this.labelFavoriteLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFavoriteLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFavoriteLanguage.Location = new System.Drawing.Point(31, 115);
            this.labelFavoriteLanguage.Name = "labelFavoriteLanguage";
            this.labelFavoriteLanguage.Size = new System.Drawing.Size(172, 17);
            this.labelFavoriteLanguage.TabIndex = 15;
            this.labelFavoriteLanguage.Text = "Set your favorite language";
            // 
            // comboboxFavoriteLanguage
            // 
            this.comboboxFavoriteLanguage.BackColor = System.Drawing.Color.Transparent;
            this.comboboxFavoriteLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxFavoriteLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxFavoriteLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxFavoriteLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxFavoriteLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxFavoriteLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxFavoriteLanguage.ItemHeight = 30;
            this.comboboxFavoriteLanguage.Location = new System.Drawing.Point(26, 139);
            this.comboboxFavoriteLanguage.Name = "comboboxFavoriteLanguage";
            this.comboboxFavoriteLanguage.Size = new System.Drawing.Size(204, 36);
            this.comboboxFavoriteLanguage.TabIndex = 14;
            this.comboboxFavoriteLanguage.Click += new System.EventHandler(this.comboboxFavoriteLanguage_Click);
            // 
            // buttonSetFavoriteLanguage
            // 
            this.buttonSetFavoriteLanguage.BorderRadius = 8;
            this.buttonSetFavoriteLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetFavoriteLanguage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSetFavoriteLanguage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSetFavoriteLanguage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSetFavoriteLanguage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSetFavoriteLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSetFavoriteLanguage.ForeColor = System.Drawing.Color.White;
            this.buttonSetFavoriteLanguage.Location = new System.Drawing.Point(245, 140);
            this.buttonSetFavoriteLanguage.Name = "buttonSetFavoriteLanguage";
            this.buttonSetFavoriteLanguage.Size = new System.Drawing.Size(65, 35);
            this.buttonSetFavoriteLanguage.TabIndex = 16;
            this.buttonSetFavoriteLanguage.Text = "Set";
            this.buttonSetFavoriteLanguage.Click += new System.EventHandler(this.buttonSetFavoriteLanguage_Click);
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSetFavoriteLanguage);
            this.Controls.Add(this.labelFavoriteLanguage);
            this.Controls.Add(this.comboboxFavoriteLanguage);
            this.Controls.Add(this.buttonSelectFolderPath);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxFolderPath);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(476, 412);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxFolderPath;
        private System.Windows.Forms.Label labelDescription;
        private Guna.UI2.WinForms.Guna2Button buttonSelectFolderPath;
        private System.Windows.Forms.Label labelFavoriteLanguage;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxFavoriteLanguage;
        private Guna.UI2.WinForms.Guna2Button buttonSetFavoriteLanguage;
    }
}
