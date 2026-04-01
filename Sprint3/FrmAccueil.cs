using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Sprint3
{
    public partial class FrmAccueil : Form
    {
        private string provider = "localhost";
        private string dataBase = "pharmasi";
        private string uid      = "root";
        private string mdp      = ""; // Adapter si WAMP/XAMPP a un mot de passe root

        private ConnexionSql maConnexionSql;
        private MySqlCommand maRequete;

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Hache le mot de passe saisi en SHA-256 pour comparaison avec la base de données.
        /// </summary>
        private string HacherMdp(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string mdpHache = HacherMdp(txtMdp.Text);

                // Requête paramétrée : pas d'injection SQL possible
                string sql = @"SELECT idEmploye, nom, prenom, idGrade
                               FROM employe
                               WHERE login = @login AND motDePasse = @motDePasse";

                maRequete = maConnexionSql.reqExec(sql);
                maRequete.Parameters.AddWithValue("@login",      txtLogin.Text);
                maRequete.Parameters.AddWithValue("@motDePasse", mdpHache);

                MySqlDataReader monReader = maRequete.ExecuteReader();

                bool   connexionOk = false;
                string nom         = "";
                string prenom      = "";
                int    grade       = 0;
                int    idEmploye   = 0;

                if (monReader.Read())
                {
                    connexionOk = true;
                    idEmploye   = monReader.GetInt32("idEmploye");
                    nom         = monReader.GetString("nom");
                    prenom      = monReader.GetString("prenom");
                    grade       = monReader.GetInt32("idGrade");
                }

                monReader.Close();
                maConnexionSql.CloseConnexion();

                if (connexionOk)
                {
                    this.Hide();
                    DialogResult resultat = DialogResult.Cancel;
                    string nomComplet = prenom + " " + nom;

                    if (grade == 1)
                    {
                        FrmVisiteur frm = new FrmVisiteur(nomComplet, idEmploye);
                        resultat = frm.ShowDialog();
                    }
                    else if (grade == 2)
                    {
                        FrmDelegue frm = new FrmDelegue(nomComplet, idEmploye);
                        resultat = frm.ShowDialog();
                    }
                    else if (grade == 3)
                    {
                        FrmResponsable frm = new FrmResponsable(nomComplet, idEmploye);
                        resultat = frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Accès non autorisé pour ce profil.");
                        this.Show();
                        return;
                    }

                    if (resultat == DialogResult.OK)
                    {
                        txtLogin.Text = "";
                        txtMdp.Text   = "";
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect.");
                }
            }
            catch (Exception ex)
            {
                maConnexionSql?.CloseConnexion();
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e) { }
    }
}
