using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Compte
    {
        private  readonly int numcomp;
        private static int cpt;
        private  readonly Client titulaire;
        protected MAD solde;
        protected  static MAD plafond;
        private List<Operation> op;
         static Compte()
        {
            cpt = 0;
            plafond = new MAD(2000);

        }
        public Compte(Client titu, MAD somme)
        {
            this.numcomp = ++cpt;
            this.titulaire = titu;
            this.solde = somme;
            op = new List<Operation>();
        }
        public Compte()
        {

        }
        public void consulter()
        {
            int j;
            Console.WriteLine("le num est :" + this.numcomp);
            this.titulaire.afficher();
            this.solde.afficher();
            for(j=0;j<op.Count;j++)
            
               op[j].afficher();
            
        }
        int i = 0;
        public  virtual bool crediter(MAD somme)
        {
            
            MAD valnul = new MAD(0);
            if (somme > valnul)
            {
                this.solde += somme;
                
                
                op.Add(new Operation("crediter", somme));
               
                
                return true;
            }
             return false;
        }

        public virtual bool debiter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul )
            {
                if(plafond > somme)
                {
                    if(this.solde > somme)
                    { 
                       
                           this.solde -= somme;

                        op.Add(new Operation("debiter", somme));

                       
                        return true;
                    }
                    else {
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

        public bool verser(Compte c, MAD somme)
        {
            if (this.debiter(somme))
            {
                c.crediter(somme);
                return true;
            }
            return false;


        }






    }
}





