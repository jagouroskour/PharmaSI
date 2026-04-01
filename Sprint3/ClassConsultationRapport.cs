using System;
using System.Collections.Generic;

namespace Sprint3
{
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
}