using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_V2._0
{
    class Armure
    {
        private string type;
        private int protection;

        public Armure()
        {
            type = "protection";
            protection = 0;
        }

        public Armure(string type)
        {
            this.type = type;
            protection = 1;
        }

        public Armure(int protection)
        {
            this.protection = protection;
            type = "protection";
        }

        public Armure(string type, int protection)
        {
            this.type = type;
            this.protection = protection;
        }

        public override string ToString()
        {
            return $"Je suis une protection de type {type} ma protection est de {protection} ! ";
        }
    }
}
