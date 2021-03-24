﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Client c1 = new Client("Zouhri","Hamza","casa");
            Client c2 = new Client("Aya", "zouhri", "rabat");
            MAD solde1 = new MAD(8000);
            MAD solde4 = new MAD(100);
            solde1.afficher();
            Compte cc1 = new Compte(c2, solde1);
            cc1.crediter(solde4);
            cc1.debiter(solde4);
            cc1.consulter();
            Compte_Epargne cpt = new Compte_Epargne(c1, solde1,50);
            cpt.calcule_interet();
            
            cpt.consulter();

            Console.ReadKey();


        }
    }
}
