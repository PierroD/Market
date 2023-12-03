namespace LINDRA___Market.form
{
    partial class fps_unlocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fps_unlocker));
            this.fromElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.buttonArea = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDisable = new Guna.UI2.WinForms.Guna2Button();
            this.buttonVisuals = new Guna.UI2.WinForms.Guna2Button();
            this.elipsePanelBottom = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.labelGameName = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromElipse
            // 
            this.fromElipse.BorderRadius = 25;
            this.fromElipse.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 40);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.labelTitle.Location = new System.Drawing.Point(11, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(105, 21);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "FPS Unlocker";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FillColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonMinimize.Location = new System.Drawing.Point(192, 5);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(45, 29);
            this.buttonMinimize.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FillColor = System.Drawing.Color.Transparent;
            this.buttonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonClose.Location = new System.Drawing.Point(243, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 29);
            this.buttonClose.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelBottom.BorderColor = System.Drawing.Color.White;
            this.panelBottom.BorderRadius = 24;
            this.panelBottom.Controls.Add(this.buttonSettings);
            this.panelBottom.Controls.Add(this.buttonArea);
            this.panelBottom.Controls.Add(this.buttonDisable);
            this.panelBottom.Controls.Add(this.buttonVisuals);
            this.panelBottom.Location = new System.Drawing.Point(10, 434);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(278, 44);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonSettings
            // 
            this.buttonSettings.AutoRoundedCorners = true;
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BorderRadius = 19;
            this.buttonSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSettings.FillColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(230, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(40, 40);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.UseTransparentBackground = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.AutoRoundedCorners = true;
            this.buttonArea.BackColor = System.Drawing.Color.Transparent;
            this.buttonArea.BorderRadius = 19;
            this.buttonArea.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonArea.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonArea.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonArea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonArea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonArea.FillColor = System.Drawing.Color.Transparent;
            this.buttonArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonArea.ForeColor = System.Drawing.Color.White;
            this.buttonArea.Image = global::LINDRA___Market.Properties.Resources.FullScreenLight;
            this.buttonArea.Location = new System.Drawing.Point(160, 0);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(40, 40);
            this.buttonArea.TabIndex = 2;
            this.buttonArea.UseTransparentBackground = true;
            this.buttonArea.Visible = false;
            this.buttonArea.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.AutoRoundedCorners = true;
            this.buttonDisable.BackColor = System.Drawing.Color.Transparent;
            this.buttonDisable.BorderRadius = 19;
            this.buttonDisable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDisable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDisable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDisable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDisable.FillColor = System.Drawing.Color.Transparent;
            this.buttonDisable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDisable.ForeColor = System.Drawing.Color.White;
            this.buttonDisable.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisable.Image")));
            this.buttonDisable.Location = new System.Drawing.Point(80, 0);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(40, 40);
            this.buttonDisable.TabIndex = 1;
            this.buttonDisable.UseTransparentBackground = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonVisuals
            // 
            this.buttonVisuals.AutoRoundedCorners = true;
            this.buttonVisuals.BackColor = System.Drawing.Color.Transparent;
            this.buttonVisuals.BorderRadius = 19;
            this.buttonVisuals.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonVisuals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVisuals.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonVisuals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonVisuals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonVisuals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonVisuals.FillColor = System.Drawing.Color.Transparent;
            this.buttonVisuals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonVisuals.ForeColor = System.Drawing.Color.White;
            this.buttonVisuals.Image = ((System.Drawing.Image)(resources.GetObject("buttonVisuals.Image")));
            this.buttonVisuals.Location = new System.Drawing.Point(10, 0);
            this.buttonVisuals.Name = "buttonVisuals";
            this.buttonVisuals.Size = new System.Drawing.Size(40, 40);
            this.buttonVisuals.TabIndex = 0;
            this.buttonVisuals.UseTransparentBackground = true;
            this.buttonVisuals.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // elipsePanelBottom
            // 
            this.elipsePanelBottom.BorderRadius = 24;
            this.elipsePanelBottom.TargetControl = this.panelBottom;
            // 
            // formDragControl
            // 
            this.formDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDragControl.TargetControl = this.panelTop;
            this.formDragControl.UseTransparentDrag = true;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(300, 387);
            this.panelMain.TabIndex = 2;
            // 
            // labelGameName
            // 
            this.labelGameName.BackColor = System.Drawing.Color.Transparent;
            this.labelGameName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGameName.Location = new System.Drawing.Point(0, 482);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(300, 25);
            this.labelGameName.TabIndex = 3;
            this.labelGameName.Text = "No game found";
            this.labelGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // fps_unlocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(300, 510);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fps_unlocker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fps_unlocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fps_unlocker_FormClosing);
            this.Load += new System.EventHandler(this.fps_unlocker_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse fromElipse;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2ControlBox buttonMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox buttonClose;
        private Guna.UI2.WinForms.Guna2Elipse elipsePanelBottom;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2Button buttonVisuals;
        private Guna.UI2.WinForms.Guna2Button buttonSettings;
        private Guna.UI2.WinForms.Guna2Button buttonArea;
        private Guna.UI2.WinForms.Guna2Button buttonDisable;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Timer timerGame;
    }
}