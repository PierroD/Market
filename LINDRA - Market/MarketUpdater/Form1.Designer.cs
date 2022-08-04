namespace MarketUpdater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBarLoading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.labelMainText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new Guna.UI2.WinForms.Guna2Button();
            this.timerLoading = new System.Windows.Forms.Timer();
            this.progressBarLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Animated = true;
            this.progressBarLoading.AnimationSpeed = 1F;
            this.progressBarLoading.Controls.Add(this.labelMainText);
            this.progressBarLoading.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.progressBarLoading.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBarLoading.ForeColor = System.Drawing.Color.White;
            this.progressBarLoading.Location = new System.Drawing.Point(4, 109);
            this.progressBarLoading.Minimum = 0;
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.progressBarLoading.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.progressBarLoading.ProgressOffset = 20;
            this.progressBarLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBarLoading.Size = new System.Drawing.Size(294, 294);
            this.progressBarLoading.TabIndex = 0;
            this.progressBarLoading.Text = "guna2CircleProgressBar1";
            this.progressBarLoading.Value = 1;
            // 
            // labelMainText
            // 
            this.labelMainText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.labelMainText.Location = new System.Drawing.Point(46, 102);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.Size = new System.Drawing.Size(203, 88);
            this.labelMainText.TabIndex = 2;
            this.labelMainText.Text = "Downloading";
            this.labelMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "FPS Market - Installer / Updater";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Animated = true;
            this.buttonStart.AutoRoundedCorners = true;
            this.buttonStart.BorderRadius = 21;
            this.buttonStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonStart.Enabled = false;
            this.buttonStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(54, 506);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(199, 45);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start / Restart";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(301, 588);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarLoading);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Market - Installer / Updater";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.progressBarLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBarLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMainText;
        private Guna.UI2.WinForms.Guna2Button buttonStart;
        private System.Windows.Forms.Timer timerLoading;
    }
}

