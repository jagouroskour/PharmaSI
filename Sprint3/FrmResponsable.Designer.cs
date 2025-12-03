
namespace Sprint3
{
    partial class FrmResponsable
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
            this.ficheDuProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheDuPraticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compterendusDuSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(587, 103);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(39, 36);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "...";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(64, 483);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(123, 45);
            this.btnDeconnexion.TabIndex = 11;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheDuProduitToolStripMenuItem,
            this.ficheDuPraticienToolStripMenuItem,
            this.compterendusDuSecteurToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // ficheDuProduitToolStripMenuItem
            // 
            this.ficheDuProduitToolStripMenuItem.Name = "ficheDuProduitToolStripMenuItem";
            this.ficheDuProduitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ficheDuProduitToolStripMenuItem.Text = "Fiche du produit";
            // 
            // ficheDuPraticienToolStripMenuItem
            // 
            this.ficheDuPraticienToolStripMenuItem.Name = "ficheDuPraticienToolStripMenuItem";
            this.ficheDuPraticienToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ficheDuPraticienToolStripMenuItem.Text = "Fiche du praticien";
            this.ficheDuPraticienToolStripMenuItem.Click += new System.EventHandler(this.ficheDuPraticienToolStripMenuItem_Click_1);
            // 
            // compterendusDuSecteurToolStripMenuItem
            // 
            this.compterendusDuSecteurToolStripMenuItem.Name = "compterendusDuSecteurToolStripMenuItem";
            this.compterendusDuSecteurToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.compterendusDuSecteurToolStripMenuItem.Text = "Compte-rendus du secteur";
            // 
            // FrmResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sprint3.Properties.Resources.equipements_de_sante_et_fournitures_de_bureau_avec_plante_succulente_sur_fond_vert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 597);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmResponsable";
            this.Text = "FrmResponsable";
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
        private System.Windows.Forms.ToolStripMenuItem ficheDuProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheDuPraticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compterendusDuSecteurToolStripMenuItem;
    }
}