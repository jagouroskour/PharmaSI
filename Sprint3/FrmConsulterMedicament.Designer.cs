
namespace Sprint3
{
    partial class FrmConsulterMedicament
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
            this.cboMedicaments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFamille = new System.Windows.Forms.Label();
            this.lblComposition = new System.Windows.Forms.Label();
            this.lblEffets = new System.Windows.Forms.Label();
            this.lblContreIndic = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.dgvInteractions = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMedicaments
            // 
            this.cboMedicaments.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboMedicaments.FormattingEnabled = true;
            this.cboMedicaments.Location = new System.Drawing.Point(415, 36);
            this.cboMedicaments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMedicaments.Name = "cboMedicaments";
            this.cboMedicaments.Size = new System.Drawing.Size(182, 21);
            this.cboMedicaments.TabIndex = 0;
            this.cboMedicaments.SelectedIndexChanged += new System.EventHandler(this.cboMedicaments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Famille :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Composition :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Effets :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contre-indications :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prix :";
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.BackColor = System.Drawing.Color.Transparent;
            this.lblFamille.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamille.ForeColor = System.Drawing.Color.Gray;
            this.lblFamille.Location = new System.Drawing.Point(604, 93);
            this.lblFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(17, 16);
            this.lblFamille.TabIndex = 6;
            this.lblFamille.Text = "...";
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.BackColor = System.Drawing.Color.Transparent;
            this.lblComposition.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposition.ForeColor = System.Drawing.Color.Gray;
            this.lblComposition.Location = new System.Drawing.Point(604, 130);
            this.lblComposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(17, 16);
            this.lblComposition.TabIndex = 7;
            this.lblComposition.Text = "...";
            // 
            // lblEffets
            // 
            this.lblEffets.AutoSize = true;
            this.lblEffets.BackColor = System.Drawing.Color.Transparent;
            this.lblEffets.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffets.ForeColor = System.Drawing.Color.Gray;
            this.lblEffets.Location = new System.Drawing.Point(604, 162);
            this.lblEffets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEffets.Name = "lblEffets";
            this.lblEffets.Size = new System.Drawing.Size(17, 16);
            this.lblEffets.TabIndex = 8;
            this.lblEffets.Text = "...";
            // 
            // lblContreIndic
            // 
            this.lblContreIndic.AutoSize = true;
            this.lblContreIndic.BackColor = System.Drawing.Color.Transparent;
            this.lblContreIndic.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContreIndic.ForeColor = System.Drawing.Color.Gray;
            this.lblContreIndic.Location = new System.Drawing.Point(604, 198);
            this.lblContreIndic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContreIndic.Name = "lblContreIndic";
            this.lblContreIndic.Size = new System.Drawing.Size(17, 16);
            this.lblContreIndic.TabIndex = 9;
            this.lblContreIndic.Text = "...";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.BackColor = System.Drawing.Color.Transparent;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.ForeColor = System.Drawing.Color.Gray;
            this.lblPrix.Location = new System.Drawing.Point(604, 225);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(17, 16);
            this.lblPrix.TabIndex = 10;
            this.lblPrix.Text = "...";
            // 
            // dgvInteractions
            // 
            this.dgvInteractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteractions.Location = new System.Drawing.Point(362, 270);
            this.dgvInteractions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInteractions.Name = "dgvInteractions";
            this.dgvInteractions.RowHeadersWidth = 82;
            this.dgvInteractions.RowTemplate.Height = 33;
            this.dgvInteractions.Size = new System.Drawing.Size(324, 88);
            this.dgvInteractions.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsulterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sprint3.Properties.Resources.equipements_de_sante_et_fournitures_de_bureau_avec_plante_succulente_sur_fond_vert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvInteractions);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblContreIndic);
            this.Controls.Add(this.lblEffets);
            this.Controls.Add(this.lblComposition);
            this.Controls.Add(this.lblFamille);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMedicaments);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConsulterMedicament";
            this.Text = "FrmConsulterMedicament";
            this.Load += new System.EventHandler(this.FrmConsulterMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteractions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMedicaments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.Label lblEffets;
        private System.Windows.Forms.Label lblContreIndic;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.DataGridView dgvInteractions;
        private System.Windows.Forms.Button button1;
    }
}