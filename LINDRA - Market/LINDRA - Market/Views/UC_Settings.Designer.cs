namespace LINDRA___Market.Views
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
            this.components = new System.ComponentModel.Container();
            this.switchDarkMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelDarkMode = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelVersions = new System.Windows.Forms.Label();
            this.labelLatestVersion = new System.Windows.Forms.Label();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonShortcut = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // switchDarkMode
            // 
            this.switchDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.switchDarkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchDarkMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(170)))), ((int)(((byte)(206)))));
            this.switchDarkMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchDarkMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchDarkMode.Location = new System.Drawing.Point(110, 64);
            this.switchDarkMode.Name = "switchDarkMode";
            this.switchDarkMode.Size = new System.Drawing.Size(35, 20);
            this.switchDarkMode.TabIndex = 4;
            this.switchDarkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchDarkMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchDarkMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchDarkMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchDarkMode.CheckedChanged += new System.EventHandler(this.switchDarkMode_CheckedChanged);
            // 
            // labelDarkMode
            // 
            this.labelDarkMode.AutoSize = true;
            this.labelDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.labelDarkMode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDarkMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelDarkMode.Location = new System.Drawing.Point(21, 63);
            this.labelDarkMode.Name = "labelDarkMode";
            this.labelDarkMode.Size = new System.Drawing.Size(87, 21);
            this.labelDarkMode.TabIndex = 5;
            this.labelDarkMode.Text = "DarkMode";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelVersion.Location = new System.Drawing.Point(21, 316);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(153, 21);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "Current version : 1.0";
            // 
            // timer_update
            // 
            this.timer_update.Enabled = true;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(323, 63);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(302, 314);
            this.webBrowser.TabIndex = 7;
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.Transparent;
            this.separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.separator1.Location = new System.Drawing.Point(25, 288);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(277, 10);
            this.separator1.TabIndex = 9;
            // 
            // labelVersions
            // 
            this.labelVersions.AutoSize = true;
            this.labelVersions.BackColor = System.Drawing.Color.Transparent;
            this.labelVersions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelVersions.Location = new System.Drawing.Point(21, 264);
            this.labelVersions.Name = "labelVersions";
            this.labelVersions.Size = new System.Drawing.Size(71, 21);
            this.labelVersions.TabIndex = 8;
            this.labelVersions.Text = "Versions";
            // 
            // labelLatestVersion
            // 
            this.labelLatestVersion.AutoSize = true;
            this.labelLatestVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelLatestVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelLatestVersion.Location = new System.Drawing.Point(21, 347);
            this.labelLatestVersion.Name = "labelLatestVersion";
            this.labelLatestVersion.Size = new System.Drawing.Size(153, 21);
            this.labelLatestVersion.TabIndex = 10;
            this.labelLatestVersion.Text = "Current version : 1.0";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BorderRadius = 20;
            this.buttonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonUpdate.Location = new System.Drawing.Point(195, 320);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 45);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonShortcut
            // 
            this.buttonShortcut.BorderRadius = 20;
            this.buttonShortcut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonShortcut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonShortcut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonShortcut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonShortcut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonShortcut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShortcut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonShortcut.Location = new System.Drawing.Point(25, 99);
            this.buttonShortcut.Name = "buttonShortcut";
            this.buttonShortcut.Size = new System.Drawing.Size(279, 45);
            this.buttonShortcut.TabIndex = 12;
            this.buttonShortcut.Text = "Create Shortcut";
            this.buttonShortcut.Click += new System.EventHandler(this.buttonShortcut_Click);
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.buttonShortcut);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelLatestVersion);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.labelVersions);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelDarkMode);
            this.Controls.Add(this.switchDarkMode);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(677, 400);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchDarkMode;
        private System.Windows.Forms.Label labelDarkMode;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.WebBrowser webBrowser;
        private Guna.UI2.WinForms.Guna2Separator separator1;
        private System.Windows.Forms.Label labelVersions;
        private System.Windows.Forms.Label labelLatestVersion;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Button buttonShortcut;
    }
}
