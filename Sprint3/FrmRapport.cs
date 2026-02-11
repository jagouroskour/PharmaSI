using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sprint3
{
    public partial class FrmRapport : Form
    {
        // Paramètres de connexion
        private string provider = "localhost";
        private string dataBase = "pharmasi";
        private string uid = "root";
        private string mdp = "";
        private ConnexionSql maConnexionSql;

        // ID du visiteur connecté 
        private int idVisiteurConnecte = 3;

        public FrmRapport()
        {
            InitializeComponent();
            maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
        }

        private void FrmRapport_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "Auto";

            comboBox2.Items.AddRange(new string[] { "Périodicité", "Actualisation", "Relance", "Sollicitation", "Autre" });

            for (int i = 1; i <= 10; i++)
            {
                comboBox3.Items.Add(i.ToString());
                comboBox4.Items.Add(i.ToString());
            }

            ChargerPraticiens();
            ChargerProduits(comboBox5);
            ChargerProduits(comboBox6);
        }

        private void ChargerPraticiens()
        {
            maConnexionSql.OpenConnexion();
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

        private void ChargerProduits(ComboBox cbo)
        {
            maConnexionSql.OpenConnexion();
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

        // Bouton Valider
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Le champ doit être renseigné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                maConnexionSql.OpenConnexion();

                string dateVisite = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string motif = comboBox2.SelectedItem.ToString();
                string bilan = textBox2.Text.Replace("'", "''");
                int idPraticien = Convert.ToInt32(comboBox1.SelectedValue);

                string reqRapport = $"INSERT INTO rapport_visite (date_rapport, motif, bilan, id_praticien, id_visiteur) VALUES ('{dateVisite}', '{motif}', '{bilan}', {idPraticien}, {idVisiteurConnecte})";
                MySqlCommand cmdRapport = maConnexionSql.reqExec(reqRapport);
                cmdRapport.ExecuteNonQuery();

                MySqlCommand cmdId = maConnexionSql.reqExec("SELECT LAST_INSERT_ID()");
                int idRapport = Convert.ToInt32(cmdId.ExecuteScalar());

                if (comboBox5.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
                {
                    string idProd1 = comboBox5.SelectedValue.ToString();
                    int qte1 = Convert.ToInt32(comboBox3.SelectedItem);
                    MySqlCommand cmdProd1 = maConnexionSql.reqExec($"INSERT INTO offrir (id_rapport, id_medicament, quantite) VALUES ({idRapport}, '{idProd1}', {qte1})");
                    cmdProd1.ExecuteNonQuery();
                }

                if (comboBox6.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
                {
                    string idProd2 = comboBox6.SelectedValue.ToString();
                    int qte2 = Convert.ToInt32(comboBox4.SelectedItem);
                    MySqlCommand cmdProd2 = maConnexionSql.reqExec($"INSERT INTO offrir (id_rapport, id_medicament, quantite) VALUES ({idRapport}, '{idProd2}', {qte2})");
                    cmdProd2.ExecuteNonQuery();
                }

                MessageBox.Show("Rapport de visite enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reinitialiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                maConnexionSql.CloseConnexion();
            }
        }

        // Bouton Réinitialiser
        private void Button2_Click_1(object sender, EventArgs e)
        {
            Reinitialiser();
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

        // Bouton Retour / Fermer
        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bouton Se déconnecter
        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}