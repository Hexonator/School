using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_nejvetsi_spolecny_delitel_n_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, mezipocet;
            Console.Write("Pocet cisel: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Napis cislo 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Napis cislo 2: ");
            b = int.Parse(Console.ReadLine());

            mezipocet = a;

            for (int i = 0; i < n-2; i++)
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                Console.Write($"Napis cislo {i+3}: ");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Nejvetsi delitelne cislo je {a}");
            Console.ReadKey();
        }
    }
}
