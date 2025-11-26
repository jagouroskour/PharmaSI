using System;
using System.Windows.Forms;

namespace Sprint3
{
    public partial class FrmVisiteur : Form
    {
        // Constructeur qui reçoit le nom
        public FrmVisiteur(string nomComplet)
        {
            InitializeComponent();

            // On affiche le message personnalisé au centre
            // "Bonjour [Nom] le visiteur médical"
            lblBienvenue.Text = "Bonjour " + nomComplet + " le visiteur médical";
        }

        private void FrmVisiteur_Load(object sender, EventArgs e)
        {
            // Rien de spécial à charger au démarrage pour l'instant
        }

        // C'est ici qu'on fait le lien !
        // Double-clique sur "Fiche d'un praticien" dans ton menu pour créer cette méthode
        private void ficheDunPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On crée la fenêtre de consultation
            FrmConsulter frm = new FrmConsulter();

            // On l'ouvre par dessus
            frm.ShowDialog();
        }

        // Bouton déconnexion 
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ficheDunPraticienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmConsulter frm = new FrmConsulter();
            frm.ShowDialog();
        }

        private void btnDeconnexion_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}