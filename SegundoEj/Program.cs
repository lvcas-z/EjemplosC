using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxtisGral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de Variables 
            int a, b, c , ejCasteoExpl;
            float d, e, f;

            // double,decimal,long,short,string datetime

            a = 1;
            b = 2;
            d = 3;
            f = 4;

            Console.WriteLine("-----------------");
            c = a + b;
            Console.WriteLine("El resultado de la variable C es : " + c);

            Console.WriteLine("-----------------");
            e = f - d;
            Console.WriteLine("El resultado de la variable e es : " + e);

            Console.WriteLine("-----------------");
            Console.WriteLine("Ingresa un numero para ej de casteo explicito: ");
            ejCasteoExpl = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero de casteo explicito es : " + ejCasteoExpl);


            Console.ReadKey();
        }
    }
}
