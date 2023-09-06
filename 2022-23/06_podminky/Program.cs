using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_podminky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Neuplný podmíněný příkaz
                int c1, c2;
                Console.Write("zadej číslo: ");
                c1 = int.Parse(Console.ReadLine());
                Console.Write("zadej číslo: ");
                c2 = int.Parse(Console.ReadLine());

                if (c1 > c2)
                {
                    Console.WriteLine("prvni číslo je větší");
                }
                if (c2 > c1)
                {
                    Console.WriteLine("druhé číslo je větší");
                }
                if (c1 == c2)
                {
                    Console.WriteLine("obě čísla jsou stejná");
                }

                // Úplný podmíněný příkaz

                if (c1 == c2)
                {
                    Console.WriteLine("jsou stejná");
                }
                else if (c1 > c2)
                {
                    Console.WriteLine("prvni cislo je vetsi");
                }
                else
                {
                    Console.WriteLine("druhe cislo je vetsi");
                }

                Console.WriteLine("-----------------------------");
                Console.ReadKey();
            }
        }
    }
}
