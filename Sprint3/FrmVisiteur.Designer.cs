// 1. FrmVisiteur.Designer.cs (Code corrigé)
namespace Sprint3
{
    partial class FrmVisiteur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDunProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDunPraticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comtpesrendusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(571, 97);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(39, 36);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.saisieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheDunProduitToolStripMenuItem,
            this.ficheDunPraticienToolStripMenuItem,
            this.comtpesrendusToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // ficheDunProduitToolStripMenuItem
            // 
            this.ficheDunProduitToolStripMenuItem.Name = "ficheDunProduitToolStripMenuItem";
            this.ficheDunProduitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ficheDunProduitToolStripMenuItem.Text = "Fiche du produit";
            // 
            // ficheDunPraticienToolStripMenuItem
            // 
            this.ficheDunPraticienToolStripMenuItem.Name = "ficheDunPraticienToolStripMenuItem";
            this.ficheDunPraticienToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ficheDunPraticienToolStripMenuItem.Text = "Fiche du praticien";
            this.ficheDunPraticienToolStripMenuItem.Click += new System.EventHandler(this.ficheDunPraticienToolStripMenuItem_Click);
            // 
            // comtpesrendusToolStripMenuItem
            // 
            this.comtpesrendusToolStripMenuItem.Name = "comtpesrendusToolStripMenuItem";
            this.comtpesrendusToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.comtpesrendusToolStripMenuItem.Text = "Mes Comtpes-rendus";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauRapportToolStripMenuItem});
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.saisieToolStripMenuItem.Text = "Saisie";
            // 
            // nouveauRapportToolStripMenuItem
            // 
            this.nouveauRapportToolStripMenuItem.Name = "nouveauRapportToolStripMenuItem";
            this.nouveauRapportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nouveauRapportToolStripMenuItem.Text = "Nouveau rapport";
            this.nouveauRapportToolStripMenuItem.Click += new System.EventHandler(this.nouveauRapportToolStripMenuItem_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(40, 487);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(135, 45);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // FrmVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sprint3.Properties.Resources.equipements_de_sante_et_fournitures_de_bureau_avec_plante_succulente_sur_fond_vert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 605);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVisiteur";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDunProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDunPraticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comtpesrendusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.ToolStripMenuItem nouveauRapportToolStripMenuItem;
    }
}