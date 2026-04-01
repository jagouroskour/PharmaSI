using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    public partial class FrmConsulterRapport : Form
    {
        private ConnexionSql maConnexionSql;
        private int idConnecte;

        public FrmConsulterRapport(int idConnecte)
        {
            InitializeComponent();
            this.idConnecte = idConnecte;
            maConnexionSql = ConnexionSql.getInstance("localhost", "pharmasi", "root", "");
            ChargerRapports();
        }

        /// <summary>
        /// Charge dans la liste déroulante les rapports visibles par l'utilisateur connecté :
        /// - ses propres rapports
        /// - les rapports de ses subordonnés directs (niveau 1)
        /// - les rapports des subordonnés de ses subordonnés (niveau 2, pour le responsable)
        /// </summary>
        private void ChargerRapports()
        {
            try
            {
                maConnexionSql.OpenConnexion();

                // La sous-requête à 2 niveaux couvre : visiteur (propres), délégué (propres + niveau 1),
                // responsable (propres + niveau 1 + niveau 2).
                string sql = @"
                    SELECT r.id_rapport,
                           CONCAT(DATE_FORMAT(r.date_rapport, '%d/%m/%Y'),
                                  ' - Dr ',
                                  p.nom_praticien, ' ', p.prenom_praticien) AS affichage
                    FROM rapport_visite r
                    JOIN praticien p ON r.id_praticien = p.id_praticien
                    WHERE r.id_visiteur = @idConnecte
                       OR r.id_visiteur IN (
                              SELECT idEmploye FROM employe WHERE idResponsable = @idConnecte
                              UNION
                              SELECT idEmploye FROM employe WHERE idResponsable IN (
                                  SELECT idEmploye FROM employe WHERE idResponsable = @idConnecte
                              )
                       )
                    ORDER BY r.date_rapport DESC";

                MySqlCommand cmd = maConnexionSql.reqExec(sql);
                cmd.Parameters.AddWithValue("@idConnecte", idConnecte);

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                maConnexionSql.CloseConnexion();

                cboRapports.DataSource = dt;
                cboRapports.DisplayMember = "affichage";
                cboRapports.ValueMember = "id_rapport";
                cboRapports.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                maConnexionSql.CloseConnexion();
                MessageBox.Show("Erreur chargement rapports : " + ex.Message);
            }
        }

        private void cboRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRapports.SelectedIndex == -1) return;

            // Remise à zéro de l'affichage
            lblAuteurVal.Text    = "-";
            lblDateVal.Text      = "-";
            lblPraticienVal.Text = "-";
            lblMotifVal.Text     = "-";
            txtBilan.Text        = "";
            lblProd1.Text        = "-"; lblQte1.Text = "-";
            lblProd2.Text        = "-"; lblQte2.Text = "-";

            try
            {
                maConnexionSql.OpenConnexion();

                int idRapport = (int)cboRapports.SelectedValue;

                // --- Requête 1 : informations principales du rapport ---
                string sqlInfos = @"
                    SELECT r.date_rapport,
                           mo.lib_motif                                          AS motif,
                           r.bilan,
                           CONCAT(p.nom_praticien, ' ', p.prenom_praticien)     AS praticien,
                           CONCAT(e.nom, ' ', e.prenom)                         AS auteur,
                           r.id_visiteur
                    FROM rapport_visite r
                    JOIN praticien p ON r.id_praticien = p.id_praticien
                    JOIN employe   e ON r.id_visiteur  = e.idEmploye
                    JOIN motif    mo ON r.id_motif     = mo.id_motif
                    WHERE r.id_rapport = @idRapport";

                MySqlCommand cmdInfos = maConnexionSql.reqExec(sqlInfos);
                cmdInfos.Parameters.AddWithValue("@idRapport", idRapport);
                MySqlDataReader reader = cmdInfos.ExecuteReader();

                RapportVisite rapport = new RapportVisite();

                if (reader.Read())
                {
                    rapport.IdRapport          = idRapport;
                    rapport.DateRapport        = reader.GetDateTime("date_rapport");
                    rapport.LibMotif           = reader.GetString("motif");
                    rapport.Bilan              = reader.GetString("bilan");
                    rapport.IdVisiteur         = reader.GetInt32("id_visiteur");
                    rapport.NomPrenomAuteur    = reader.GetString("auteur");
                    rapport.NomPrenomPraticien = reader.GetString("praticien");
                }
                reader.Close();

                // --- Requête 2 : produits offerts ---
                string sqlProduits = @"
                    SELECT m.nom_commercial, o.quantite
                    FROM offrir o
                    JOIN medicament m ON o.id_medicament = m.id_medicament
                    WHERE o.id_rapport = @idRapport";

                MySqlCommand cmdProd = maConnexionSql.reqExec(sqlProduits);
                cmdProd.Parameters.AddWithValue("@idRapport", idRapport);
                MySqlDataReader readerProd = cmdProd.ExecuteReader();

                while (readerProd.Read())
                    rapport.AjouterProduit(
                        readerProd.GetString("nom_commercial"),
                        readerProd.GetInt32("quantite"));

                readerProd.Close();
                maConnexionSql.CloseConnexion();

                // --- Affichage ---
                lblAuteurVal.Text    = rapport.GetAffichageAuteur(idConnecte);
                lblDateVal.Text      = rapport.DateRapport.ToShortDateString();
                lblMotifVal.Text     = rapport.LibMotif;
                lblPraticienVal.Text = rapport.NomPrenomPraticien;
                txtBilan.Text        = rapport.Bilan;

                // Le formulaire affiche au maximum 2 produits (conception initiale)
                if (rapport.ProduitsOfferts.Count >= 1)
                {
                    lblProd1.Text = rapport.ProduitsOfferts[0].NomCommercial;
                    lblQte1.Text  = rapport.ProduitsOfferts[0].Quantite.ToString();
                }
                if (rapport.ProduitsOfferts.Count >= 2)
                {
                    lblProd2.Text = rapport.ProduitsOfferts[1].NomCommercial;
                    lblQte2.Text  = rapport.ProduitsOfferts[1].Quantite.ToString();
                }
            }
            catch (Exception ex)
            {
                maConnexionSql.CloseConnexion();
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
