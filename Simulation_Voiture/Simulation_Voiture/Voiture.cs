using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class Voiture : Vehicule
    {
        public Voiture()
        {
            style = "voiture";
        }

        public override string ToString()
        {
            string voiture = "";

            voiture = $"Mon véhicule est une {style}. ";
            voiture += base.ToString();
            return voiture;
        }

        public override int seDeplacer(temps route)
        {
            int cout = 0;
            if(route == temps.sec)
            {
                cout = 1;
            }
            else if(route == temps.mouille)
            {
                cout = 2;
            }
            else
            {
                cout = 3;
            }
            //Tu mets dans la variable cout le int retourner par seDeplacer(route) sachant qu'il faut faire le get Set de pneu
            //cout = this.Pneu.seDeplqcer(route);
            return cout;
        }
    }
}
