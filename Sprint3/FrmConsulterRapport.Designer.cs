namespace Sprint3
{
    partial class FrmConsulterRapport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.lblMotifVal = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblPraticienVal = new System.Windows.Forms.Label();
            this.lblPraticien = new System.Windows.Forms.Label();
            this.lblDateVal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAuteurVal = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.cboRapports = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.pnlBilan = new System.Windows.Forms.Panel();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.lblTitreBilan = new System.Windows.Forms.Label();
            this.pnlProduits = new System.Windows.Forms.Panel();
            this.lblQte2 = new System.Windows.Forms.Label();
            this.lblProd2 = new System.Windows.Forms.Label();
            this.lblQte1 = new System.Windows.Forms.Label();
            this.lblProd1 = new System.Windows.Forms.Label();
            this.lblColQte = new System.Windows.Forms.Label();
            this.lblColProd = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDunProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDuPraticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comtpesrendusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDeRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInfos.SuspendLayout();
            this.pnlBilan.SuspendLayout();
            this.pnlProduits.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(420, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation de Rapport";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.White;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Location = new System.Drawing.Point(750, 430);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(120, 40);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlInfos
            // 
            this.pnlInfos.BackColor = System.Drawing.Color.Honeydew;
            this.pnlInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfos.Controls.Add(this.lblMotifVal);
            this.pnlInfos.Controls.Add(this.lblMotif);
            this.pnlInfos.Controls.Add(this.lblPraticienVal);
            this.pnlInfos.Controls.Add(this.lblPraticien);
            this.pnlInfos.Controls.Add(this.lblDateVal);
            this.pnlInfos.Controls.Add(this.lblDate);
            this.pnlInfos.Controls.Add(this.lblAuteurVal);
            this.pnlInfos.Controls.Add(this.lblAuteur);
            this.pnlInfos.Controls.Add(this.cboRapports);
            this.pnlInfos.Controls.Add(this.lblSelect);
            this.pnlInfos.Location = new System.Drawing.Point(300, 100);
            this.pnlInfos.Name = "pnlInfos";
            this.pnlInfos.Size = new System.Drawing.Size(650, 130);
            this.pnlInfos.TabIndex = 1;
            // 
            // lblMotifVal
            // 
            this.lblMotifVal.AutoSize = true;
            this.lblMotifVal.Location = new System.Drawing.Point(430, 97);
            this.lblMotifVal.Name = "lblMotifVal";
            this.lblMotifVal.Size = new System.Drawing.Size(10, 13);
            this.lblMotifVal.TabIndex = 0;
            this.lblMotifVal.Text = "-";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMotif.Location = new System.Drawing.Point(350, 95);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(53, 19);
            this.lblMotif.TabIndex = 1;
            this.lblMotif.Text = "Motif :";
            // 
            // lblPraticienVal
            // 
            this.lblPraticienVal.AutoSize = true;
            this.lblPraticienVal.Location = new System.Drawing.Point(430, 62);
            this.lblPraticienVal.Name = "lblPraticienVal";
            this.lblPraticienVal.Size = new System.Drawing.Size(10, 13);
            this.lblPraticienVal.TabIndex = 2;
            this.lblPraticienVal.Text = "-";
            // 
            // lblPraticien
            // 
            this.lblPraticien.AutoSize = true;
            this.lblPraticien.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPraticien.Location = new System.Drawing.Point(350, 60);
            this.lblPraticien.Name = "lblPraticien";
            this.lblPraticien.Size = new System.Drawing.Size(76, 19);
            this.lblPraticien.TabIndex = 3;
            this.lblPraticien.Text = "Praticien :";
            // 
            // lblDateVal
            // 
            this.lblDateVal.AutoSize = true;
            this.lblDateVal.Location = new System.Drawing.Point(90, 97);
            this.lblDateVal.Name = "lblDateVal";
            this.lblDateVal.Size = new System.Drawing.Size(10, 13);
            this.lblDateVal.TabIndex = 4;
            this.lblDateVal.Text = "-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(20, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 19);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date :";
            // 
            // lblAuteurVal
            // 
            this.lblAuteurVal.AutoSize = true;
            this.lblAuteurVal.Location = new System.Drawing.Point(90, 62);
            this.lblAuteurVal.Name = "lblAuteurVal";
            this.lblAuteurVal.Size = new System.Drawing.Size(10, 13);
            this.lblAuteurVal.TabIndex = 6;
            this.lblAuteurVal.Text = "-";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAuteur.Location = new System.Drawing.Point(20, 60);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(62, 19);
            this.lblAuteur.TabIndex = 7;
            this.lblAuteur.Text = "Auteur :";
            // 
            // cboRapports
            // 
            this.cboRapports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRapports.FormattingEnabled = true;
            this.cboRapports.Location = new System.Drawing.Point(220, 20);
            this.cboRapports.Name = "cboRapports";
            this.cboRapports.Size = new System.Drawing.Size(400, 21);
            this.cboRapports.TabIndex = 8;
            this.cboRapports.SelectedIndexChanged += new System.EventHandler(this.cboRapports_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(20, 20);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(176, 19);
            this.lblSelect.TabIndex = 9;
            this.lblSelect.Text = "Sélectionner un rapport :";
            // 
            // pnlBilan
            // 
            this.pnlBilan.BackColor = System.Drawing.Color.Honeydew;
            this.pnlBilan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBilan.Controls.Add(this.txtBilan);
            this.pnlBilan.Controls.Add(this.lblTitreBilan);
            this.pnlBilan.Location = new System.Drawing.Point(300, 245);
            this.pnlBilan.Name = "pnlBilan";
            this.pnlBilan.Size = new System.Drawing.Size(650, 120);
            this.pnlBilan.TabIndex = 2;
            // 
            // txtBilan
            // 
            this.txtBilan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBilan.Location = new System.Drawing.Point(24, 35);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.ReadOnly = true;
            this.txtBilan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBilan.Size = new System.Drawing.Size(600, 70);
            this.txtBilan.TabIndex = 0;
            // 
            // lblTitreBilan
            // 
            this.lblTitreBilan.AutoSize = true;
            this.lblTitreBilan.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreBilan.Location = new System.Drawing.Point(20, 10);
            this.lblTitreBilan.Name = "lblTitreBilan";
            this.lblTitreBilan.Size = new System.Drawing.Size(50, 19);
            this.lblTitreBilan.TabIndex = 1;
            this.lblTitreBilan.Text = "Bilan :";
            // 
            // pnlProduits
            // 
            this.pnlProduits.BackColor = System.Drawing.Color.Honeydew;
            this.pnlProduits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduits.Controls.Add(this.lblQte2);
            this.pnlProduits.Controls.Add(this.lblProd2);
            this.pnlProduits.Controls.Add(this.lblQte1);
            this.pnlProduits.Controls.Add(this.lblProd1);
            this.pnlProduits.Controls.Add(this.lblColQte);
            this.pnlProduits.Controls.Add(this.lblColProd);
            this.pnlProduits.Location = new System.Drawing.Point(300, 380);
            this.pnlProduits.Name = "pnlProduits";
            this.pnlProduits.Size = new System.Drawing.Size(380, 100);
            this.pnlProduits.TabIndex = 3;
            // 
            // lblQte2
            // 
            this.lblQte2.AutoSize = true;
            this.lblQte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQte2.Location = new System.Drawing.Point(255, 70);
            this.lblQte2.Name = "lblQte2";
            this.lblQte2.Size = new System.Drawing.Size(11, 15);
            this.lblQte2.TabIndex = 0;
            this.lblQte2.Text = "-";
            // 
            // lblProd2
            // 
            this.lblProd2.AutoSize = true;
            this.lblProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProd2.Location = new System.Drawing.Point(25, 70);
            this.lblProd2.Name = "lblProd2";
            this.lblProd2.Size = new System.Drawing.Size(11, 15);
            this.lblProd2.TabIndex = 1;
            this.lblProd2.Text = "-";
            // 
            // lblQte1
            // 
            this.lblQte1.AutoSize = true;
            this.lblQte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQte1.Location = new System.Drawing.Point(255, 45);
            this.lblQte1.Name = "lblQte1";
            this.lblQte1.Size = new System.Drawing.Size(11, 15);
            this.lblQte1.TabIndex = 2;
            this.lblQte1.Text = "-";
            // 
            // lblProd1
            // 
            this.lblProd1.AutoSize = true;
            this.lblProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProd1.Location = new System.Drawing.Point(25, 45);
            this.lblProd1.Name = "lblProd1";
            this.lblProd1.Size = new System.Drawing.Size(11, 15);
            this.lblProd1.TabIndex = 3;
            this.lblProd1.Text = "-";
            // 
            // lblColQte
            // 
            this.lblColQte.AutoSize = true;
            this.lblColQte.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblColQte.Location = new System.Drawing.Point(250, 10);
            this.lblColQte.Name = "lblColQte";
            this.lblColQte.Size = new System.Drawing.Size(41, 19);
            this.lblColQte.TabIndex = 4;
            this.lblColQte.Text = "Qté :";
            // 
            // lblColProd
            // 
            this.lblColProd.AutoSize = true;
            this.lblColProd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblColProd.Location = new System.Drawing.Point(20, 10);
            this.lblColProd.Name = "lblColProd";
            this.lblColProd.Size = new System.Drawing.Size(122, 19);
            this.lblColProd.TabIndex = 5;
            this.lblColProd.Text = "Produit (max 2) :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.saisieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheDunProduitToolStripMenuItem,
            this.ficheDuPraticienToolStripMenuItem,
            this.comtpesrendusToolStripMenuItem,
            this.consultationDeRapportToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // ficheDunProduitToolStripMenuItem
            // 
            this.ficheDunProduitToolStripMenuItem.Name = "ficheDunProduitToolStripMenuItem";
            this.ficheDunProduitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ficheDunProduitToolStripMenuItem.Text = "Fiche du produit";
            // 
            // ficheDuPraticienToolStripMenuItem
            // 
            this.ficheDuPraticienToolStripMenuItem.Name = "ficheDuPraticienToolStripMenuItem";
            this.ficheDuPraticienToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ficheDuPraticienToolStripMenuItem.Text = "Fiche du praticien";
            // 
            // comtpesrendusToolStripMenuItem
            // 
            this.comtpesrendusToolStripMenuItem.Name = "comtpesrendusToolStripMenuItem";
            this.comtpesrendusToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.comtpesrendusToolStripMenuItem.Text = "Mes Comptes-rendus";
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
            // 
            // consultationDeRapportToolStripMenuItem
            // 
            this.consultationDeRapportToolStripMenuItem.Name = "consultationDeRapportToolStripMenuItem";
            this.consultationDeRapportToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultationDeRapportToolStripMenuItem.Text = "Consultation de Rapport";
            this.consultationDeRapportToolStripMenuItem.Click += new System.EventHandler(this.consultationDeRapportToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sprint3.Properties.Resources.equipements_de_sante_et_fournitures_de_bureau_avec_plante_succulente_sur_fond_vert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.pnlProduits);
            this.Controls.Add(this.pnlBilan);
            this.Controls.Add(this.pnlInfos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Consultation Rapport";
            this.pnlInfos.ResumeLayout(false);
            this.pnlInfos.PerformLayout();
            this.pnlBilan.ResumeLayout(false);
            this.pnlBilan.PerformLayout();
            this.pnlProduits.ResumeLayout(false);
            this.pnlProduits.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel pnlInfos;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cboRapports;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblAuteurVal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateVal;
        private System.Windows.Forms.Label lblPraticien;
        private System.Windows.Forms.Label lblPraticienVal;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblMotifVal;
        private System.Windows.Forms.Panel pnlBilan;
        private System.Windows.Forms.Label lblTitreBilan;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Panel pnlProduits;
        private System.Windows.Forms.Label lblColProd;
        private System.Windows.Forms.Label lblColQte;
        private System.Windows.Forms.Label lblProd1;
        private System.Windows.Forms.Label lblQte1;
        private System.Windows.Forms.Label lblProd2;
        private System.Windows.Forms.Label lblQte2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDunProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDuPraticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comtpesrendusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDeRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauRapportToolStripMenuItem;
    }
}