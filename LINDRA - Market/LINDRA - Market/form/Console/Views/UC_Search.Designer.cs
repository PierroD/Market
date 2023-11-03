namespace LINDRA___Market.form.Console.Views
{
    partial class UC_Search
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
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonClear = new Guna.UI2.WinForms.Guna2Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxDvarList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelDvarList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search dvar...";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 36);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
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
            this.buttonClear.Location = new System.Drawing.Point(222, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(38, 36);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "✕";
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(3, 303);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(53, 13);
            this.labelResults.TabIndex = 3;
            this.labelResults.Text = "Results : ";
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(6, 45);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(461, 255);
            this.flowLayoutPanelResults.TabIndex = 4;
            // 
            // comboBoxDvarList
            // 
            this.comboBoxDvarList.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxDvarList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDvarList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDvarList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDvarList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDvarList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxDvarList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxDvarList.ItemHeight = 30;
            this.comboBoxDvarList.Location = new System.Drawing.Point(326, 5);
            this.comboBoxDvarList.Name = "comboBoxDvarList";
            this.comboBoxDvarList.Size = new System.Drawing.Size(140, 36);
            this.comboBoxDvarList.TabIndex = 5;
            // 
            // labelDvarList
            // 
            this.labelDvarList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDvarList.Location = new System.Drawing.Point(266, 5);
            this.labelDvarList.Name = "labelDvarList";
            this.labelDvarList.Size = new System.Drawing.Size(54, 34);
            this.labelDvarList.TabIndex = 6;
            this.labelDvarList.Text = "Selected Dvar list";
            this.labelDvarList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelDvarList);
            this.Controls.Add(this.comboBoxDvarList);
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(470, 320);
            this.Load += new System.EventHandler(this.UC_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxDvarList;
        private System.Windows.Forms.Label labelDvarList;
    }
}
