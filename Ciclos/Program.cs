using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Ciclos
            //  for, while, do while
            int w = 3;
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine("Contando...");
                Console.WriteLine(i);
            }


            while (w != 0)
            {
                Console.WriteLine("Me resto 1");
                w--;
                Console.WriteLine(w);
            };

        }
    }
}
