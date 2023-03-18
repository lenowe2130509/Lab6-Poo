using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class Camion : Vehicule
    {
        public Camion()
        {
            style = "Camion";
        }

        public override string ToString()
        {
            string Camion = "";

            Camion = $"Mon véhicule est un {style}. ";
            Camion += base.ToString();
            return Camion;
        }

        public override int seDeplacer(temps route)
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
    }
}
