namespace LINDRA___Market.form.LanguageSelector
{
    partial class FormLanguageSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLanguageSelector));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMapDetails = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMaps = new Guna.UI2.WinForms.Guna2Button();
            this.panelTopRight = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelTopLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topRightPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topLeftPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBoxPage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelLeft.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.labelTitle.Location = new System.Drawing.Point(31, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(146, 21);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Language Selector";
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolderPath.Location = new System.Drawing.Point(15, 473);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(578, 19);
            this.labelFolderPath.TabIndex = 20;
            this.labelFolderPath.Text = "No workshop folder selected";
            this.labelFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.BackColor = System.Drawing.Color.Transparent;
            this.labelPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelPage.Location = new System.Drawing.Point(189, 31);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(41, 17);
            this.labelPage.TabIndex = 19;
            this.labelPage.Text = "Maps";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(117, 55);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(476, 412);
            this.panelMain.TabIndex = 17;
            // 
            // panelLeft
            // 
            this.panelLeft.BorderRadius = 12;
            this.panelLeft.Controls.Add(this.buttonSettings);
            this.panelLeft.Controls.Add(this.buttonMapDetails);
            this.panelLeft.Controls.Add(this.buttonMaps);
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelLeft.Location = new System.Drawing.Point(15, 55);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(96, 412);
            this.panelLeft.TabIndex = 16;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BorderRadius = 10;
            this.buttonSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSettings.FillColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::LINDRA___Market.Properties.Resources.SettingsLight;
            this.buttonSettings.Location = new System.Drawing.Point(22, 345);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(50, 50);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.UseTransparentBackground = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonMapDetails
            // 
            this.buttonMapDetails.BackColor = System.Drawing.Color.Transparent;
            this.buttonMapDetails.BorderColor = System.Drawing.Color.Transparent;
            this.buttonMapDetails.BorderRadius = 10;
            this.buttonMapDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonMapDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMapDetails.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonMapDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMapDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMapDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMapDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMapDetails.FillColor = System.Drawing.Color.Transparent;
            this.buttonMapDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMapDetails.ForeColor = System.Drawing.Color.White;
            this.buttonMapDetails.Image = global::LINDRA___Market.Properties.Resources.MapDetailsLight;
            this.buttonMapDetails.Location = new System.Drawing.Point(22, 91);
            this.buttonMapDetails.Name = "buttonMapDetails";
            this.buttonMapDetails.Size = new System.Drawing.Size(50, 50);
            this.buttonMapDetails.TabIndex = 2;
            this.buttonMapDetails.UseTransparentBackground = true;
            this.buttonMapDetails.Visible = false;
            this.buttonMapDetails.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonMaps
            // 
            this.buttonMaps.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaps.BorderColor = System.Drawing.Color.Transparent;
            this.buttonMaps.BorderRadius = 10;
            this.buttonMaps.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonMaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaps.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonMaps.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMaps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMaps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMaps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMaps.FillColor = System.Drawing.Color.Transparent;
            this.buttonMaps.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMaps.ForeColor = System.Drawing.Color.White;
            this.buttonMaps.Image = global::LINDRA___Market.Properties.Resources.MapsLight;
            this.buttonMaps.Location = new System.Drawing.Point(22, 24);
            this.buttonMaps.Name = "buttonMaps";
            this.buttonMaps.Size = new System.Drawing.Size(50, 50);
            this.buttonMaps.TabIndex = 1;
            this.buttonMaps.UseTransparentBackground = true;
            this.buttonMaps.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // panelTopRight
            // 
            this.panelTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelTopRight.BorderRadius = 200;
            this.panelTopRight.Controls.Add(this.buttonMinimize);
            this.panelTopRight.Controls.Add(this.buttonClose);
            this.panelTopRight.Location = new System.Drawing.Point(462, -24);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(180, 73);
            this.panelTopRight.TabIndex = 15;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonMinimize.Location = new System.Drawing.Point(29, 31);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(45, 29);
            this.buttonMinimize.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonClose.Location = new System.Drawing.Point(82, 31);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 29);
            this.buttonClose.TabIndex = 0;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelTopLeft.BorderRadius = 200;
            this.panelTopLeft.Controls.Add(this.labelTitle);
            this.panelTopLeft.Location = new System.Drawing.Point(-20, -24);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(180, 73);
            this.panelTopLeft.TabIndex = 14;
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 10;
            this.formElipse.TargetControl = this;
            // 
            // topRightPanelElipse
            // 
            this.topRightPanelElipse.BorderRadius = 40;
            // 
            // topLeftPanelElipse
            // 
            this.topLeftPanelElipse.BorderRadius = 40;
            this.topLeftPanelElipse.TargetControl = this.panelTopLeft;
            // 
            // formDragControl
            // 
            this.formDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDragControl.TargetControl = this;
            this.formDragControl.UseTransparentDrag = true;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPage.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxPage.Image = global::LINDRA___Market.Properties.Resources.MapsLight;
            this.pictureBoxPage.ImageRotate = 0F;
            this.pictureBoxPage.Location = new System.Drawing.Point(166, 30);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage.TabIndex = 18;
            this.pictureBoxPage.TabStop = false;
            // 
            // FormLanguageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTopRight);
            this.Controls.Add(this.panelTopLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLanguageSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLanguageSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLanguageSelector_FormClosing);
            this.Load += new System.EventHandler(this.FormLanguageSelector_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.Label labelPage;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPage;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Button buttonSettings;
        private Guna.UI2.WinForms.Guna2Button buttonMapDetails;
        private Guna.UI2.WinForms.Guna2Button buttonMaps;
        private Guna.UI2.WinForms.Guna2Panel panelTopRight;
        private Guna.UI2.WinForms.Guna2ControlBox buttonMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox buttonClose;
        private Guna.UI2.WinForms.Guna2Panel panelTopLeft;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2Elipse topRightPanelElipse;
        private Guna.UI2.WinForms.Guna2Elipse topLeftPanelElipse;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
    }
}