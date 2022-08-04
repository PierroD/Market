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
            this.comboBoxLightMap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxSpecularMap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelMovie = new System.Windows.Forms.Label();
            this.switchMovie = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelSpecularmap = new System.Windows.Forms.Label();
            this.labelLightmap = new System.Windows.Forms.Label();
            this.labelFps = new System.Windows.Forms.Label();
            this.labelFov = new System.Windows.Forms.Label();
            this.labelFpsValue = new System.Windows.Forms.Label();
            this.labelFovValue = new System.Windows.Forms.Label();
            this.update_timer = new System.Windows.Forms.Timer(this.components);
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
            // comboBoxLightMap
            // 
            this.comboBoxLightMap.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxLightMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLightMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLightMap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.comboBoxLightMap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxLightMap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxLightMap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxLightMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxLightMap.ItemHeight = 30;
            this.comboBoxLightMap.Items.AddRange(new object[] {
            "Invert",
            "Normal",
            "Extrabright",
            "Toobright",
            "Fullbright"});
            this.comboBoxLightMap.Location = new System.Drawing.Point(19, 182);
            this.comboBoxLightMap.Name = "comboBoxLightMap";
            this.comboBoxLightMap.Size = new System.Drawing.Size(249, 36);
            this.comboBoxLightMap.StartIndex = 1;
            this.comboBoxLightMap.TabIndex = 2;
            this.comboBoxLightMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxLightMap_SelectedIndexChanged);
            // 
            // comboBoxSpecularMap
            // 
            this.comboBoxSpecularMap.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSpecularMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSpecularMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecularMap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.comboBoxSpecularMap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSpecularMap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSpecularMap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSpecularMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSpecularMap.ItemHeight = 30;
            this.comboBoxSpecularMap.Items.AddRange(new object[] {
            "Disable",
            "Enable",
            "Chrome"});
            this.comboBoxSpecularMap.Location = new System.Drawing.Point(19, 261);
            this.comboBoxSpecularMap.Name = "comboBoxSpecularMap";
            this.comboBoxSpecularMap.Size = new System.Drawing.Size(249, 36);
            this.comboBoxSpecularMap.StartIndex = 1;
            this.comboBoxSpecularMap.TabIndex = 3;
            this.comboBoxSpecularMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecularMap_SelectedIndexChanged);
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelMovie.Location = new System.Drawing.Point(83, 328);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(56, 21);
            this.labelMovie.TabIndex = 7;
            this.labelMovie.Text = "Movie";
            // 
            // switchMovie
            // 
            this.switchMovie.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchMovie.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchMovie.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchMovie.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchMovie.Location = new System.Drawing.Point(157, 329);
            this.switchMovie.Name = "switchMovie";
            this.switchMovie.Size = new System.Drawing.Size(35, 20);
            this.switchMovie.TabIndex = 6;
            this.switchMovie.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchMovie.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchMovie.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchMovie.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchMovie.CheckedChanged += new System.EventHandler(this.switchMovie_CheckedChanged);
            // 
            // labelSpecularmap
            // 
            this.labelSpecularmap.AutoSize = true;
            this.labelSpecularmap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecularmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelSpecularmap.Location = new System.Drawing.Point(86, 237);
            this.labelSpecularmap.Name = "labelSpecularmap";
            this.labelSpecularmap.Size = new System.Drawing.Size(106, 21);
            this.labelSpecularmap.TabIndex = 8;
            this.labelSpecularmap.Text = "SpecularMap";
            // 
            // labelLightmap
            // 
            this.labelLightmap.AutoSize = true;
            this.labelLightmap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLightmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelLightmap.Location = new System.Drawing.Point(96, 158);
            this.labelLightmap.Name = "labelLightmap";
            this.labelLightmap.Size = new System.Drawing.Size(80, 21);
            this.labelLightmap.TabIndex = 9;
            this.labelLightmap.Text = "LightMap";
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
            // UC_Visuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.labelFovValue);
            this.Controls.Add(this.labelFpsValue);
            this.Controls.Add(this.labelFov);
            this.Controls.Add(this.labelFps);
            this.Controls.Add(this.labelLightmap);
            this.Controls.Add(this.labelSpecularmap);
            this.Controls.Add(this.labelMovie);
            this.Controls.Add(this.switchMovie);
            this.Controls.Add(this.comboBoxSpecularMap);
            this.Controls.Add(this.comboBoxLightMap);
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
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxLightMap;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSpecularMap;
        private System.Windows.Forms.Label labelMovie;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchMovie;
        private System.Windows.Forms.Label labelSpecularmap;
        private System.Windows.Forms.Label labelLightmap;
        private System.Windows.Forms.Label labelFps;
        private System.Windows.Forms.Label labelFov;
        private System.Windows.Forms.Label labelFpsValue;
        private System.Windows.Forms.Label labelFovValue;
        private System.Windows.Forms.Timer update_timer;
    }
}
