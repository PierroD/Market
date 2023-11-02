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
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.labelMacro = new System.Windows.Forms.Label();
            this.comboBoxMacro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonBindMacro = new Guna.UI2.WinForms.Guna2Button();
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
            this.textBoxEntry.Location = new System.Drawing.Point(3, 3);
            this.textBoxEntry.Multiline = true;
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.PasswordChar = '\0';
            this.textBoxEntry.PlaceholderText = "";
            this.textBoxEntry.SelectedText = "";
            this.textBoxEntry.Size = new System.Drawing.Size(272, 314);
            this.textBoxEntry.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.BorderRadius = 8;
            this.buttonSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(281, 272);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(180, 45);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            // 
            // buttonClear
            // 
            this.buttonClear.BorderRadius = 8;
            this.buttonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(201, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(71, 42);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BorderRadius = 8;
            this.buttonLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(390, 6);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(71, 42);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            // 
            // buttonSave
            // 
            this.buttonSave.BorderRadius = 8;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(390, 54);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(71, 42);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(281, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(103, 42);
            this.textBoxName.TabIndex = 5;
            // 
            // separator
            // 
            this.separator.Location = new System.Drawing.Point(281, 102);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(180, 10);
            this.separator.TabIndex = 6;
            // 
            // labelMacro
            // 
            this.labelMacro.Location = new System.Drawing.Point(281, 118);
            this.labelMacro.Name = "labelMacro";
            this.labelMacro.Size = new System.Drawing.Size(180, 13);
            this.labelMacro.TabIndex = 7;
            this.labelMacro.Text = "Bind a macro to the config";
            this.labelMacro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMacro
            // 
            this.comboBoxMacro.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxMacro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMacro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMacro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMacro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMacro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxMacro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxMacro.ItemHeight = 30;
            this.comboBoxMacro.Location = new System.Drawing.Point(281, 134);
            this.comboBoxMacro.Name = "comboBoxMacro";
            this.comboBoxMacro.Size = new System.Drawing.Size(180, 36);
            this.comboBoxMacro.TabIndex = 8;
            // 
            // buttonBindMacro
            // 
            this.buttonBindMacro.BorderRadius = 8;
            this.buttonBindMacro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBindMacro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBindMacro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBindMacro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBindMacro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBindMacro.ForeColor = System.Drawing.Color.White;
            this.buttonBindMacro.Location = new System.Drawing.Point(305, 176);
            this.buttonBindMacro.Name = "buttonBindMacro";
            this.buttonBindMacro.Size = new System.Drawing.Size(136, 36);
            this.buttonBindMacro.TabIndex = 9;
            this.buttonBindMacro.Text = "Bind";
            // 
            // UC_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBindMacro);
            this.Controls.Add(this.comboBoxMacro);
            this.Controls.Add(this.labelMacro);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxEntry);
            this.Name = "UC_Console";
            this.Size = new System.Drawing.Size(470, 320);
            this.Load += new System.EventHandler(this.UC_Console_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxEntry;
        private Guna.UI2.WinForms.Guna2Button buttonSend;
        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private Guna.UI2.WinForms.Guna2Button buttonLoad;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private System.Windows.Forms.Label labelMacro;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMacro;
        private Guna.UI2.WinForms.Guna2Button buttonBindMacro;
    }
}
