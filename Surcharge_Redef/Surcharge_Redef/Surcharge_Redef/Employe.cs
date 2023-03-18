using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surcharge_Redef
{
    class Employe
    {
        public static int count_Employe = 0;
        string nom;
        int no_Employe;
        int anciennete;

        
        public Employe(string nom)
        {
            count_Employe++;
            this.nom = nom;
            this.no_Employe = count_Employe;
            this.anciennete = 0;
        }

        public Employe(string nom, int anciennete)
        {
            count_Employe++;
            this.nom = nom;
            this.no_Employe = count_Employe;
            this.anciennete = anciennete;
        }

        public override string ToString()
        {
            return $"Nom : { nom }, no { no_Employe }, annee anciennete { anciennete } ";
        }

        //Les deux doivent être défini
        public static bool operator >( Employe emp1, Employe emp2)
        {
            return emp1.anciennete > emp2.anciennete;
        }
        public static bool operator <(Employe emp1, Employe emp2)
        {
            return emp1.anciennete < emp2.anciennete;
        }



    }
}
