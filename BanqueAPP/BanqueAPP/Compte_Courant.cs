﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Compte_Courant :Compte
    {
       private   MAD decouvert;
        public Compte_Courant(Client titu, MAD somme, MAD dec)
            : base(titu, somme)
        {
            this.decouvert = dec;

        }

        
             public bool crediter(MAD somme)
        {

            MAD valnul = new MAD(0);
            if (somme > valnul)
            {
                this.solde += somme;

          
                return true;
            }
            return false;
        }
        public override bool debiter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul)
            {
                if (plafond > somme)
                {
                    if (this.solde > somme && somme<decouvert)
                    {

                        this.solde -= somme;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("somme > solde ");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("somme > plafond ");
                    return false;

                }
            }
            else
            {
                Console.WriteLine("somme  invalide ");
                return false;
            }

        }

    }
}
