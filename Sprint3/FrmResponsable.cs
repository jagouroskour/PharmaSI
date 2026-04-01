using System;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class FrmResponsable : Form
    {
        public FrmResponsable(string nomComplet)
        {
            InitializeComponent();
            lblBienvenue.Text = "Bonjour " + nomComplet + " le responsable de secteur";
        }

        private void ficheDuPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulter frm = new FrmConsulter();
            frm.ShowDialog();
        }

        private void ficheDunProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterMedicament frm = new FrmConsulterMedicament();
            frm.ShowDialog();
        }

        private void nouveauRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapport frmRapport = new FrmRapport();
            frmRapport.ShowDialog();
        }

        // ✅ CORRIGÉ : handler ajouté (manquait complètement)
        private void comtpesrendusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterRapport frm = new FrmConsulterRapport();
            frm.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblBienvenue_Click(object sender, EventArgs e)
        {
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}