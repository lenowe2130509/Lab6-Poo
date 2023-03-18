using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class Pneu
    {
        protected string marque;
        protected int durabilite;

        public Pneu()
        {

        }

        public virtual int Rouler(temps route)
        {
            return 0;
        }

        public override string ToString()
        {
            string pneus = "";
            pneus += $" - Des pneus qui sont des pneus : ";
            return pneus;
        }
    }
}
