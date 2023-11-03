namespace LINDRA___Market.form.Console.Views
{
    partial class UC_Console
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
            this.textBoxEntry = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonSend = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClear = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLoad = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialogConfig = new System.Windows.Forms.OpenFileDialog();
            this.labelConfigName = new System.Windows.Forms.Label();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.BorderRadius = 8;
            this.textBoxEntry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEntry.DefaultText = "";
            this.textBoxEntry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxEntry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxEntry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEntry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEntry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEntry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxEntry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEntry.Location = new System.Drawing.Point(3, 24);
            this.textBoxEntry.Multiline = true;
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.PasswordChar = '\0';
            this.textBoxEntry.PlaceholderText = "";
            this.textBoxEntry.SelectedText = "";
            this.textBoxEntry.Size = new System.Drawing.Size(272, 293);
            this.textBoxEntry.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.BorderRadius = 8;
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(279, 280);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(188, 37);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BorderRadius = 8;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(216, 28);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 30);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BorderRadius = 8;
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(354, 6);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(113, 30);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load config";
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialogConfig
            // 
            this.openFileDialogConfig.DefaultExt = "cfg";
            this.openFileDialogConfig.Filter = "Cfg files(*.cfg)|*.cfg|Text Files (*.txt)|*.txt";
            this.openFileDialogConfig.Multiselect = true;
            this.openFileDialogConfig.Title = "External Console open config files";
            // 
            // labelConfigName
            // 
            this.labelConfigName.AutoSize = true;
            this.labelConfigName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigName.Location = new System.Drawing.Point(3, 6);
            this.labelConfigName.Name = "labelConfigName";
            this.labelConfigName.Size = new System.Drawing.Size(53, 13);
            this.labelConfigName.TabIndex = 10;
            this.labelConfigName.Text = "Configs :";
            // 
            // buttonSave
            // 
            this.buttonSave.BorderRadius = 8;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(354, 50);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 30);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveFileDialogConfig
            // 
            this.saveFileDialogConfig.Filter = "Cfg files(*.cfg)|*.cfg|Text Files (*.txt)|*.txt";
            this.saveFileDialogConfig.Title = "Save the config as a file";
            // 
            // UC_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelConfigName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxEntry);
            this.Name = "UC_Console";
            this.Size = new System.Drawing.Size(470, 320);
            this.Load += new System.EventHandler(this.UC_Console_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxEntry;
        private Guna.UI2.WinForms.Guna2Button buttonSend;
        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private Guna.UI2.WinForms.Guna2Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialogConfig;
        private System.Windows.Forms.Label labelConfigName;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
    }
}
