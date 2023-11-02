namespace LINDRA___Market.Views
{
    partial class UC_About
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
            this.labelReport = new System.Windows.Forms.Label();
            this.buttonReport = new Guna.UI2.WinForms.Guna2Button();
            this.labelDiscord = new System.Windows.Forms.Label();
            this.labelDiscordTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport.Location = new System.Drawing.Point(14, 18);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(251, 21);
            this.labelReport.TabIndex = 0;
            this.labelReport.Text = "Any problem, bug, crash, error ?";
            // 
            // buttonReport
            // 
            this.buttonReport.BorderRadius = 8;
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Location = new System.Drawing.Point(18, 53);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(116, 45);
            this.buttonReport.TabIndex = 1;
            this.buttonReport.Text = "Report it";
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // labelDiscord
            // 
            this.labelDiscord.AutoSize = true;
            this.labelDiscord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscord.Location = new System.Drawing.Point(14, 324);
            this.labelDiscord.Name = "labelDiscord";
            this.labelDiscord.Size = new System.Drawing.Size(276, 21);
            this.labelDiscord.TabIndex = 2;
            this.labelDiscord.Text = "Direct question, add me on discord";
            // 
            // labelDiscordTag
            // 
            this.labelDiscordTag.AutoSize = true;
            this.labelDiscordTag.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscordTag.Location = new System.Drawing.Point(20, 352);
            this.labelDiscordTag.Name = "labelDiscordTag";
            this.labelDiscordTag.Size = new System.Drawing.Size(41, 17);
            this.labelDiscordTag.TabIndex = 3;
            this.labelDiscordTag.Text = "lindra";
            // 
            // UC_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDiscordTag);
            this.Controls.Add(this.labelDiscord);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.labelReport);
            this.Name = "UC_About";
            this.Size = new System.Drawing.Size(677, 400);
            this.Load += new System.EventHandler(this.UC_About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReport;
        private Guna.UI2.WinForms.Guna2Button buttonReport;
        private System.Windows.Forms.Label labelDiscord;
        private System.Windows.Forms.Label labelDiscordTag;
    }
}
