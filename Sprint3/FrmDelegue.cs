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
    }
}