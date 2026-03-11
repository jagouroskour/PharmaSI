using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    public partial class Form2 : Form
    {
        private ConnexionSql maConnexionSql;
        private int idConnecte = 3;

        public Form2()
        {
            InitializeComponent();
            maConnexionSql = ConnexionSql.getInstance("localhost", "pharmasi", "root", "");
            ChargerRapports();
        }

        private void ChargerRapports()
        {
            try
            {
                maConnexionSql.OpenConnexion();
                string sql = $@"SELECT r.idRapport, CONCAT(DATE_FORMAT(r.dateRapport, '%d/%m/%Y'), ' - ', p.nom_praticien) AS affichage
                    FROM rapport_visite r JOIN praticien p ON r.idPraticien = p.id_praticien
                    WHERE r.idVisiteur = {idConnecte} OR r.idVisiteur IN (SELECT idEmploye FROM employe WHERE idResponsable = {idConnecte})
                    ORDER BY r.dateRapport DESC";

                MySqlDataReader reader = maConnexionSql.reqExec(sql).ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cboRapports.DataSource = dt;
                cboRapports.DisplayMember = "affichage";
                cboRapports.ValueMember = "idRapport";
                cboRapports.SelectedIndex = -1;
                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        }

        private void cboRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRapports.SelectedIndex == -1) return;

            // Réinitialisation des labels
            lblAuteurVal.Text = "-"; lblDateVal.Text = "-"; lblPraticienVal.Text = "-"; lblMotifVal.Text = "-";
            txtBilan.Text = "";
            lblProd1.Text = "-"; lblQte1.Text = "-";
            lblProd2.Text = "-"; lblQte2.Text = "-";

            try
            {
                maConnexionSql.OpenConnexion();
                string idRapport = cboRapports.SelectedValue.ToString();

                // 1. Infos du rapport
                string sqlInfos = $@"SELECT r.dateRapport, r.motif, r.bilan, 
                           CONCAT(p.nom_praticien, ' ', p.prenom_praticien) AS praticien,
                           CONCAT(e.nom, ' ', e.prenom) AS auteur, r.idVisiteur
                    FROM rapport_visite r
                    JOIN praticien p ON r.idPraticien = p.id_praticien
                    JOIN employe e ON r.idVisiteur = e.idEmploye
                    WHERE r.idRapport = {idRapport}";

                MySqlDataReader reader = maConnexionSql.reqExec(sqlInfos).ExecuteReader();
                if (reader.Read())
                {
                    lblDateVal.Text = reader.GetDateTime("dateRapport").ToShortDateString();
                    lblMotifVal.Text = reader.GetString("motif");
                    lblPraticienVal.Text = reader.GetString("praticien");
                    txtBilan.Text = reader.GetString("bilan");
                    int idAuteur = reader.GetInt32("idVisiteur");
                    lblAuteurVal.Text = (idAuteur == idConnecte) ? "Vous-même" : reader.GetString("auteur");
                }
                reader.Close();

                // 2. Produits offerts (Logique adaptée pour Labels)
                string sqlProduits = $@"
                    SELECT pr.nom_commercial, o.quantite
                    FROM offrir o
                    JOIN produit pr ON o.idMedicament = pr.depot_legal
                    WHERE o.idRapport = {idRapport}";

                MySqlDataReader readerProd = maConnexionSql.reqExec(sqlProduits).ExecuteReader();

                int compteur = 0;
                while (readerProd.Read() && compteur < 2)
                {
                    compteur++;
                    string nomProd = readerProd.GetString("nom_commercial");
                    string qteProd = readerProd.GetInt32("quantite").ToString();

                    if (compteur == 1)
                    {
                        lblProd1.Text = nomProd;
                        lblQte1.Text = qteProd;
                    }
                    else if (compteur == 2)
                    {
                        lblProd2.Text = nomProd;
                        lblQte2.Text = qteProd;
                    }
                }
                readerProd.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultationDeRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire de consultation
            Form2 frmConsulter = new Form2();
            frmConsulter.ShowDialog();
        }
    }
}