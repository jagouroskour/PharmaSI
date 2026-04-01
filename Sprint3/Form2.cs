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

                string sql = $@"
                    SELECT r.id_rapport,
                           CONCAT(
                               DATE_FORMAT(r.date_rapport, '%d/%m/%Y'),
                               ' - ',
                               p.nom_praticien, ' ', p.prenom_praticien
                           ) AS affichage
                    FROM rapport_visite r
                    JOIN praticien p ON r.id_praticien = p.id_praticien
                    WHERE r.id_visiteur = {idConnecte}
                       OR r.id_visiteur IN (
                           SELECT idEmploye 
                           FROM employe 
                           WHERE idResponsable = {idConnecte}
                       )
                    ORDER BY r.date_rapport DESC";

                MySqlDataReader reader = maConnexionSql.reqExec(sql).ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();

                cboRapports.DataSource = dt;
                cboRapports.DisplayMember = "affichage";
                cboRapports.ValueMember = "id_rapport";
                cboRapports.SelectedIndex = -1;

                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement rapports : " + ex.Message);
            }
        }

        private void cboRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRapports.SelectedIndex == -1) return;

            // Réinitialisation des champs
            lblAuteurVal.Text = "-";
            lblDateVal.Text = "-";
            lblPraticienVal.Text = "-";
            lblMotifVal.Text = "-";
            txtBilan.Text = "";
            lblProd1.Text = "-";
            lblQte1.Text = "-";
            lblProd2.Text = "-";
            lblQte2.Text = "-";

            try
            {
                maConnexionSql.OpenConnexion();
                string idRapport = cboRapports.SelectedValue.ToString();

                // 1. Informations du rapport
                string sqlInfos = $@"
                    SELECT r.date_rapport,
                           mo.lib_motif          AS motif,
                           r.bilan,
                           CONCAT(p.nom_praticien, ' ', p.prenom_praticien) AS praticien,
                           CONCAT(e.nom,          ' ', e.prenom)            AS auteur,
                           r.id_visiteur
                    FROM rapport_visite r
                    JOIN praticien p ON r.id_praticien = p.id_praticien
                    JOIN employe   e ON r.id_visiteur  = e.idEmploye
                    JOIN motif    mo ON r.id_motif     = mo.id_motif
                    WHERE r.id_rapport = {idRapport}";

                MySqlDataReader reader = maConnexionSql.reqExec(sqlInfos).ExecuteReader();

                if (reader.Read())
                {
                    lblDateVal.Text = reader.GetDateTime("date_rapport").ToShortDateString();
                    lblMotifVal.Text = reader.GetString("motif");
                    lblPraticienVal.Text = reader.GetString("praticien");
                    txtBilan.Text = reader.GetString("bilan");

                    int idAuteur = reader.GetInt32("id_visiteur");
                    lblAuteurVal.Text = (idAuteur == idConnecte)
                                       ? "Vous-même"
                                       : reader.GetString("auteur");
                }
                reader.Close();

                // 2. Produits offerts (max 2)
                string sqlProduits = $@"
                    SELECT m.nom_commercial, o.quantite
                    FROM offrir o
                    JOIN medicament m ON o.id_medicament = m.id_medicament
                    WHERE o.id_rapport = {idRapport}";

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
                    else
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
                MessageBox.Show("Erreur affichage rapport : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultationDeRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}