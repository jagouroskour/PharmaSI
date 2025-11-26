using System;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class FrmDelegue : Form
    {
        // 1. Constructeur : on récupère le nom et on l'affiche
        public FrmDelegue(string nomComplet)
        {
            InitializeComponent();
            lblBienvenue.Text = "Bonjour " + nomComplet + " le délégué régional";
        }

        // 2. Menu : Ouverture de la fiche praticien
        // (Double-clique sur le menu "Fiche du praticien" dans le design pour créer le lien si ça ne marche pas direct)
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

        private void ficheDunPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulter frm = new FrmConsulter();
            frm.ShowDialog();
        }
    }
}