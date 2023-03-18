using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class Ete : Pneu
    {
        private string style;
        public Ete ()
        {
            marque = "Honda";
            durabilite = 10;
            style = "été";
        }

        public override int Rouler(temps route)
        {
            int cout = 0;
            if (route == temps.sec)
            {
                cout = 1;
            }
            else if (route == temps.mouille)
            {
                cout = 2;
            }
            else
            {
                cout = 3;
            }

            return cout;
        }

        public override string ToString()
        {
            string pneuEte = base.ToString();

            pneuEte += $"d'{style} ! ";
            return pneuEte;
        }

    }
}
