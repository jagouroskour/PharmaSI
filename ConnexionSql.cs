using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Nécessaire pour MessageBox
using MySql.Data.MySqlClient; // Nécessaire pour MySQL

namespace Sprint3 // Vérifiez que cela correspond au nom de votre projet !
{
    public class ConnexionSql
    {
        // Variable locale pour stocker une seule instance de la classe (Singleton)
        private static ConnexionSql connexion = null;

        // Objet de connexion MySQL
        private MySqlConnection cnx;

        // Chaîne de connexion
        private string connString;

        /**
         * Constructeur privé : on ne peut pas faire "new ConnexionSql()" depuis l'extérieur
         * C'est le principe du Singleton.
         */
        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            Initialize(unProvider, uneDataBase, unUid, unMdp);
        }

        /**
         * Initialisation de la chaîne de connexion
         */
        private void Initialize(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            try
            {
                // Construction de la chaîne de connexion standard pour MySQL
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                             uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";

                // Création de l'objet MySqlConnection
                cnx = new MySqlConnection(connString);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur configuration connexion : " + e.Message);
            }
        }

        /**
         * Méthode statique pour récupérer l'instance unique (Singleton)
         * Si elle n'existe pas, on la crée. Si elle existe, on la retourne.
         */
        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            try
            {
                if (connexion == null)
                {
                    // Premier appel : on crée l'instance
                    connexion = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return connexion;
        }

        /**
         * Retourne l'objet MySqlConnection (utile pour certaines commandes manuelles si besoin)
         */
        public MySqlConnection getConnexion()
        {
            return this.cnx;
        }

        /**
         * Ouvre la connexion à la BDD
         */
        public void OpenConnexion()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Closed)
                {
                    cnx.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur ouverture BDD : " + e.Message);
            }
        }

        /**
         * Ferme la connexion
         */
        public void CloseConnexion()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur fermeture BDD : " + e.Message);
            }
        }

        /**
         * Prépare une requête SQL (MySqlCommand)
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCmd = new MySqlCommand(req, this.cnx);
            return mysqlCmd;
        }
    }
}