using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_for_cyklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            //počet opakování z klávesnice
            Console.Write("Zadej číslo: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            //řídící proměnná nemusí být int
            double j;
            for (j = 0; j < n; j = j + 0.1)
            {
                Console.Write($" {j}");
            }
            Console.WriteLine();

            for (char i = ' '; i <= '}'; i++)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();


            //sečtení pěti čísel z klávesnice
            int soucet = 0;
            int cislo;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Zadej {i + 1} číslo: ");
                cislo = int.Parse(Console.ReadLine());
                soucet += cislo;
            }
            Console.WriteLine(soucet);

            Console.ReadKey();
            */
            //snižování řídící proměnné
            Console.WriteLine("wtf");
            for (int i = 10; i >= 0; i--)
            {
                Console.Write($" {i}");
            }


            Console.ReadKey();
        }
    }
}