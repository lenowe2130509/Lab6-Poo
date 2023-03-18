using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    enum temps
    {
        sec,
        mouille,
        enneige
    }

    internal class Simulateur
    {
        Vehicule[] vehicules = new Vehicule[3];
        Pneu[] pneu = new Pneu[3];

        public Simulateur()
        {
            vehicules[0] = new Voiture();
            vehicules[0].SetPneu(new Ete());
            vehicules[1] = new VUS();
            vehicules[1].SetPneu(new Hiver());
            vehicules[2] = new Camion();
            vehicules[2].SetPneu(new TouteSaisons());
            pneu[0] = new Ete();
            pneu[1] = new Hiver();
            pneu[2] = new TouteSaisons();

        }

        public void lancerSimulateur()
        {

            temps[] temps = new temps[4];
            temps[0] = Simulation_Voiture.temps.sec;
            temps[1] = Simulation_Voiture.temps.mouille;
            temps[2] = Simulation_Voiture.temps.enneige;
            temps[3] = Simulation_Voiture.temps.enneige;

            Console.WriteLine($"Le parcours est : {temps[1]}, {temps[2]}, {temps[0]}, {temps[1]}. ");         
            
            int coutDeplacement = 0;

            for(int j = 0; j < vehicules.Length; j++)
            {
                Console.WriteLine(vehicules[j].ToString());

                for (int i = 0; i < temps.Length; i++)
                {
                    coutDeplacement += vehicules[j].seDeplacer(temps[i]);
                }
                Console.WriteLine($"Le coup de déplacement pour les pneus et le véhicule est de {coutDeplacement} \n");
                coutDeplacement = 0;
            }

            for (int j = 0; j < pneu.Length; j++)
            {
                Console.WriteLine(pneu[j].ToString());

                for (int i = 0; i < temps.Length; i++)
                {
                    coutDeplacement += pneu[j].Rouler(temps[i]);
                }
                Console.WriteLine($"Le coup de déplacement pour les pneus et le véhicule est de {coutDeplacement} \n");
                coutDeplacement = 0;
            }
        }

    }
}
