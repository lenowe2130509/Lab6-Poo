using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Voiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Simulateur simulateur = new Simulateur();
            simulateur.lancerSimulateur();
            Console.ReadKey();
        }
    }
}
