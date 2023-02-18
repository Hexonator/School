using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_for_cviceni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //zadej z klavesnice 10 cisel a zjisti kolik je kladných, záporných a nul
            Console.WriteLine("Zadej cisla a zjisti kolik je kladných, záporných a nula");
            Console.WriteLine();

            int kladna = 0, zaporna = 0, nuly = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Napis {i + 1} cislo: ");
                int cislo = int.Parse(Console.ReadLine());
                if (cislo > 0)
                {
                    kladna++;
                }
                else if (cislo < 0)
                {
                    zaporna++;
                }
                else
                {
                    nuly++;
                }
            }
            Console.WriteLine($" Napsal jsi {kladna} kladnych cisel");
            Console.WriteLine($" Napsal jsi {zaporna} zapornych cisel");
            Console.WriteLine($" Napsal jsi {nuly} nul");


            Console.ReadKey();
*/
            //vnoření cyklů
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
