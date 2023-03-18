using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class Vehicule
    {
        Pneu pneus;
        protected int poids;
        protected int consoCarburant;
        protected int qteCarburant;
        protected string style;

        public Vehicule()
        {
            poids = 500000;
            consoCarburant = 2;
            qteCarburant = 100;
            style = "";
            pneus = new Pneu();
        }


        public void SetPneu(Pneu pneu)
        {
            pneus = pneu;
        }

        public override string ToString()
        {
            string vehiculeuuuh = "";
            vehiculeuuuh += $"Celui-ci est composé de : {pneus} Son poids est de : {poids}, " +
                $"il utilise {consoCarburant}kg/L de CO² et peut contenir {qteCarburant} litres dans son réservoir !";
            return vehiculeuuuh;
        }


        public virtual int seDeplacer(temps route)
        {
            return 0;
        }


    }
}
