using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class TouteSaisons : Pneu
    {
        private string style;
        public TouteSaisons()
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
                cout = 1;
            }
            else
            {
                cout = 2;
            }

            return cout;
        }

        public override string ToString()
        {
            string pneu4Saisons = base.ToString();

            pneu4Saisons += $"d'{style} ! ";
            return pneu4Saisons;
        }

    }
}
