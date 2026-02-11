using System;
using System.Collections.Generic;
using System.Data; // Indispensable pour DataTable
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    public partial class FrmConsulter : Form
    {
        // Déclaration des outils
        private ConnexionSql maConnexion;
        private List<Praticien> lesPraticiens = new List<Praticien>();

        // Tes identifiants BDD
        private string provider = "localhost";
        private string dataBase = "pharmasi";
        private string uid = "root";
        private string mdp = "";

        // Constructeur
        public FrmConsulter()
        {
            InitializeComponent();
            
        }

        // 1. AU CHARGEMENT : ON REMPLIT LA LISTE DÉROULANTE
        private void FrmConsulter_Load(object sender, EventArgs e)
        {
            try
            {
                maConnexion = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexion.OpenConnexion();

                // Requête : On récupère les praticiens + leur type
                string req = "SELECT P.*, T.lib_type_praticien " +
                             "FROM praticien P " +
                             "INNER JOIN type_praticien T ON P.id_type_praticien = T.id_type_praticien " +
                             "ORDER BY P.nom_praticien";

                MySqlCommand cmd = maConnexion.reqExec(req);
                MySqlDataReader reader = cmd.ExecuteReader();

                lesPraticiens.Clear();

                while (reader.Read())
                {
                    Praticien p = new Praticien(
                        int.Parse(reader["id_praticien"].ToString()),
                        reader["nom_praticien"].ToString(),
                        reader["prenom_praticien"].ToString(),
                        reader["adresse_praticien"].ToString(),
                        reader["cp_praticien"].ToString(),
                        reader["ville_praticien"].ToString(),
                        float.Parse(reader["coef_notoriete"].ToString()),
                        reader["lib_type_praticien"].ToString()
                    );
                    lesPraticiens.Add(p);
                }
                reader.Close();

                // Liaison des données
                cboPraticiens.DataSource = lesPraticiens;
                // Pas besoin de DisplayMember car on a fait la méthode ToString() dans Praticien.cs
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement : " + ex.Message);
            }
        }

        // 2. AU CHANGEMENT DE SÉLECTION : ON AFFICHE LES DÉTAILS
        // (Assure-toi que cet événement est bien lié à ta ComboBox dans le mode Design !)
        private void cboPraticiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // A. On récupère le praticien choisi
                Praticien p = (Praticien)cboPraticiens.SelectedItem;

                // B. On remplit les Labels (Vérifie que tes labels ont bien ces noms !)
                lblAdresse.Text = p.Adresse;
                lblVille.Text = p.Ville;
                lblType.Text = p.TypePraticien;
                lblCp.Text = p.CP;
                // Si tu as créé un label pour la notoriété :
                if (lblCoef != null) lblCoef.Text = p.CoefNotoriete.ToString();


                // C. On remplit le Tableau des spécialités (DataGridView)
                maConnexion.OpenConnexion();

                // Requête : On cherche les diplômes de CE praticien (p.IdPraticien)
                string sql = "SELECT S.lib_specialite, P.diplome, P.coef_prescription " +
                             "FROM posseder P " +
                             "INNER JOIN specialite S ON P.id_specialite = S.id_specialite " +
                             "WHERE P.id_praticien = " + p.IdPraticien;

                MySqlCommand cmd = maConnexion.reqExec(sql);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Utilisation d'une DataTable comme demandé dans le cours
                DataTable tableSpecialites = new DataTable();
                tableSpecialites.Columns.Add("Spécialité");
                tableSpecialites.Columns.Add("Diplôme");
                tableSpecialites.Columns.Add("Coef. Prescr.");

                while (reader.Read())
                {
                    DataRow ligne = tableSpecialites.NewRow();
                    ligne[0] = reader["lib_specialite"].ToString();
                    ligne[1] = reader["diplome"].ToString();
                    ligne[2] = reader["coef_prescription"].ToString();
                    tableSpecialites.Rows.Add(ligne);
                }

                dgvDetails.DataSource = tableSpecialites;
                reader.Close();
            }
            catch (Exception ex)
            {
                // On ignore les erreurs au tout début si la liste est vide
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeconnexion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}