using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class VUS : Vehicule
    {
        public VUS()
        {
            style = "VUS";
        }

        public override string ToString()
        {
            string VUS = "";

            VUS = $"Mon véhicule est un {style}. ";
            VUS += base.ToString();
            return VUS;
        }

        public override int seDeplacer(temps route)
        {
            int cout = 0;
            if (route == temps.sec)
            {
                cout = 2;
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
    }
}
