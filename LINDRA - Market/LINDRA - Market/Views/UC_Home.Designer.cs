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
            this.panelFps = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonFpsRun = new Guna.UI2.WinForms.Guna2Button();
            this.labelFpsDescription = new System.Windows.Forms.Label();
            this.labelFpsTitle = new System.Windows.Forms.Label();
            this.pictureBoxFps = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelConsole = new Guna.UI2.WinForms.Guna2Panel();
            this.labelConsoleDescription = new System.Windows.Forms.Label();
            this.labelConsoleTitle = new System.Windows.Forms.Label();
            this.pictureBoxConsole = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelInProgress = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelFps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFps)).BeginInit();
            this.panelConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsole)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelConsole);
            this.panelMain.Controls.Add(this.panelFps);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(677, 400);
            this.panelMain.TabIndex = 3;
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
            // panelConsole
            // 
            this.panelConsole.BackColor = System.Drawing.Color.Transparent;
            this.panelConsole.BorderRadius = 12;
            this.panelConsole.Controls.Add(this.labelInProgress);
            this.panelConsole.Controls.Add(this.labelConsoleDescription);
            this.panelConsole.Controls.Add(this.labelConsoleTitle);
            this.panelConsole.Controls.Add(this.pictureBoxConsole);
            this.panelConsole.FillColor = System.Drawing.Color.Black;
            this.panelConsole.Location = new System.Drawing.Point(413, 41);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(189, 194);
            this.panelConsole.TabIndex = 4;
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
            // labelInProgress
            // 
            this.labelInProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInProgress.ForeColor = System.Drawing.Color.White;
            this.labelInProgress.Location = new System.Drawing.Point(0, 134);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(189, 36);
            this.labelInProgress.TabIndex = 3;
            this.labelInProgress.Text = "Working on it";
            this.labelInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(677, 400);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.panelMain.ResumeLayout(false);
            this.panelFps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFps)).EndInit();
            this.panelConsole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsole)).EndInit();
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
        private System.Windows.Forms.Label labelInProgress;
    }
}
