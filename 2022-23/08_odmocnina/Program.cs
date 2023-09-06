using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_odmocnina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadej číslo z klávesnice a vypočítej odmocninu

            while (true)
            {
                double cislo;
                Console.Write("zadej cislo k odmocneni: ");
                cislo = double.Parse(Console.ReadLine());
                if (cislo >= 0)
                {
                    Console.Write("vysledek: ");
                    Console.WriteLine(Math.Sqrt(cislo));
                }
                else
                {
                    Console.WriteLine("nelze odmocnit zaporne cislo");
                }
                List<string> list = ["a", "b"];
                for (int i = 0; i == list.Count; i++)
                {
                    
                }

                Console.WriteLine("");
                Console.WriteLine("-----------------------");
                Console.WriteLine("");
            }
        }
    }
}
