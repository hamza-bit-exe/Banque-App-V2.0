using System;

namespace BanqueAPP
{
    class Compte_Epargne : Compte
    {
        private double taux_interet;

        
        public Compte_Epargne(Client titu, MAD somme, double taux_interet)
            : base(titu, somme)
        {
            this.taux_interet = taux_interet;
        }

        public void calcule_interet()
        {
            this.solde = this.solde * (1 + this.taux_interet / 100);
        }

    }
}
