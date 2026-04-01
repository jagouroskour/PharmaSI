using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    // ═══════════════════════════════════════════════
    //  Classe RapportVisite
    // ═══════════════════════════════════════════════
    public class RapportVisite
    {
        public int IdRapport { get; set; }
        public DateTime DateRapport { get; set; }
        public string LibMotif { get; set; }
        public string Bilan { get; set; }
        public int IdVisiteur { get; set; }
        public string NomPrenomAuteur { get; set; }
        public string NomPrenomPraticien { get; set; }
        public List<(string NomCommercial, int Quantite)> ProduitsOfferts { get; set; }

        public RapportVisite()
        {
            ProduitsOfferts = new List<(string, int)>();
        }

        public void AjouterProduit(string nomCommercial, int quantite)
        {
            if (ProduitsOfferts.Count < 2)
                ProduitsOfferts.Add((nomCommercial, quantite));
        }

        public string GetAffichageAuteur(int idConnecte)
        {
            return (IdVisiteur == idConnecte) ? "Vous-même" : NomPrenomAuteur;
        }
    }

    // ═══════════════════════════════════════════════
    //  Formulaire FrmConsulteRapport
    // ═══════════════════════════════════════════════
    public partial class FrmConsulteRapport : Form
    {
        private ConnexionSql maConnexionSql;
        private int idConnecte = 3;

        public FrmConsulteRapport(int idConnecte)
        {
            InitializeComponent();
            this.idConnecte = idConnecte;
            maConnexionSql = ConnexionSql.getInstance("localhost", "pharmasi", "root", "");
            ChargerRapports();
        }

        private void ChargerRapports()
        {
            try
            {
                maConnexionSql.OpenConnexion();

                string sql = $@"
                    SELECT rv.id_rapport,
                           CONCAT(DATE_FORMAT(rv.date_rapport, '%d/%m/%Y'), ' - ', p.nom_praticien) AS affichage
                    FROM rapport_visite rv
                    JOIN praticien p ON rv.id_praticien = p.id_praticien
                    WHERE rv.id_visiteur = {idConnecte}
                       OR rv.id_visiteur IN (
                           SELECT idEmploye FROM employe WHERE idResponsable = {idConnecte}
                       )
                    ORDER BY rv.date_rapport DESC";

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

            lblAuteurVal.Text = "-";
            lblDateVal.Text = "-";
            lblPraticienVal.Text = "-";
            lblMotifVal.Text = "-";
            txtBilan.Text = "";
            lblProd1.Text = "-"; lblQte1.Text = "-";
            lblProd2.Text = "-"; lblQte2.Text = "-";

            try
            {
                maConnexionSql.OpenConnexion();
                string idRapport = cboRapports.SelectedValue.ToString();

                string sqlInfos = $@"
                    SELECT rv.date_rapport,
                           m.lib_motif,
                           rv.bilan,
                           CONCAT(p.nom_praticien, ' ', p.prenom_praticien) AS praticien,
                           CONCAT(e.nom, ' ', e.prenom)                     AS auteur,
                           rv.id_visiteur
                    FROM rapport_visite rv
                    JOIN praticien p ON rv.id_praticien = p.id_praticien
                    JOIN employe   e ON rv.id_visiteur  = e.idEmploye
                    JOIN motif     m ON rv.id_motif     = m.id_motif
                    WHERE rv.id_rapport = {idRapport}";

                MySqlDataReader reader = maConnexionSql.reqExec(sqlInfos).ExecuteReader();

                RapportVisite rapport = new RapportVisite();

                if (reader.Read())
                {
                    rapport.IdRapport = int.Parse(idRapport);
                    rapport.DateRapport = reader.GetDateTime("date_rapport");
                    rapport.LibMotif = reader.GetString("lib_motif");
                    rapport.Bilan = reader.GetString("bilan");
                    rapport.IdVisiteur = reader.GetInt32("id_visiteur");
                    rapport.NomPrenomAuteur = reader.GetString("auteur");
                    rapport.NomPrenomPraticien = reader.GetString("praticien");
                }
                reader.Close();

                string sqlProduits = $@"
                    SELECT med.nom_commercial, o.quantite
                    FROM offrir o
                    JOIN medicament med ON o.id_medicament = med.id_medicament
                    WHERE o.id_rapport = {idRapport}";

                MySqlDataReader readerProd = maConnexionSql.reqExec(sqlProduits).ExecuteReader();

                while (readerProd.Read())
                    rapport.AjouterProduit(
                        readerProd.GetString("nom_commercial"),
                        readerProd.GetInt32("quantite")
                    );

                readerProd.Close();
                maConnexionSql.CloseConnexion();

                lblAuteurVal.Text = rapport.GetAffichageAuteur(idConnecte);
                lblDateVal.Text = rapport.DateRapport.ToShortDateString();
                lblMotifVal.Text = rapport.LibMotif;
                lblPraticienVal.Text = rapport.NomPrenomPraticien;
                txtBilan.Text = rapport.Bilan;

                if (rapport.ProduitsOfferts.Count >= 1)
                {
                    lblProd1.Text = rapport.ProduitsOfferts[0].NomCommercial;
                    lblQte1.Text = rapport.ProduitsOfferts[0].Quantite.ToString();
                }
                if (rapport.ProduitsOfferts.Count >= 2)
                {
                    lblProd2.Text = rapport.ProduitsOfferts[1].NomCommercial;
                    lblQte2.Text = rapport.ProduitsOfferts[1].Quantite.ToString();
                }
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
            FrmConsulteRapport frm = new FrmConsulteRapport(idConnecte);
            frm.ShowDialog();
        }
    }
}