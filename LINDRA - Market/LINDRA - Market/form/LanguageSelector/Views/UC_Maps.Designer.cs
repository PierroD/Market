namespace LINDRA___Market.form.LanguageSelector.Views
{
    partial class UC_Maps
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
            this.buttonClear = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonClear.Location = new System.Drawing.Point(435, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(38, 36);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "✕";
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
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
            this.textBoxSearch.PlaceholderText = "Search map...";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(426, 36);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(470, 347);
            this.flowLayoutPanelResults.TabIndex = 5;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(6, 396);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(53, 13);
            this.labelResults.TabIndex = 6;
            this.labelResults.Text = "Results : ";
            // 
            // UC_Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "UC_Maps";
            this.Size = new System.Drawing.Size(476, 412);
            this.Load += new System.EventHandler(this.UC_Maps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonClear;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private System.Windows.Forms.Label labelResults;
    }
}
