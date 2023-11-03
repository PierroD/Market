namespace LINDRA___Market.form.Views
{
    partial class UC_Disable
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
            this.switchFog = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.switchGlow = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.switchBullet = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.switchCamos = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelCamos = new System.Windows.Forms.Label();
            this.labelBullet = new System.Windows.Forms.Label();
            this.labelGlow = new System.Windows.Forms.Label();
            this.labelFog = new System.Windows.Forms.Label();
            this.update_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // switchFog
            // 
            this.switchFog.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchFog.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchFog.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchFog.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchFog.Location = new System.Drawing.Point(175, 91);
            this.switchFog.Name = "switchFog";
            this.switchFog.Size = new System.Drawing.Size(35, 20);
            this.switchFog.TabIndex = 0;
            this.switchFog.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchFog.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchFog.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchFog.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchFog.CheckedChanged += new System.EventHandler(this.switchFog_CheckedChanged);
            // 
            // switchGlow
            // 
            this.switchGlow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchGlow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchGlow.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchGlow.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchGlow.Location = new System.Drawing.Point(175, 131);
            this.switchGlow.Name = "switchGlow";
            this.switchGlow.Size = new System.Drawing.Size(35, 20);
            this.switchGlow.TabIndex = 1;
            this.switchGlow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchGlow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchGlow.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchGlow.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchGlow.CheckedChanged += new System.EventHandler(this.switchGlow_CheckedChanged);
            // 
            // switchBullet
            // 
            this.switchBullet.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchBullet.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchBullet.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchBullet.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchBullet.Location = new System.Drawing.Point(175, 171);
            this.switchBullet.Name = "switchBullet";
            this.switchBullet.Size = new System.Drawing.Size(35, 20);
            this.switchBullet.TabIndex = 2;
            this.switchBullet.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchBullet.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchBullet.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchBullet.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchBullet.CheckedChanged += new System.EventHandler(this.switchBullet_CheckedChanged);
            // 
            // switchCamos
            // 
            this.switchCamos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchCamos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchCamos.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchCamos.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchCamos.Location = new System.Drawing.Point(175, 211);
            this.switchCamos.Name = "switchCamos";
            this.switchCamos.Size = new System.Drawing.Size(35, 20);
            this.switchCamos.TabIndex = 3;
            this.switchCamos.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchCamos.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchCamos.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchCamos.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchCamos.CheckedChanged += new System.EventHandler(this.switchCamos_CheckedChanged);
            // 
            // labelCamos
            // 
            this.labelCamos.AutoSize = true;
            this.labelCamos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelCamos.Location = new System.Drawing.Point(75, 210);
            this.labelCamos.Name = "labelCamos";
            this.labelCamos.Size = new System.Drawing.Size(85, 21);
            this.labelCamos.TabIndex = 5;
            this.labelCamos.Text = "No Camos";
            // 
            // labelBullet
            // 
            this.labelBullet.AutoSize = true;
            this.labelBullet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelBullet.Location = new System.Drawing.Point(75, 170);
            this.labelBullet.Name = "labelBullet";
            this.labelBullet.Size = new System.Drawing.Size(78, 21);
            this.labelBullet.TabIndex = 6;
            this.labelBullet.Text = "No Bullet";
            // 
            // labelGlow
            // 
            this.labelGlow.AutoSize = true;
            this.labelGlow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGlow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelGlow.Location = new System.Drawing.Point(75, 130);
            this.labelGlow.Name = "labelGlow";
            this.labelGlow.Size = new System.Drawing.Size(73, 21);
            this.labelGlow.TabIndex = 7;
            this.labelGlow.Text = "No Glow";
            // 
            // labelFog
            // 
            this.labelFog.AutoSize = true;
            this.labelFog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFog.Location = new System.Drawing.Point(75, 90);
            this.labelFog.Name = "labelFog";
            this.labelFog.Size = new System.Drawing.Size(64, 21);
            this.labelFog.TabIndex = 8;
            this.labelFog.Text = "No Fog";
            // 
            // update_timer
            // 
            this.update_timer.Enabled = true;
            this.update_timer.Tick += new System.EventHandler(this.update_timer_Tick);
            // 
            // UC_Disable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.labelFog);
            this.Controls.Add(this.labelGlow);
            this.Controls.Add(this.labelBullet);
            this.Controls.Add(this.labelCamos);
            this.Controls.Add(this.switchCamos);
            this.Controls.Add(this.switchBullet);
            this.Controls.Add(this.switchGlow);
            this.Controls.Add(this.switchFog);
            this.Name = "UC_Disable";
            this.Size = new System.Drawing.Size(300, 387);
            this.Load += new System.EventHandler(this.UC_Disable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch switchFog;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchGlow;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchBullet;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchCamos;
        private System.Windows.Forms.Label labelCamos;
        private System.Windows.Forms.Label labelBullet;
        private System.Windows.Forms.Label labelGlow;
        private System.Windows.Forms.Label labelFog;
        private System.Windows.Forms.Timer update_timer;
    }
}
