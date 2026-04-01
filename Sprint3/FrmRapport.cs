using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    public partial class FrmRapport : Form
    {
        private string provider = "localhost";
        private string dataBase = "pharmasi";
        private string uid = "root";
        private string mdp = "";
        private ConnexionSql maConnexionSql;

        // ID du visiteur connecté (ex: Alain Toto)
        private int idVisiteurConnecte = 3;

        public FrmRapport()
        {
            InitializeComponent();
            maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
        }

        private void FrmRapport_Load(object sender, EventArgs e)
        {
            // Configuration des champs texte
            textBox1.Enabled = false;
            textBox1.Text = "Auto";

            // Remplissage des listes de quantités (ComboBox 3 et 4)
            for (int i = 1; i <= 10; i++)
            {
                comboBox3.Items.Add(i.ToString());
                comboBox4.Items.Add(i.ToString());
            }

            // Chargement des données dynamiques depuis la BDD
            ChargerPraticiens();
            ChargerMotifs(); // Cette méthode doit utiliser la table 'motif'
            ChargerProduits(comboBox5);
            ChargerProduits(comboBox6);
        }

        private void ChargerPraticiens()
        {
            maConnexionSql.OpenConnexion();
            // Utilisation des noms de colonnes exacts de ta base
            MySqlCommand cmd = maConnexionSql.reqExec("SELECT id_praticien, CONCAT(nom_praticien, ' ', prenom_praticien) AS nom FROM praticien");
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id_praticien";
            comboBox1.SelectedIndex = -1;

            reader.Close();
            maConnexionSql.CloseConnexion();
        }

        private void ChargerMotifs()
        {
            maConnexionSql.OpenConnexion();
            // Récupération depuis la table 'motif' de ta base
            MySqlCommand cmd = maConnexionSql.reqExec("SELECT id_motif, lib_motif FROM motif");
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "lib_motif";
            comboBox2.ValueMember = "id_motif"; // On stocke l'ID
            comboBox2.SelectedIndex = -1;

            reader.Close();
            maConnexionSql.CloseConnexion();
        }

        private void ChargerProduits(ComboBox cbo)
        {
            maConnexionSql.OpenConnexion();
            // Utilisation de id_medicament comme défini dans ton SQL
            MySqlCommand cmd = maConnexionSql.reqExec("SELECT id_medicament, nom_commercial FROM medicament");
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            cbo.DataSource = dt;
            cbo.DisplayMember = "nom_commercial";
            cbo.ValueMember = "id_medicament";
            cbo.SelectedIndex = -1;

            reader.Close();
            maConnexionSql.CloseConnexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Vérification des champs obligatoires (Scenario nominal du Sprint 5/6)
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Le champ doit être renseigné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                maConnexionSql.OpenConnexion();

                // 2. Préparation des données pour l'insertion
                string dateVisite = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                // On récupère l'ID numérique du motif (ValueMember) au lieu du texte
                int idMotif = Convert.ToInt32(comboBox2.SelectedValue);

                // Protection simple contre les apostrophes dans le bilan
                string bilan = textBox2.Text.Replace("'", "''");

                int idPraticien = Convert.ToInt32(comboBox1.SelectedValue);

                // 3. REQUÊTE CORRIGÉE : Utilisation de id_motif au lieu de motif
                // Note : On utilise l'interpolation $ pour construire la chaîne proprement
                string reqRapport = $"INSERT INTO rapport_visite (date_rapport, id_motif, bilan, id_praticien, id_visiteur) " +
                                    $"VALUES ('{dateVisite}', {idMotif}, '{bilan}', {idPraticien}, {idVisiteurConnecte})";

                MySqlCommand cmdRapport = maConnexionSql.reqExec(reqRapport);
                cmdRapport.ExecuteNonQuery();

                // 4. Récupération de l'ID du rapport qui vient d'être créé pour la table 'offrir'
                MySqlCommand cmdId = maConnexionSql.reqExec("SELECT LAST_INSERT_ID()");
                int idRapport = Convert.ToInt32(cmdId.ExecuteScalar());

                // 5. Gestion des échantillons offerts (Table offrir)
                // Premier produit
                if (comboBox5.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
                {
                    string idProd1 = comboBox5.SelectedValue.ToString();
                    int qte1 = Convert.ToInt32(comboBox3.SelectedItem);
                    string reqOffrir1 = $"INSERT INTO offrir (id_rapport, id_medicament, quantite) VALUES ({idRapport}, '{idProd1}', {qte1})";
                    maConnexionSql.reqExec(reqOffrir1).ExecuteNonQuery();
                }

                // Deuxième produit
                if (comboBox6.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
                {
                    string idProd2 = comboBox6.SelectedValue.ToString();
                    int qte2 = Convert.ToInt32(comboBox4.SelectedItem);
                    string reqOffrir2 = $"INSERT INTO offrir (id_rapport, id_medicament, quantite) VALUES ({idRapport}, '{idProd2}', {qte2})";
                    maConnexionSql.reqExec(reqOffrir2).ExecuteNonQuery();
                }

                MessageBox.Show("Rapport de visite enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reinitialiser();
            }
            catch (Exception ex)
            {
                // Affiche l'erreur précise si l'insertion échoue encore
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                maConnexionSql.CloseConnexion();
            }
        }

        private void Reinitialiser()
        {
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox2.Clear();
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void Button2_Click_1(object sender, EventArgs e) => Reinitialiser();

        private void Button3_Click_1(object sender, EventArgs e) => this.Close();

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAccueil().ShowDialog();
            this.Close();
        }

        // Méthode pour le menu Mes Comptes-rendus
        private void comtpesrendusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ce code ouvre la consultation des rapports
            FrmConsulteRapport frm = new FrmConsulteRapport();
            frm.ShowDialog();
        }

        // Méthode pour le menu Nouveau Rapport
        private void nouveauRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On peut laisser vide ou recharger la page
            MessageBox.Show("Vous êtes déjà sur la page de saisie.");
        }
    }
}