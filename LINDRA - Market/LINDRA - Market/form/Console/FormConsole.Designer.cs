namespace LINDRA___Market.form.Console
{
    partial class FormConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsole));
            this.panelTopRight = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topRightPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTopLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.topLeftPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.buttonConsole = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.labelPage = new System.Windows.Forms.Label();
            this.pictureBoxPage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelGameName = new System.Windows.Forms.Label();
            this.panelTopRight.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
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
            this.panelTopRight.TabIndex = 2;
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
            // formElipse
            // 
            this.formElipse.BorderRadius = 10;
            this.formElipse.TargetControl = this;
            // 
            // topRightPanelElipse
            // 
            this.topRightPanelElipse.BorderRadius = 40;
            this.topRightPanelElipse.TargetControl = this.panelTopRight;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelTopLeft.BorderRadius = 200;
            this.panelTopLeft.Controls.Add(this.labelTitle);
            this.panelTopLeft.Location = new System.Drawing.Point(-20, -24);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(180, 73);
            this.panelTopLeft.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.labelTitle.Location = new System.Drawing.Point(31, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(131, 21);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "External Console";
            // 
            // topLeftPanelElipse
            // 
            this.topLeftPanelElipse.BorderRadius = 40;
            this.topLeftPanelElipse.TargetControl = this.panelTopLeft;
            // 
            // panelLeft
            // 
            this.panelLeft.BorderRadius = 12;
            this.panelLeft.Controls.Add(this.buttonSettings);
            this.panelLeft.Controls.Add(this.buttonSearch);
            this.panelLeft.Controls.Add(this.buttonConsole);
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelLeft.Location = new System.Drawing.Point(15, 55);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(96, 322);
            this.panelLeft.TabIndex = 4;
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
            this.buttonSettings.Location = new System.Drawing.Point(22, 253);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(50, 50);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.UseTransparentBackground = true;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderRadius = 10;
            this.buttonSearch.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.FillColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = global::LINDRA___Market.Properties.Resources.SearchLight;
            this.buttonSearch.Location = new System.Drawing.Point(22, 91);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 50);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseTransparentBackground = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonConsole
            // 
            this.buttonConsole.BackColor = System.Drawing.Color.Transparent;
            this.buttonConsole.BorderColor = System.Drawing.Color.Transparent;
            this.buttonConsole.BorderRadius = 10;
            this.buttonConsole.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsole.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonConsole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConsole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConsole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConsole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConsole.FillColor = System.Drawing.Color.Transparent;
            this.buttonConsole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonConsole.ForeColor = System.Drawing.Color.White;
            this.buttonConsole.Image = global::LINDRA___Market.Properties.Resources.ConsoleLight;
            this.buttonConsole.Location = new System.Drawing.Point(22, 24);
            this.buttonConsole.Name = "buttonConsole";
            this.buttonConsole.Size = new System.Drawing.Size(50, 50);
            this.buttonConsole.TabIndex = 1;
            this.buttonConsole.UseTransparentBackground = true;
            this.buttonConsole.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(117, 55);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(470, 320);
            this.panelMain.TabIndex = 5;
            // 
            // formDragControl
            // 
            this.formDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDragControl.TargetControl = this;
            this.formDragControl.UseTransparentDrag = true;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.BackColor = System.Drawing.Color.Transparent;
            this.labelPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelPage.Location = new System.Drawing.Point(189, 31);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(56, 17);
            this.labelPage.TabIndex = 9;
            this.labelPage.Text = "Console";
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPage.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxPage.Image = global::LINDRA___Market.Properties.Resources.ConsoleLight;
            this.pictureBoxPage.ImageRotate = 0F;
            this.pictureBoxPage.Location = new System.Drawing.Point(166, 30);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage.TabIndex = 8;
            this.pictureBoxPage.TabStop = false;
            // 
            // labelGameName
            // 
            this.labelGameName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.Location = new System.Drawing.Point(117, 378);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(472, 13);
            this.labelGameName.TabIndex = 10;
            this.labelGameName.Text = "No game found";
            this.labelGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTopLeft);
            this.Controls.Add(this.panelTopRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsole";
            this.Text = "External Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsole_FormClosing);
            this.Load += new System.EventHandler(this.FormConsole_Load);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTopRight;
        private Guna.UI2.WinForms.Guna2ControlBox buttonMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox buttonClose;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2Elipse topRightPanelElipse;
        private Guna.UI2.WinForms.Guna2Panel panelTopLeft;
        private Guna.UI2.WinForms.Guna2Elipse topLeftPanelElipse;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2Button buttonConsole;
        private Guna.UI2.WinForms.Guna2Button buttonSettings;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private System.Windows.Forms.Label labelPage;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPage;
        private System.Windows.Forms.Label labelGameName;
    }
}