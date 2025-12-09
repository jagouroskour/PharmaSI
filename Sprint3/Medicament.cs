using System;

namespace Sprint3
{
    public class Medicament
    {
        // 1. Attributs privés correspondent à ta table SQL
        private string idMedicament;      // Le dépôt légal (ex: 3MORA)
        private string nomCommercial;     // Le nom (ex: 3-Moranol)
        private string idFamille;         // Le code famille (ex: ANT)
        private string libFamille;        // Le nom de la famille (ex: Antibiotique) 
        private string composition;
        private string effets;
        private string contreIndications;
        private float prixEchantillon;

        // 2. Constructeur pour fabriquer le médicament
        public Medicament(string unId, string unNom, string unIdFam, string unLibFam, string uneCompo, string desEffets, string desContreIndic, float unPrix)
        {
            this.idMedicament = unId;
            this.nomCommercial = unNom;
            this.idFamille = unIdFam;
            this.libFamille = unLibFam;
            this.composition = uneCompo;
            this.effets = desEffets;
            this.contreIndications = desContreIndic;
            this.prixEchantillon = unPrix;
        }

        // 3. Accesseurs 
        public string IdMedicament { get => idMedicament; }
        public string NomCommercial { get => nomCommercial; }
        public string IdFamille { get => idFamille; }
        public string LibFamille { get => libFamille; } // On affichera ça, c'est plus joli
        public string Composition { get => composition; }
        public string Effets { get => effets; }
        public string ContreIndications { get => contreIndications; }
        public float PrixEchantillon { get => prixEchantillon; }

        // 4. ToString pour l'affichage dans la liste déroulante
        public override string ToString()
        {
            return this.nomCommercial;
        }
    }
}