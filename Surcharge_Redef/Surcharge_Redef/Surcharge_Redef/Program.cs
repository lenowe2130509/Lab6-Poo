using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surcharge_Redef
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employe empl1 = new Employe("Joe");

            //ne fonctionne pas
            //Console.WriteLine(empl1.count_Employe);

            Console.WriteLine(Employe.count_Employe);
            Employe empl2 = new Employe("Bob" , 5);

            Console.WriteLine(Employe.count_Employe);

            //Appel la fonction override
            Console.WriteLine(empl2.ToString());

            //Appel automatiquement la fonction ToString() 
            Console.WriteLine(empl2);


            //Effet de la spécialisation 
            Employe prof = new Prof("Vincent", 13);
            Console.WriteLine(prof.ToString());

            if (empl1 > empl2)
                Console.WriteLine(empl1);
            else
                Console.WriteLine(empl2);

            Console.ReadKey();
        }
    }
}
