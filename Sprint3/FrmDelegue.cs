// 2. FrmDelegue.cs
using System;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class FrmDelegue : Form
    {
        public FrmDelegue(string nomComplet)
        {
            InitializeComponent();
            lblBienvenue.Text = "Bonjour " + nomComplet + " le délégué régional";
        }

        private void ficheDuPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulter frm = new FrmConsulter();
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

        private void ficheDunPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulter frm = new FrmConsulter();
            frm.ShowDialog();
        }

        private void ficheDunProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterMedicament frm = new FrmConsulterMedicament();
            frm.ShowDialog();

        }

        private void mesComptesRendusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciation de la Form2 (votre page de consultation des rapports)
            Form2 frm = new Form2();
            // Affichage de la fenêtre en mode dialogue
            frm.ShowDialog();
        }
    }
}