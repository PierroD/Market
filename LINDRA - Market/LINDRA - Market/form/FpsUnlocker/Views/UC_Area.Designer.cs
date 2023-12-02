namespace LINDRA___Market.form.FpsUnlocker.Views
{
    partial class UC_Area
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
            this.trackbarSafeAreaX = new Guna.UI2.WinForms.Guna2TrackBar();
            this.trackbarSafeAreaY = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.labelSafeArea = new System.Windows.Forms.Label();
            this.labelSafeAreaXValue = new System.Windows.Forms.Label();
            this.labelSafeAreaYValue = new System.Windows.Forms.Label();
            this.update_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // trackbarSafeAreaX
            // 
            this.trackbarSafeAreaX.Location = new System.Drawing.Point(24, 66);
            this.trackbarSafeAreaX.Name = "trackbarSafeAreaX";
            this.trackbarSafeAreaX.Size = new System.Drawing.Size(212, 23);
            this.trackbarSafeAreaX.TabIndex = 0;
            this.trackbarSafeAreaX.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarSafeAreaX.Value = 100;
            this.trackbarSafeAreaX.ValueChanged += new System.EventHandler(this.trackbarSafeAreaX_ValueChanged);
            // 
            // trackbarSafeAreaY
            // 
            this.trackbarSafeAreaY.Location = new System.Drawing.Point(213, 105);
            this.trackbarSafeAreaY.Name = "trackbarSafeAreaY";
            this.trackbarSafeAreaY.Size = new System.Drawing.Size(23, 212);
            this.trackbarSafeAreaY.TabIndex = 1;
            this.trackbarSafeAreaY.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarSafeAreaY.Value = 100;
            this.trackbarSafeAreaY.ValueChanged += new System.EventHandler(this.trackbarSafeAreaY_ValueChanged);
            // 
            // labelSafeArea
            // 
            this.labelSafeArea.AutoSize = true;
            this.labelSafeArea.BackColor = System.Drawing.Color.Transparent;
            this.labelSafeArea.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSafeArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelSafeArea.Location = new System.Drawing.Point(103, 12);
            this.labelSafeArea.Name = "labelSafeArea";
            this.labelSafeArea.Size = new System.Drawing.Size(80, 21);
            this.labelSafeArea.TabIndex = 14;
            this.labelSafeArea.Text = "Safe Area";
            // 
            // labelSafeAreaXValue
            // 
            this.labelSafeAreaXValue.AutoSize = true;
            this.labelSafeAreaXValue.BackColor = System.Drawing.Color.Transparent;
            this.labelSafeAreaXValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSafeAreaXValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelSafeAreaXValue.Location = new System.Drawing.Point(242, 68);
            this.labelSafeAreaXValue.Name = "labelSafeAreaXValue";
            this.labelSafeAreaXValue.Size = new System.Drawing.Size(38, 21);
            this.labelSafeAreaXValue.TabIndex = 15;
            this.labelSafeAreaXValue.Text = "1.00";
            // 
            // labelSafeAreaYValue
            // 
            this.labelSafeAreaYValue.AutoSize = true;
            this.labelSafeAreaYValue.BackColor = System.Drawing.Color.Transparent;
            this.labelSafeAreaYValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSafeAreaYValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelSafeAreaYValue.Location = new System.Drawing.Point(209, 320);
            this.labelSafeAreaYValue.Name = "labelSafeAreaYValue";
            this.labelSafeAreaYValue.Size = new System.Drawing.Size(38, 21);
            this.labelSafeAreaYValue.TabIndex = 16;
            this.labelSafeAreaYValue.Text = "1.00";
            // 
            // update_timer
            // 
            this.update_timer.Enabled = true;
            this.update_timer.Tick += new System.EventHandler(this.update_timer_Tick);
            // 
            // UC_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSafeAreaYValue);
            this.Controls.Add(this.labelSafeAreaXValue);
            this.Controls.Add(this.labelSafeArea);
            this.Controls.Add(this.trackbarSafeAreaY);
            this.Controls.Add(this.trackbarSafeAreaX);
            this.Name = "UC_Area";
            this.Size = new System.Drawing.Size(300, 387);
            this.Load += new System.EventHandler(this.UC_Area_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar trackbarSafeAreaX;
        private Guna.UI2.WinForms.Guna2VTrackBar trackbarSafeAreaY;
        private System.Windows.Forms.Label labelSafeArea;
        private System.Windows.Forms.Label labelSafeAreaXValue;
        private System.Windows.Forms.Label labelSafeAreaYValue;
        private System.Windows.Forms.Timer update_timer;
    }
}
