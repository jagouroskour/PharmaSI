using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Indispensable pour MySQL

namespace Sprint3 // Vérifiez que cela correspond bien à votre projet
{
    public partial class Form1 : Form
    {
        // Propriétés de connexion (à adapter si vous avez un mot de passe root différent)
        private string provider = "localhost";
        private string dataBase = "pharmasi";
        private string uid = "root";
        private string mdp = ""; // Mettez votre mot de passe WAMP/XAMP ici (souvent vide)

        private ConnexionSql maConnexionSql; // Instance de notre classe Singleton
        private MySqlCommand maRequete;      // Objet pour envoyer la requête

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On laisse vide pour l'instant, c'est juste pour que l'erreur disparaisse
        }


        // C'est cette méthode qui s'active quand on clique sur le bouton
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string sql = "SELECT * FROM employe WHERE login = @login AND motDePasse = @motDePasse";
                maRequete = maConnexionSql.reqExec(sql);
                maRequete.Parameters.AddWithValue("@login", txtLogin.Text);
                maRequete.Parameters.AddWithValue("@motDePasse", txtMdp.Text);

                MySqlDataReader monReader = maRequete.ExecuteReader();

                // Variables pour stocker les infos TEMPORAIREMENT
                bool connexionOk = false;
                string nom = "";
                string prenom = "";
                int grade = 0;

                if (monReader.Read())
                {
                    // 1. On sauvegarde les infos dans des variables
                    connexionOk = true;
                    nom = monReader["nom"].ToString();
                    prenom = monReader["prenom"].ToString();
                    grade = int.Parse(monReader["idGrade"].ToString());
                }

                // 2. TRES IMPORTANT : ON FERME LE READER ET LA CONNEXION TOUT DE SUITE !
                monReader.Close();
                maConnexionSql.CloseConnexion();

                // 3. Maintenant que la voie est libre, on ouvre la nouvelle fenêtre
                if (connexionOk)
                {
                    // On cache le login
                    this.Hide();

                    // On prépare une variable pour savoir comment la fenêtre s'est fermée
                    DialogResult resultat = DialogResult.Cancel;

                    if (grade == 1)
                    {
                        FrmVisiteur frm = new FrmVisiteur(prenom + " " + nom);
                        // On stocke le résultat (Est-ce qu'il a cliqué sur Déconnexion ou sur la croix ?)
                        resultat = frm.ShowDialog();
                    }
                    else if (grade == 2)
                    {
                        FrmDelegue frm = new FrmDelegue(prenom + " " + nom);
                        resultat = frm.ShowDialog(); // Pareil pour délégué
                    }
                    else if (grade == 3)
                    {
                        FrmResponsable frm = new FrmResponsable(prenom + " " + nom);
                        resultat = frm.ShowDialog(); // Pareil pour responsable
                    }
                    else
                    {
                        MessageBox.Show("Accès non autorisé pour ce profil.");
                        this.Show();
                        return; // On arrête là pour éviter de fermer l'appli
                    }

                    // ANALYSE DU RETOUR
                    if (resultat == DialogResult.OK)
                    {
                        // L'utilisateur a cliqué sur "Se déconnecter"
                        // On vide les champs pour la sécurité
                        txtLogin.Text = "";
                        txtMdp.Text = "";

                        // On réaffiche le login
                        this.Show();
                    }
                    else
                    {
                        // L'utilisateur a cliqué sur la Croix Rouge (ou autre fermeture forcée)
                        // On ferme l'application complètement
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur login/mot de passe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}