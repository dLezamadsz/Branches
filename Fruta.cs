using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    internal class Fruta
    {
        protected string name;
        protected int effect;

        public Fruta(string n, int x)
        {
            this.name = n;
            this.effect = x;
        }
    }
}
