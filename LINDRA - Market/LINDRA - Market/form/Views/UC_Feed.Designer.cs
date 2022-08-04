namespace LINDRA___Market.form.Views
{
    partial class UC_Feed
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
            this.panelAllies = new Guna.UI2.WinForms.Guna2Panel();
            this.labelAllies = new System.Windows.Forms.Label();
            this.labelAxis = new System.Windows.Forms.Label();
            this.panelAxis = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSetFeedColor = new Guna.UI2.WinForms.Guna2Button();
            this.button_reset = new Guna.UI2.WinForms.Guna2Button();
            this.colorDialogAllies = new System.Windows.Forms.ColorDialog();
            this.colorDialogAxis = new System.Windows.Forms.ColorDialog();
            this.update_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelAllies
            // 
            this.panelAllies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.panelAllies.Location = new System.Drawing.Point(141, 51);
            this.panelAllies.Name = "panelAllies";
            this.panelAllies.Size = new System.Drawing.Size(137, 50);
            this.panelAllies.TabIndex = 0;
            this.panelAllies.Click += new System.EventHandler(this.openColorDialog);
            // 
            // labelAllies
            // 
            this.labelAllies.AutoSize = true;
            this.labelAllies.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelAllies.Location = new System.Drawing.Point(23, 66);
            this.labelAllies.Name = "labelAllies";
            this.labelAllies.Size = new System.Drawing.Size(89, 21);
            this.labelAllies.TabIndex = 3;
            this.labelAllies.Text = "Allies Feed";
            // 
            // labelAxis
            // 
            this.labelAxis.AutoSize = true;
            this.labelAxis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelAxis.Location = new System.Drawing.Point(23, 191);
            this.labelAxis.Name = "labelAxis";
            this.labelAxis.Size = new System.Drawing.Size(80, 21);
            this.labelAxis.TabIndex = 4;
            this.labelAxis.Text = "Axis Feed";
            // 
            // panelAxis
            // 
            this.panelAxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.panelAxis.Location = new System.Drawing.Point(141, 175);
            this.panelAxis.Name = "panelAxis";
            this.panelAxis.Size = new System.Drawing.Size(137, 50);
            this.panelAxis.TabIndex = 1;
            this.panelAxis.Click += new System.EventHandler(this.openColorDialog);
            // 
            // buttonSetFeedColor
            // 
            this.buttonSetFeedColor.BorderRadius = 20;
            this.buttonSetFeedColor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSetFeedColor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSetFeedColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSetFeedColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSetFeedColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonSetFeedColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetFeedColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonSetFeedColor.Location = new System.Drawing.Point(133, 299);
            this.buttonSetFeedColor.Name = "buttonSetFeedColor";
            this.buttonSetFeedColor.Size = new System.Drawing.Size(145, 45);
            this.buttonSetFeedColor.TabIndex = 5;
            this.buttonSetFeedColor.Text = "Set feed Color";
            this.buttonSetFeedColor.Click += new System.EventHandler(this.buttonSetFeedColor_Click);
            // 
            // button_reset
            // 
            this.button_reset.BorderRadius = 20;
            this.button_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.button_reset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.button_reset.Location = new System.Drawing.Point(18, 299);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(109, 45);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Reset";
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // colorDialogAllies
            // 
            this.colorDialogAllies.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.colorDialogAllies.FullOpen = true;
            // 
            // colorDialogAxis
            // 
            this.colorDialogAxis.Color = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.colorDialogAxis.FullOpen = true;
            // 
            // update_timer
            // 
            this.update_timer.Enabled = true;
            this.update_timer.Tick += new System.EventHandler(this.update_timer_Tick);
            // 
            // UC_Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.buttonSetFeedColor);
            this.Controls.Add(this.panelAxis);
            this.Controls.Add(this.labelAxis);
            this.Controls.Add(this.labelAllies);
            this.Controls.Add(this.panelAllies);
            this.Name = "UC_Feed";
            this.Size = new System.Drawing.Size(300, 387);
            this.Load += new System.EventHandler(this.UC_Feed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelAllies;
        private System.Windows.Forms.Label labelAllies;
        private System.Windows.Forms.Label labelAxis;
        private Guna.UI2.WinForms.Guna2Panel panelAxis;
        private Guna.UI2.WinForms.Guna2Button buttonSetFeedColor;
        private Guna.UI2.WinForms.Guna2Button button_reset;
        private System.Windows.Forms.ColorDialog colorDialogAllies;
        private System.Windows.Forms.ColorDialog colorDialogAxis;
        private System.Windows.Forms.Timer update_timer;
    }
}
