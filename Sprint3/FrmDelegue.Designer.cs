
namespace Sprint3
{
    partial class FrmDelegue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDunProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDunPraticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comtpesrendusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compterendusDeLéquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(1046, 171);
            this.lblBienvenue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(75, 72);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "...";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(138, 871);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(232, 87);
            this.btnDeconnexion.TabIndex = 11;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.saisieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2250, 46);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheDunProduitToolStripMenuItem,
            this.ficheDunPraticienToolStripMenuItem,
            this.comtpesrendusToolStripMenuItem,
            this.compterendusDeLéquipeToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(170, 38);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // ficheDunProduitToolStripMenuItem
            // 
            this.ficheDunProduitToolStripMenuItem.Name = "ficheDunProduitToolStripMenuItem";
            this.ficheDunProduitToolStripMenuItem.Size = new System.Drawing.Size(444, 44);
            this.ficheDunProduitToolStripMenuItem.Text = "Fiche du produit";
            this.ficheDunProduitToolStripMenuItem.Click += new System.EventHandler(this.ficheDunProduitToolStripMenuItem_Click);
            // 
            // ficheDunPraticienToolStripMenuItem
            // 
            this.ficheDunPraticienToolStripMenuItem.Name = "ficheDunPraticienToolStripMenuItem";
            this.ficheDunPraticienToolStripMenuItem.Size = new System.Drawing.Size(444, 44);
            this.ficheDunPraticienToolStripMenuItem.Text = "Fiche du praticien";
            this.ficheDunPraticienToolStripMenuItem.Click += new System.EventHandler(this.ficheDunPraticienToolStripMenuItem_Click);
            // 
            // comtpesrendusToolStripMenuItem
            // 
            this.comtpesrendusToolStripMenuItem.Name = "comtpesrendusToolStripMenuItem";
            this.comtpesrendusToolStripMenuItem.Size = new System.Drawing.Size(444, 44);
            this.comtpesrendusToolStripMenuItem.Text = "Mes Comtpes-rendus";
            // 
            // compterendusDeLéquipeToolStripMenuItem
            // 
            this.compterendusDeLéquipeToolStripMenuItem.Name = "compterendusDeLéquipeToolStripMenuItem";
            this.compterendusDeLéquipeToolStripMenuItem.Size = new System.Drawing.Size(444, 44);
            this.compterendusDeLéquipeToolStripMenuItem.Text = "Compte-rendus de l\'équipe";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauRapportToolStripMenuItem});
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(95, 38);
            this.saisieToolStripMenuItem.Text = "Saisie";
            // 
            // nouveauRapportToolStripMenuItem
            // 
            this.nouveauRapportToolStripMenuItem.Name = "nouveauRapportToolStripMenuItem";
            this.nouveauRapportToolStripMenuItem.Size = new System.Drawing.Size(331, 44);
            this.nouveauRapportToolStripMenuItem.Text = "Nouveau rapport";
            // 
            // FrmDelegue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sprint3.Properties.Resources.equipements_de_sante_et_fournitures_de_bureau_avec_plante_succulente_sur_fond_vert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2250, 1085);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.lblBienvenue);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmDelegue";
            this.Text = "FrmDelegue";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDunProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDunPraticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comtpesrendusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compterendusDeLéquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauRapportToolStripMenuItem;
    }
}