using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    internal class Manzana : Fruta
    {
        public Manzana(string n, int x) : base(n, x)
        {
            this.name = "Manzana";
            this.effect = 3;
        }
    }
}
