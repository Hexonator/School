using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // sečte čísla z klávesnice, ukončí nulou
            int suma = 0;
            int cislo;
            int pocet = 0;
            Console.WriteLine("Pis cisla a napis nulu pro ukonceni scitani");
            Console.Write("Zadej cislo: ");
            cislo = int.Parse(Console.ReadLine());

            //cyklus s podmínkou na začátku
            //provádí se tak dlouho, dokud je splněná podmíka
            while (cislo != 0)
            {
                suma += cislo;
                pocet++; // pocet += 1
                Console.Write("Zadej cislo: ");
                cislo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Soucet cisel je {suma} a jejich průměr {suma/pocet}");
            */

            //sečte čísla z klávesnice, ukončení nulou
            //cyklus s podmínkou na konci (provede minimálně jednou)

            int sumaD = 0;
            int cisloD;

            do
            {
                Console.Write("Zadej cislo: ");
                cisloD = int.Parse(Console.ReadLine());
                sumaD += cisloD;
            } while (cisloD != 0);

            Console.WriteLine($"souce cisel je {sumaD}");
            Console.ReadKey();
        }
    }
}
