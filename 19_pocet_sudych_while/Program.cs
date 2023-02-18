using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_pocet_sudych_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet_sudych = 0;
            int cislo;
            Console.Write("Zadej cislo: ");
            cislo = int.Parse(Console.ReadLine());
            int cislo_save = cislo;

            while (cislo != 0)
            {
                if (cislo%2 == 0)
                {
                    pocet_sudych++;
                }
                cislo--;
            }
            Console.WriteLine($"v cisle {cislo_save} je {pocet_sudych} sudych cisel");
            Console.ReadKey();
        }
    }
}
