namespace LINDRA___Market.form.LanguageSelector.Views
{
    partial class UC_MapDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MapDetails));
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAvailableLanguages = new System.Windows.Forms.Label();
            this.buttonAddLanguage = new Guna.UI2.WinForms.Guna2Button();
            this.comboboxLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelOtherData = new System.Windows.Forms.Label();
            this.labelPublisherId = new System.Windows.Forms.Label();
            this.labelTags = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIconResult = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 172);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(442, 21);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescription.DefaultText = "";
            this.textBoxDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDescription.Location = new System.Drawing.Point(6, 196);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.PlaceholderText = "Map Description";
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.Size = new System.Drawing.Size(439, 99);
            this.textBoxDescription.TabIndex = 5;
            // 
            // labelAvailableLanguages
            // 
            this.labelAvailableLanguages.AutoSize = true;
            this.labelAvailableLanguages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableLanguages.Location = new System.Drawing.Point(9, 300);
            this.labelAvailableLanguages.Name = "labelAvailableLanguages";
            this.labelAvailableLanguages.Size = new System.Drawing.Size(135, 17);
            this.labelAvailableLanguages.TabIndex = 6;
            this.labelAvailableLanguages.Text = "Available Languages";
            // 
            // buttonAddLanguage
            // 
            this.buttonAddLanguage.BorderRadius = 8;
            this.buttonAddLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddLanguage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddLanguage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddLanguage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddLanguage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddLanguage.ForeColor = System.Drawing.Color.White;
            this.buttonAddLanguage.Location = new System.Drawing.Point(222, 410);
            this.buttonAddLanguage.Name = "buttonAddLanguage";
            this.buttonAddLanguage.Size = new System.Drawing.Size(65, 35);
            this.buttonAddLanguage.TabIndex = 18;
            this.buttonAddLanguage.Text = "Add";
            this.buttonAddLanguage.Click += new System.EventHandler(this.buttonAddLanguage_Click);
            // 
            // comboboxLanguage
            // 
            this.comboboxLanguage.BackColor = System.Drawing.Color.Transparent;
            this.comboboxLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxLanguage.ItemHeight = 30;
            this.comboboxLanguage.Location = new System.Drawing.Point(12, 409);
            this.comboboxLanguage.Name = "comboboxLanguage";
            this.comboboxLanguage.Size = new System.Drawing.Size(204, 36);
            this.comboboxLanguage.TabIndex = 17;
            // 
            // labelOtherData
            // 
            this.labelOtherData.AutoSize = true;
            this.labelOtherData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherData.Location = new System.Drawing.Point(9, 458);
            this.labelOtherData.Name = "labelOtherData";
            this.labelOtherData.Size = new System.Drawing.Size(76, 17);
            this.labelOtherData.TabIndex = 19;
            this.labelOtherData.Text = "Other Data";
            // 
            // labelPublisherId
            // 
            this.labelPublisherId.AutoSize = true;
            this.labelPublisherId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisherId.Location = new System.Drawing.Point(10, 495);
            this.labelPublisherId.Name = "labelPublisherId";
            this.labelPublisherId.Size = new System.Drawing.Size(65, 13);
            this.labelPublisherId.TabIndex = 20;
            this.labelPublisherId.Text = "PublisherId";
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTags.Location = new System.Drawing.Point(10, 525);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(30, 13);
            this.labelTags.TabIndex = 21;
            this.labelTags.Text = "Tags";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(10, 555);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(30, 13);
            this.labelType.TabIndex = 22;
            this.labelType.Text = "Type";
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolderName.Location = new System.Drawing.Point(10, 585);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(69, 13);
            this.labelFolderName.TabIndex = 23;
            this.labelFolderName.Text = "FolderName";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPreview.BorderRadius = 12;
            this.pictureBoxPreview.ImageRotate = 0F;
            this.pictureBoxPreview.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(442, 168);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.UseTransparentBackground = true;
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 330);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(442, 73);
            this.flowLayoutPanelResults.TabIndex = 24;
            this.flowLayoutPanelResults.WrapContents = false;
            // 
            // notifyIconResult
            // 
            this.notifyIconResult.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconResult.BalloonTipTitle = "Copied dvar to the clipboard";
            this.notifyIconResult.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconResult.Icon")));
            this.notifyIconResult.Text = "Market";
            this.notifyIconResult.Visible = true;
            // 
            // UC_MapDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.labelPublisherId);
            this.Controls.Add(this.labelOtherData);
            this.Controls.Add(this.buttonAddLanguage);
            this.Controls.Add(this.comboboxLanguage);
            this.Controls.Add(this.labelAvailableLanguages);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "UC_MapDetails";
            this.Size = new System.Drawing.Size(460, 609);
            this.Load += new System.EventHandler(this.UC_MapDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDescription;
        private System.Windows.Forms.Label labelAvailableLanguages;
        private Guna.UI2.WinForms.Guna2Button buttonAddLanguage;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxLanguage;
        private System.Windows.Forms.Label labelOtherData;
        private System.Windows.Forms.Label labelPublisherId;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private System.Windows.Forms.NotifyIcon notifyIconResult;
    }
}
