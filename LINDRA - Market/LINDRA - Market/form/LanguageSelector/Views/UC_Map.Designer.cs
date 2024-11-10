namespace LINDRA___Market.form.LanguageSelector.Views
{
    partial class UC_Map
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
            this.buttonView = new Guna.UI2.WinForms.Guna2Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.BorderRadius = 8;
            this.buttonView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(357, 23);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(65, 35);
            this.buttonView.TabIndex = 5;
            this.buttonView.Text = "View";
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(96, 27);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(255, 43);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(99, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(252, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPreview.BorderRadius = 12;
            this.pictureBoxPreview.ImageRotate = 0F;
            this.pictureBoxPreview.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(87, 74);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 6;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.UseTransparentBackground = true;
            // 
            // UC_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Name = "UC_Map";
            this.Size = new System.Drawing.Size(430, 80);
            this.Load += new System.EventHandler(this.UC_Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonView;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPreview;
    }
}
