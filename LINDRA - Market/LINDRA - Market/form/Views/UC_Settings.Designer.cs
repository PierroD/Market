namespace LINDRA___Market.form.Views
{
    partial class UC_Settings
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
            this.labelLoad = new System.Windows.Forms.Label();
            this.comboboxLoad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSave = new System.Windows.Forms.Label();
            this.textboxSave = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonLoad = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelLoad.Location = new System.Drawing.Point(17, 78);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(97, 21);
            this.labelLoad.TabIndex = 10;
            this.labelLoad.Text = "Load config";
            // 
            // comboboxLoad
            // 
            this.comboboxLoad.BackColor = System.Drawing.Color.Transparent;
            this.comboboxLoad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxLoad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxLoad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxLoad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxLoad.ItemHeight = 30;
            this.comboboxLoad.Location = new System.Drawing.Point(12, 102);
            this.comboboxLoad.Name = "comboboxLoad";
            this.comboboxLoad.Size = new System.Drawing.Size(204, 36);
            this.comboboxLoad.TabIndex = 9;
            this.comboboxLoad.Click += new System.EventHandler(this.comboboxLoad_Click);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelSave.Location = new System.Drawing.Point(17, 189);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(95, 21);
            this.labelSave.TabIndex = 11;
            this.labelSave.Text = "Save config";
            // 
            // textboxSave
            // 
            this.textboxSave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxSave.DefaultText = "";
            this.textboxSave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxSave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxSave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxSave.Location = new System.Drawing.Point(16, 213);
            this.textboxSave.Name = "textboxSave";
            this.textboxSave.PasswordChar = '\0';
            this.textboxSave.PlaceholderText = "config name";
            this.textboxSave.SelectedText = "";
            this.textboxSave.Size = new System.Drawing.Size(200, 36);
            this.textboxSave.TabIndex = 12;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Animated = true;
            this.buttonLoad.AutoRoundedCorners = true;
            this.buttonLoad.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoad.BorderRadius = 17;
            this.buttonLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonLoad.Location = new System.Drawing.Point(222, 102);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 36);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseTransparentBackground = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Animated = true;
            this.buttonSave.AutoRoundedCorners = true;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BorderRadius = 17;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.buttonSave.Location = new System.Drawing.Point(222, 213);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 36);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseTransparentBackground = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textboxSave);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.comboboxLoad);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(300, 387);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoad;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxLoad;
        private System.Windows.Forms.Label labelSave;
        private Guna.UI2.WinForms.Guna2TextBox textboxSave;
        private Guna.UI2.WinForms.Guna2Button buttonLoad;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
    }
}
