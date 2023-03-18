using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class Hiver : Pneu
    {
        private string style;
        public Hiver()
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
                cout = 3;
            }
            else if (route == temps.mouille)
            {
                cout = 2;
            }
            else
            {
                cout = 1;
            }

            return cout;
        }

        public override string ToString()
        {
            string pneuHiver = base.ToString();

            pneuHiver += $"d'{style} ! ";
            return pneuHiver;
        }

    }


}
