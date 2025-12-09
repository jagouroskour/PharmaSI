using System;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class FrmResponsable : Form
    {
        // 1. Constructeur
        public FrmResponsable(string nomComplet)
        {
            InitializeComponent();
            lblBienvenue.Text = "Bonjour " + nomComplet + " le responsable de secteur";
        }

        // 2. Menu : Fiche praticien
        // (Pareil, vérifie bien que l'événement est lié dans le designer)
        private void ficheDuPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulter frm = new FrmConsulter();
            frm.ShowDialog();
        }

        // 3. Déconnexion
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ficheDuPraticienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmConsulter frm = new FrmConsulter();
            frm.ShowDialog();
        }

        private void ficheDuProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterMedicament frm = new FrmConsulterMedicament();
            frm.ShowDialog();
        }
    }
}