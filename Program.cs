using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manzana manz = new Manzana("Manzana", 3);
            Durian dur = new Durian("Durian", -5);
            Jugador player = new Jugador(4);
            /* estás lejos de casa y tienes hambre
             * manzana: +3, ya no tienes hambre, llegas a casa
             * durian: -5, estaba pasada, game over
             * ninguna: te quedas con hambre
            */

            Console.WriteLine("Fuiste a caminar, pero te perdiste y estás lejos de casa. Tienes mucha hambre");
            Console.WriteLine("En el camino encuentras una canasta con dos frutas: una manzana y un durian. Estás contemplando tomar alguna para saciar tu hambre en el camino.");
            Console.WriteLine("1 - Manzana\n2 - Durian\n3 - Pasar de largo");
            string x = Console.ReadLine();
            switch (x)
            {
                default: break;
                case "1": Console.WriteLine(""); break;
                case "2": Console.WriteLine(""); break;
                case "3": Console.WriteLine(""); break;
            }
        }
    }
}
