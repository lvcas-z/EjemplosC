using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales 
            int a, b;
            a = 17;
            b = 19;

            // == != > < >= <=


            if (a > 18 && b > 18)
            {
                Console.WriteLine("Pueden ingresar los dos");
            }
            else if (a> 18 && b < 18)
                Console.WriteLine("Solo puede ingresar A");
            else if (a< 18 && b> 18)                            // Ej de una linea de res
                Console.WriteLine("Solo puede ingresar B");
            else
            {                                                           // Ej de una bloque de mas de una linea
                Console.WriteLine("No puede ingresar ninguno");
                Console.WriteLine("Porfavor Retirarse");
            }



        }
    }
}
