using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Armure[] armure = new Armure[7];
            armure[0] = new Armure();
            armure[1] = new Armure("cuir");
            armure[2] = new Armure(2);
            armure[3] = new Armure("cotte de maille", 5);
            armure[4] = new Bouclier();
            armure[5] = new Bouclier(3);
            armure[6] = new PetitBouclier();
            //Console.WriteLine(armure.ToString());
            Console.WriteLine(armure[0]);
            Console.WriteLine(armure[1]);
            Console.WriteLine(armure[2]);
            Console.WriteLine(armure[3]);
            Console.WriteLine(armure[4]);
            Console.WriteLine(armure[5]);
            Console.WriteLine(armure[6]);

            Console.ReadKey();
        }
    }
}
