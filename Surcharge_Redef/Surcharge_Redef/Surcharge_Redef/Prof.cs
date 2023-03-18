using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surcharge_Redef
{
    class Prof : Employe
    {

        public Prof(string nom) :base(nom)
        {

        }
        //Surcharge du constructeur
        public Prof(string nom,int anciennete) : base(nom, anciennete)
        {

        }

        public override string ToString()
        {
            string info = base.ToString();

            info += " Je suis un prof ";
            return info;
        }

       
    }
}
