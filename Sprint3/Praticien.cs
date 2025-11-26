using System;

namespace Sprint3
{
    public class Praticien
    {
        // Données privées
        private int idPraticien;
        private string nom;
        private string prenom;
        private string adresse;
        private string cp;
        private string ville;
        private float coefNotoriete;
        private string typePraticien;

        // Constructeur complet
        public Praticien(int unId, string unNom, string unPrenom, string uneAdresse, string unCp, string uneVille, float unCoef, string unType)
        {
            this.idPraticien = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.adresse = uneAdresse;
            this.cp = unCp;
            this.ville = uneVille;
            this.coefNotoriete = unCoef;
            this.typePraticien = unType;
        }

        // Accesseurs (Pour que la fenêtre puisse lire les infos)
        public int IdPraticien { get => idPraticien; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Adresse { get => adresse; }
        public string CP { get => cp; }
        public string Ville { get => ville; }
        public float CoefNotoriete { get => coefNotoriete; }
        public string TypePraticien { get => typePraticien; }

        // C'est ce qui permet d'afficher "Nom Prénom" dans la liste déroulante
        public override string ToString()
        {
            return this.nom + " " + this.prenom;
        }
    }
}