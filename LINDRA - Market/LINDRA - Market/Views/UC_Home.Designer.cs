namespace LINDRA___Market.Views
{
    partial class UC_Home
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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLanguage = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonLanguage = new Guna.UI2.WinForms.Guna2Button();
            this.labelLanguageDescription = new System.Windows.Forms.Label();
            this.labelLanguageTitle = new System.Windows.Forms.Label();
            this.pictureBoxLanguage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelConsole = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonConsole = new Guna.UI2.WinForms.Guna2Button();
            this.labelConsoleDescription = new System.Windows.Forms.Label();
            this.labelConsoleTitle = new System.Windows.Forms.Label();
            this.pictureBoxConsole = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelFps = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonFpsRun = new Guna.UI2.WinForms.Guna2Button();
            this.labelFpsDescription = new System.Windows.Forms.Label();
            this.labelFpsTitle = new System.Windows.Forms.Label();
            this.pictureBoxFps = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMain.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            this.panelConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsole)).BeginInit();
            this.panelFps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFps)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelLanguage);
            this.panelMain.Controls.Add(this.panelConsole);
            this.panelMain.Controls.Add(this.panelFps);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(680, 403);
            this.panelMain.TabIndex = 3;
            // 
            // panelLanguage
            // 
            this.panelLanguage.BackColor = System.Drawing.Color.Transparent;
            this.panelLanguage.BorderRadius = 12;
            this.panelLanguage.Controls.Add(this.buttonLanguage);
            this.panelLanguage.Controls.Add(this.labelLanguageDescription);
            this.panelLanguage.Controls.Add(this.labelLanguageTitle);
            this.panelLanguage.Controls.Add(this.pictureBoxLanguage);
            this.panelLanguage.FillColor = System.Drawing.Color.Black;
            this.panelLanguage.Location = new System.Drawing.Point(413, 270);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(189, 194);
            this.panelLanguage.TabIndex = 5;
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.BorderRadius = 8;
            this.buttonLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLanguage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLanguage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLanguage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLanguage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLanguage.ForeColor = System.Drawing.Color.White;
            this.buttonLanguage.Location = new System.Drawing.Point(47, 134);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Size = new System.Drawing.Size(103, 42);
            this.buttonLanguage.TabIndex = 4;
            this.buttonLanguage.Text = "Run";
            this.buttonLanguage.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // labelLanguageDescription
            // 
            this.labelLanguageDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguageDescription.ForeColor = System.Drawing.Color.White;
            this.labelLanguageDescription.Location = new System.Drawing.Point(0, 77);
            this.labelLanguageDescription.Name = "labelLanguageDescription";
            this.labelLanguageDescription.Size = new System.Drawing.Size(189, 36);
            this.labelLanguageDescription.TabIndex = 2;
            this.labelLanguageDescription.Text = "Change custom maps language on Black Ops III Zombie ";
            this.labelLanguageDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLanguageTitle
            // 
            this.labelLanguageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguageTitle.ForeColor = System.Drawing.Color.White;
            this.labelLanguageTitle.Location = new System.Drawing.Point(0, 50);
            this.labelLanguageTitle.Name = "labelLanguageTitle";
            this.labelLanguageTitle.Size = new System.Drawing.Size(189, 23);
            this.labelLanguageTitle.TabIndex = 1;
            this.labelLanguageTitle.Text = "Language Selector";
            this.labelLanguageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.ImageRotate = 0F;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxLanguage.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxLanguage.TabIndex = 0;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // panelConsole
            // 
            this.panelConsole.BackColor = System.Drawing.Color.Transparent;
            this.panelConsole.BorderRadius = 12;
            this.panelConsole.Controls.Add(this.buttonConsole);
            this.panelConsole.Controls.Add(this.labelConsoleDescription);
            this.panelConsole.Controls.Add(this.labelConsoleTitle);
            this.panelConsole.Controls.Add(this.pictureBoxConsole);
            this.panelConsole.FillColor = System.Drawing.Color.Black;
            this.panelConsole.Location = new System.Drawing.Point(413, 41);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(189, 194);
            this.panelConsole.TabIndex = 4;
            // 
            // buttonConsole
            // 
            this.buttonConsole.BorderRadius = 8;
            this.buttonConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConsole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConsole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConsole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConsole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsole.ForeColor = System.Drawing.Color.White;
            this.buttonConsole.Location = new System.Drawing.Point(47, 134);
            this.buttonConsole.Name = "buttonConsole";
            this.buttonConsole.Size = new System.Drawing.Size(103, 42);
            this.buttonConsole.TabIndex = 4;
            this.buttonConsole.Text = "Run";
            this.buttonConsole.Click += new System.EventHandler(this.buttonConsole_Click);
            // 
            // labelConsoleDescription
            // 
            this.labelConsoleDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsoleDescription.ForeColor = System.Drawing.Color.White;
            this.labelConsoleDescription.Location = new System.Drawing.Point(0, 77);
            this.labelConsoleDescription.Name = "labelConsoleDescription";
            this.labelConsoleDescription.Size = new System.Drawing.Size(189, 36);
            this.labelConsoleDescription.TabIndex = 2;
            this.labelConsoleDescription.Text = "External Call of Duty console, to unlock some Dvars";
            this.labelConsoleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConsoleTitle
            // 
            this.labelConsoleTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsoleTitle.ForeColor = System.Drawing.Color.White;
            this.labelConsoleTitle.Location = new System.Drawing.Point(0, 50);
            this.labelConsoleTitle.Name = "labelConsoleTitle";
            this.labelConsoleTitle.Size = new System.Drawing.Size(189, 23);
            this.labelConsoleTitle.TabIndex = 1;
            this.labelConsoleTitle.Text = "External Console";
            this.labelConsoleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxConsole
            // 
            this.pictureBoxConsole.ImageRotate = 0F;
            this.pictureBoxConsole.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxConsole.Name = "pictureBoxConsole";
            this.pictureBoxConsole.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxConsole.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxConsole.TabIndex = 0;
            this.pictureBoxConsole.TabStop = false;
            // 
            // panelFps
            // 
            this.panelFps.BackColor = System.Drawing.Color.Transparent;
            this.panelFps.BorderRadius = 12;
            this.panelFps.Controls.Add(this.buttonFpsRun);
            this.panelFps.Controls.Add(this.labelFpsDescription);
            this.panelFps.Controls.Add(this.labelFpsTitle);
            this.panelFps.Controls.Add(this.pictureBoxFps);
            this.panelFps.FillColor = System.Drawing.Color.Black;
            this.panelFps.Location = new System.Drawing.Point(57, 41);
            this.panelFps.Name = "panelFps";
            this.panelFps.Size = new System.Drawing.Size(189, 194);
            this.panelFps.TabIndex = 0;
            // 
            // buttonFpsRun
            // 
            this.buttonFpsRun.BorderRadius = 8;
            this.buttonFpsRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFpsRun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFpsRun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFpsRun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFpsRun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFpsRun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFpsRun.ForeColor = System.Drawing.Color.White;
            this.buttonFpsRun.Location = new System.Drawing.Point(44, 134);
            this.buttonFpsRun.Name = "buttonFpsRun";
            this.buttonFpsRun.Size = new System.Drawing.Size(103, 42);
            this.buttonFpsRun.TabIndex = 3;
            this.buttonFpsRun.Text = "Run";
            this.buttonFpsRun.Click += new System.EventHandler(this.buttonFpsRun_Click);
            // 
            // labelFpsDescription
            // 
            this.labelFpsDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFpsDescription.ForeColor = System.Drawing.Color.White;
            this.labelFpsDescription.Location = new System.Drawing.Point(0, 77);
            this.labelFpsDescription.Name = "labelFpsDescription";
            this.labelFpsDescription.Size = new System.Drawing.Size(189, 36);
            this.labelFpsDescription.TabIndex = 2;
            this.labelFpsDescription.Text = "Unlock your fps and improve some game settings";
            this.labelFpsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFpsTitle
            // 
            this.labelFpsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFpsTitle.ForeColor = System.Drawing.Color.White;
            this.labelFpsTitle.Location = new System.Drawing.Point(0, 50);
            this.labelFpsTitle.Name = "labelFpsTitle";
            this.labelFpsTitle.Size = new System.Drawing.Size(189, 23);
            this.labelFpsTitle.TabIndex = 1;
            this.labelFpsTitle.Text = "Fps Unlocker";
            this.labelFpsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFps
            // 
            this.pictureBoxFps.ImageRotate = 0F;
            this.pictureBoxFps.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxFps.Name = "pictureBoxFps";
            this.pictureBoxFps.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxFps.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxFps.TabIndex = 0;
            this.pictureBoxFps.TabStop = false;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(680, 403);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.panelMain.ResumeLayout(false);
            this.panelLanguage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            this.panelConsole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsole)).EndInit();
            this.panelFps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelFps;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxFps;
        private Guna.UI2.WinForms.Guna2Button buttonFpsRun;
        private System.Windows.Forms.Label labelFpsDescription;
        private System.Windows.Forms.Label labelFpsTitle;
        private Guna.UI2.WinForms.Guna2Panel panelConsole;
        private System.Windows.Forms.Label labelConsoleDescription;
        private System.Windows.Forms.Label labelConsoleTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxConsole;
        private Guna.UI2.WinForms.Guna2Button buttonConsole;
        private Guna.UI2.WinForms.Guna2Panel panelLanguage;
        private Guna.UI2.WinForms.Guna2Button buttonLanguage;
        private System.Windows.Forms.Label labelLanguageDescription;
        private System.Windows.Forms.Label labelLanguageTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxLanguage;
    }
}
