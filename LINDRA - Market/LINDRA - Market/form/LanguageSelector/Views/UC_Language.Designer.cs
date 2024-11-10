namespace LINDRA___Market.form.LanguageSelector.Views
{
    partial class UC_Language
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
            this.labelAvailableLanguages = new System.Windows.Forms.Label();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // labelAvailableLanguages
            // 
            this.labelAvailableLanguages.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableLanguages.Location = new System.Drawing.Point(0, 0);
            this.labelAvailableLanguages.Name = "labelAvailableLanguages";
            this.labelAvailableLanguages.Size = new System.Drawing.Size(150, 37);
            this.labelAvailableLanguages.TabIndex = 7;
            this.labelAvailableLanguages.Text = "Available Language";
            this.labelAvailableLanguages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // UC_Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelAvailableLanguages);
            this.Name = "UC_Language";
            this.Size = new System.Drawing.Size(150, 37);
            this.Load += new System.EventHandler(this.UC_Language_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAvailableLanguages;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
    }
}
