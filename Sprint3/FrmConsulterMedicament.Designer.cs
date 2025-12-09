
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
            this.cboMedicaments.FormattingEnabled = true;
            this.cboMedicaments.Location = new System.Drawing.Point(877, 64);
            this.cboMedicaments.Name = "cboMedicaments";
            this.cboMedicaments.Size = new System.Drawing.Size(121, 33);
            this.cboMedicaments.TabIndex = 0;
            this.cboMedicaments.SelectedIndexChanged += new System.EventHandler(this.cboMedicaments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Famille :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Composition :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Effets :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contre-indications :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prix :";
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(1209, 178);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(30, 25);
            this.lblFamille.TabIndex = 6;
            this.lblFamille.Text = "...";
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.Location = new System.Drawing.Point(1209, 250);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(30, 25);
            this.lblComposition.TabIndex = 7;
            this.lblComposition.Text = "...";
            // 
            // lblEffets
            // 
            this.lblEffets.AutoSize = true;
            this.lblEffets.Location = new System.Drawing.Point(1209, 312);
            this.lblEffets.Name = "lblEffets";
            this.lblEffets.Size = new System.Drawing.Size(30, 25);
            this.lblEffets.TabIndex = 8;
            this.lblEffets.Text = "...";
            // 
            // lblContreIndic
            // 
            this.lblContreIndic.AutoSize = true;
            this.lblContreIndic.Location = new System.Drawing.Point(1209, 380);
            this.lblContreIndic.Name = "lblContreIndic";
            this.lblContreIndic.Size = new System.Drawing.Size(30, 25);
            this.lblContreIndic.TabIndex = 9;
            this.lblContreIndic.Text = "...";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(1209, 432);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 25);
            this.lblPrix.TabIndex = 10;
            this.lblPrix.Text = "...";
            // 
            // dgvInteractions
            // 
            this.dgvInteractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteractions.Location = new System.Drawing.Point(723, 520);
            this.dgvInteractions.Name = "dgvInteractions";
            this.dgvInteractions.RowHeadersWidth = 82;
            this.dgvInteractions.RowTemplate.Height = 33;
            this.dgvInteractions.Size = new System.Drawing.Size(648, 170);
            this.dgvInteractions.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 751);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsulterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 854);
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