using System;
using System.Collections.Generic;

namespace Sprint3
{
    /// <summary>
    /// Représente un produit offert (échantillon) dans un rapport de visite.
    /// </summary>
    public class ProduitOffert
    {
        public string NomCommercial { get; set; }
        public int Quantite { get; set; }

        public ProduitOffert(string nomCommercial, int quantite)
        {
            NomCommercial = nomCommercial;
            Quantite = quantite;
        }

        public override string ToString()
        {
            return $"{NomCommercial} (x{Quantite})";
        }
    }

    /// <summary>
    /// Représente un rapport de visite médicale.
    /// </summary>
    public class RapportVisite
    {
        public int IdRapport { get; set; }
        public DateTime DateRapport { get; set; }
        public string LibMotif { get; set; }
        public string Bilan { get; set; }
        public int IdVisiteur { get; set; }
        public string NomPrenomAuteur { get; set; }
        public string NomPrenomPraticien { get; set; }
        public List<ProduitOffert> ProduitsOfferts { get; set; }

        public RapportVisite()
        {
            ProduitsOfferts = new List<ProduitOffert>();
        }

        /// <summary>
        /// Ajoute un produit offert à la liste des échantillons du rapport.
        /// </summary>
        public void AjouterProduit(string nomCommercial, int quantite)
        {
            ProduitsOfferts.Add(new ProduitOffert(nomCommercial, quantite));
        }

        /// <summary>
        /// Retourne "Vous-même" si l'utilisateur connecté est l'auteur, sinon son nom complet.
        /// </summary>
        public string GetAffichageAuteur(int idConnecte)
        {
            return (IdVisiteur == idConnecte) ? "Vous-même" : NomPrenomAuteur;
        }
    }
}
