using System;
using System.Collections.Generic; // Pour List<>
using System.Data; // Pour DataTable
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    public partial class FrmConsulterMedicament : Form
    {
        // Outils de connexion
        private ConnexionSql maConnexion;
        private List<Medicament> lesMedicaments = new List<Medicament>();

        // IMPORTANT : Utilise ton user sécurisé créé au Sprint 4
        private string provider = "localhost";
        private string dataBase = "pharmasi";
        private string uid = "userPharma"; // L'utilisateur restreint
        private string mdp = "1234";       // Son mot de passe

        public FrmConsulterMedicament()
        {
            InitializeComponent();
        }

        // 1. CHARGEMENT DE LA FENÊTRE : On remplit la liste
        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {
            try
            {
                maConnexion = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexion.OpenConnexion();

                // Requête avec JOINTURE pour avoir le nom de la famille (ex: "Antibiotique" au lieu de "ANT")
                string req = "SELECT M.*, F.lib_famille " +
                             "FROM medicament M " +
                             "INNER JOIN famille F ON M.id_famille = F.id_famille " +
                             "ORDER BY M.nom_commercial";

                MySqlCommand cmd = maConnexion.reqExec(req);
                MySqlDataReader reader = cmd.ExecuteReader();

                lesMedicaments.Clear();

                while (reader.Read())
                {
                    Medicament m = new Medicament(
                        reader["id_medicament"].ToString(),
                        reader["nom_commercial"].ToString(),
                        reader["id_famille"].ToString(),
                        reader["lib_famille"].ToString(), // Grâce à la jointure
                        reader["composition"].ToString(),
                        reader["effets"].ToString(),
                        reader["contre_indications"].ToString(),
                        float.Parse(reader["prix_echantillon"].ToString())
                    );
                    lesMedicaments.Add(m);
                }
                reader.Close();

                // Liaison à la liste déroulante
                cboMedicaments.DataSource = lesMedicaments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement : " + ex.Message);
            }
        }

        // 2. CHANGEMENT DE SÉLECTION : On affiche les infos et les interactions
        private void cboMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // A. Infos générales
                Medicament m = (Medicament)cboMedicaments.SelectedItem;

                lblFamille.Text = m.LibFamille; // On affiche le libellé (ex: Antibiotique)
                lblComposition.Text = m.Composition;
                lblEffets.Text = m.Effets;
                lblContreIndic.Text = m.ContreIndications;
                lblPrix.Text = m.PrixEchantillon.ToString() + " €";

                // B. Les Interactions (Tableau)
                maConnexion.OpenConnexion();

                // On cherche avec quels médicaments (M2) le médicament sélectionné (M1) interagit
                // On affiche le Nom du médicament dangereux et le Type d'interaction
                string sql = "SELECT M2.nom_commercial as 'Médicament', I.type_interaction as 'Risque' " +
                             "FROM interagir I " +
                             "INNER JOIN medicament M2 ON I.id_medicament_2 = M2.id_medicament " +
                             "WHERE I.id_medicament_1 = '" + m.IdMedicament + "'";

                MySqlCommand cmd = maConnexion.reqExec(sql);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Remplissage du tableau via DataTable
                DataTable tableInteractions = new DataTable();
                tableInteractions.Columns.Add("Médicament en interaction");
                tableInteractions.Columns.Add("Type de risque");

                while (reader.Read())
                {
                    DataRow ligne = tableInteractions.NewRow();
                    ligne[0] = reader["Médicament"].ToString();
                    ligne[1] = reader["Risque"].ToString();
                    tableInteractions.Rows.Add(ligne);
                }

                dgvInteractions.DataSource = tableInteractions;
                reader.Close();
            }
            catch (Exception ex)
            {
                // Ignorer les erreurs au chargement initial
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}