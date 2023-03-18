using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V2._0
{
    internal class PetitBouclier : Bouclier
    {
        private string type;
        public PetitBouclier() : base(1)
        {
            type = "petit bouclier";
        }
    }
}
