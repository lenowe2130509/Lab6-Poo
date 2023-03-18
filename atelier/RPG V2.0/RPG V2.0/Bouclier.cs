using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V2._0
{
    internal class Bouclier : Armure
    {

        public Bouclier()
        {

        }

        public Bouclier(int protection) : base(protection)
        {

        }

        public override string ToString()
        {
            string info = base.ToString();
            info += "Je suis un bouclier ! ";
            return info;
        }
    }
}
