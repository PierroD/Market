namespace LINDRA___Market
{
    partial class form_market
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_market));
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHome = new Guna.UI2.WinForms.Guna2Button();
            this.leftPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSignature = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 10;
            this.formElipse.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelLeft.BorderRadius = 20;
            this.panelLeft.Controls.Add(this.buttonSettings);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Location = new System.Drawing.Point(25, 25);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(80, 400);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BorderRadius = 10;
            this.buttonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::LINDRA___Market.Properties.Resources.settings_off;
            this.buttonSettings.Location = new System.Drawing.Point(13, 119);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(50, 50);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BorderRadius = 10;
            this.buttonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(13, 36);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(50, 50);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Click += new System.EventHandler(this.buttons_SideBar_Click);
            // 
            // leftPanelElipse
            // 
            this.leftPanelElipse.BorderRadius = 10;
            this.leftPanelElipse.TargetControl = this.panelLeft;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.buttonUpdate);
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Location = new System.Drawing.Point(599, -22);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(225, 73);
            this.panelTop.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BorderRadius = 10;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Image = global::LINDRA___Market.Properties.Resources.update_off;
            this.buttonUpdate.Location = new System.Drawing.Point(22, 26);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.buttonMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonMinimize.Location = new System.Drawing.Point(92, 31);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(45, 29);
            this.buttonMinimize.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonClose.Location = new System.Drawing.Point(143, 31);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 29);
            this.buttonClose.TabIndex = 0;
            // 
            // topPanelElipse
            // 
            this.topPanelElipse.BorderRadius = 40;
            this.topPanelElipse.TargetControl = this.panelTop;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(111, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(677, 400);
            this.panelMain.TabIndex = 2;
            // 
            // formDragControl
            // 
            this.formDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDragControl.TargetControl = this;
            this.formDragControl.UseTransparentDrag = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelTitle.Location = new System.Drawing.Point(7, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 21);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "FPS Market";
            // 
            // labelSignature
            // 
            this.labelSignature.BackColor = System.Drawing.Color.Transparent;
            this.labelSignature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelSignature.Location = new System.Drawing.Point(5, 428);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(789, 21);
            this.labelSignature.TabIndex = 4;
            this.labelSignature.Text = "Made with  ❤   by LINDRA";
            this.labelSignature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSignature);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_market";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market - By LINDRA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_market_FormClosing);
            this.Load += new System.EventHandler(this.form_market_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Button buttonHome;
        private Guna.UI2.WinForms.Guna2Elipse leftPanelElipse;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2ControlBox buttonClose;
        private Guna.UI2.WinForms.Guna2Button buttonSettings;
        private Guna.UI2.WinForms.Guna2Elipse topPanelElipse;
        private Guna.UI2.WinForms.Guna2ControlBox buttonMinimize;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private System.Windows.Forms.Label labelSignature;
    }
}

