using System;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class FrmDelegue : Form
    {
        private int idEmploye;

        public FrmDelegue(string nomComplet, int idEmploye)
        {
            InitializeComponent();
            this.idEmploye = idEmploye;
            lblBienvenue.Text = "Bonjour " + nomComplet + " le délégué régional";
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

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comtpesrendusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterRapport frm = new FrmConsulterRapport(idEmploye);
            frm.ShowDialog();
        }
    }
}
