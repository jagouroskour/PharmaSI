
namespace Sprint3
{
    partial class FrmConsulter
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
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCoef = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.cboPraticiens = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Red;
            this.btnDeconnexion.Location = new System.Drawing.Point(33, 363);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(103, 39);
            this.btnDeconnexion.TabIndex = 17;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Liste des diplômes et spécialirétés :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.lblCoef);
            this.groupBox1.Controls.Add(this.lblVille);
            this.groupBox1.Location = new System.Drawing.Point(33, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 179);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information générales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Notoriété :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ville :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(147, 51);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(16, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "...";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(147, 86);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(16, 13);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "...";
            // 
            // lblCoef
            // 
            this.lblCoef.AutoSize = true;
            this.lblCoef.Location = new System.Drawing.Point(147, 157);
            this.lblCoef.Name = "lblCoef";
            this.lblCoef.Size = new System.Drawing.Size(16, 13);
            this.lblCoef.TabIndex = 6;
            this.lblCoef.Text = "...";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(147, 123);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(16, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sélectionner un praticien :";
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(431, 186);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(357, 83);
            this.dgvDetails.TabIndex = 13;
            // 
            // cboPraticiens
            // 
            this.cboPraticiens.FormattingEnabled = true;
            this.cboPraticiens.Location = new System.Drawing.Point(453, 90);
            this.cboPraticiens.Name = "cboPraticiens";
            this.cboPraticiens.Size = new System.Drawing.Size(104, 21);
            this.cboPraticiens.TabIndex = 12;
            this.cboPraticiens.SelectedIndexChanged += new System.EventHandler(this.cboPraticiens_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Espace Visiteur";
            // 
            // FrmConsulter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.cboPraticiens);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulter";
            this.Text = "FrmConsulter";
            this.Load += new System.EventHandler(this.FrmConsulter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblCoef;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.ComboBox cboPraticiens;
        private System.Windows.Forms.Label label1;
    }
}