using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    internal class Durian : Fruta
    {
        public Durian(string n, int x) : base(n, x)
        {
            this.name = "Durian";
            this.effect = -5;
        }
    }
}
