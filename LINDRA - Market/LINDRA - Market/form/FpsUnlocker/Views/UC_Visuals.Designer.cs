namespace LINDRA___Market.form.Views
{
    partial class UC_Visuals
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
            this.trackbarFov = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackbarFps = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelFps = new System.Windows.Forms.Label();
            this.labelFov = new System.Windows.Forms.Label();
            this.labelFpsValue = new System.Windows.Forms.Label();
            this.labelFovValue = new System.Windows.Forms.Label();
            this.update_timer = new System.Windows.Forms.Timer(this.components);
            this.labelFovScaleValue = new System.Windows.Forms.Label();
            this.labelFovScale = new System.Windows.Forms.Label();
            this.trackbarFovScale = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelFovMinimum = new System.Windows.Forms.Label();
            this.trackbarFovMinimum = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelFovMinimumValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trackbarFov
            // 
            this.trackbarFov.Location = new System.Drawing.Point(19, 34);
            this.trackbarFov.Maximum = 130;
            this.trackbarFov.Minimum = 65;
            this.trackbarFov.Name = "trackbarFov";
            this.trackbarFov.Size = new System.Drawing.Size(212, 23);
            this.trackbarFov.TabIndex = 0;
            this.trackbarFov.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarFov.Value = 65;
            this.trackbarFov.ValueChanged += new System.EventHandler(this.trackbarFov_ValueChanged);
            // 
            // trackbarFps
            // 
            this.trackbarFps.Location = new System.Drawing.Point(19, 91);
            this.trackbarFps.Maximum = 333;
            this.trackbarFps.Minimum = 90;
            this.trackbarFps.Name = "trackbarFps";
            this.trackbarFps.Size = new System.Drawing.Size(212, 23);
            this.trackbarFps.TabIndex = 1;
            this.trackbarFps.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarFps.Value = 90;
            this.trackbarFps.ValueChanged += new System.EventHandler(this.trackbarFps_ValueChanged);
            // 
            // labelFps
            // 
            this.labelFps.AutoSize = true;
            this.labelFps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFps.Location = new System.Drawing.Point(96, 67);
            this.labelFps.Name = "labelFps";
            this.labelFps.Size = new System.Drawing.Size(74, 21);
            this.labelFps.TabIndex = 10;
            this.labelFps.Text = "Max_FPS";
            // 
            // labelFov
            // 
            this.labelFov.AutoSize = true;
            this.labelFov.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFov.Location = new System.Drawing.Point(86, 10);
            this.labelFov.Name = "labelFov";
            this.labelFov.Size = new System.Drawing.Size(98, 21);
            this.labelFov.TabIndex = 11;
            this.labelFov.Text = "FieldOfView";
            // 
            // labelFpsValue
            // 
            this.labelFpsValue.AutoSize = true;
            this.labelFpsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFpsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFpsValue.Location = new System.Drawing.Point(240, 91);
            this.labelFpsValue.Name = "labelFpsValue";
            this.labelFpsValue.Size = new System.Drawing.Size(28, 21);
            this.labelFpsValue.TabIndex = 12;
            this.labelFpsValue.Text = "90";
            // 
            // labelFovValue
            // 
            this.labelFovValue.AutoSize = true;
            this.labelFovValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFovValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFovValue.Location = new System.Drawing.Point(240, 34);
            this.labelFovValue.Name = "labelFovValue";
            this.labelFovValue.Size = new System.Drawing.Size(28, 21);
            this.labelFovValue.TabIndex = 13;
            this.labelFovValue.Text = "65";
            // 
            // update_timer
            // 
            this.update_timer.Enabled = true;
            this.update_timer.Interval = 2500;
            this.update_timer.Tick += new System.EventHandler(this.update_timer_Tick);
            // 
            // labelFovScaleValue
            // 
            this.labelFovScaleValue.AutoSize = true;
            this.labelFovScaleValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFovScaleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFovScaleValue.Location = new System.Drawing.Point(240, 146);
            this.labelFovScaleValue.Name = "labelFovScaleValue";
            this.labelFovScaleValue.Size = new System.Drawing.Size(47, 21);
            this.labelFovScaleValue.TabIndex = 16;
            this.labelFovScaleValue.Text = "1,000";
            // 
            // labelFovScale
            // 
            this.labelFovScale.AutoSize = true;
            this.labelFovScale.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFovScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFovScale.Location = new System.Drawing.Point(96, 122);
            this.labelFovScale.Name = "labelFovScale";
            this.labelFovScale.Size = new System.Drawing.Size(74, 21);
            this.labelFovScale.TabIndex = 15;
            this.labelFovScale.Text = "FovScale";
            // 
            // trackbarFovScale
            // 
            this.trackbarFovScale.Location = new System.Drawing.Point(19, 146);
            this.trackbarFovScale.Maximum = 2000;
            this.trackbarFovScale.Name = "trackbarFovScale";
            this.trackbarFovScale.Size = new System.Drawing.Size(212, 23);
            this.trackbarFovScale.TabIndex = 14;
            this.trackbarFovScale.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarFovScale.Value = 1000;
            this.trackbarFovScale.ValueChanged += new System.EventHandler(this.trackbarFovScale_ValueChanged);
            // 
            // labelFovMinimum
            // 
            this.labelFovMinimum.AutoSize = true;
            this.labelFovMinimum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFovMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFovMinimum.Location = new System.Drawing.Point(86, 186);
            this.labelFovMinimum.Name = "labelFovMinimum";
            this.labelFovMinimum.Size = new System.Drawing.Size(105, 21);
            this.labelFovMinimum.TabIndex = 18;
            this.labelFovMinimum.Text = "FovMinimum";
            // 
            // trackbarFovMinimum
            // 
            this.trackbarFovMinimum.Location = new System.Drawing.Point(19, 210);
            this.trackbarFovMinimum.Maximum = 130;
            this.trackbarFovMinimum.Minimum = 65;
            this.trackbarFovMinimum.Name = "trackbarFovMinimum";
            this.trackbarFovMinimum.Size = new System.Drawing.Size(212, 23);
            this.trackbarFovMinimum.TabIndex = 17;
            this.trackbarFovMinimum.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarFovMinimum.Value = 65;
            this.trackbarFovMinimum.ValueChanged += new System.EventHandler(this.trackbarFovMinimum_ValueChanged);
            // 
            // labelFovMinimumValue
            // 
            this.labelFovMinimumValue.AutoSize = true;
            this.labelFovMinimumValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFovMinimumValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelFovMinimumValue.Location = new System.Drawing.Point(240, 210);
            this.labelFovMinimumValue.Name = "labelFovMinimumValue";
            this.labelFovMinimumValue.Size = new System.Drawing.Size(28, 21);
            this.labelFovMinimumValue.TabIndex = 19;
            this.labelFovMinimumValue.Text = "65";
            // 
            // UC_Visuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.labelFovMinimumValue);
            this.Controls.Add(this.labelFovMinimum);
            this.Controls.Add(this.trackbarFovMinimum);
            this.Controls.Add(this.labelFovScaleValue);
            this.Controls.Add(this.labelFovScale);
            this.Controls.Add(this.trackbarFovScale);
            this.Controls.Add(this.labelFovValue);
            this.Controls.Add(this.labelFpsValue);
            this.Controls.Add(this.labelFov);
            this.Controls.Add(this.labelFps);
            this.Controls.Add(this.trackbarFps);
            this.Controls.Add(this.trackbarFov);
            this.Name = "UC_Visuals";
            this.Size = new System.Drawing.Size(300, 387);
            this.Load += new System.EventHandler(this.UC_Visuals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar trackbarFov;
        private Guna.UI2.WinForms.Guna2TrackBar trackbarFps;
        private System.Windows.Forms.Label labelFps;
        private System.Windows.Forms.Label labelFov;
        private System.Windows.Forms.Label labelFpsValue;
        private System.Windows.Forms.Label labelFovValue;
        private System.Windows.Forms.Timer update_timer;
        private System.Windows.Forms.Label labelFovScaleValue;
        private System.Windows.Forms.Label labelFovScale;
        private Guna.UI2.WinForms.Guna2TrackBar trackbarFovScale;
        private System.Windows.Forms.Label labelFovMinimum;
        private Guna.UI2.WinForms.Guna2TrackBar trackbarFovMinimum;
        private System.Windows.Forms.Label labelFovMinimumValue;
    }
}
