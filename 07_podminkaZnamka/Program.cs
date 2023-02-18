using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_podminkaZnamka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zjisti, zda je známka intervalu <1,5>
            while (true)
            {
                int znamka;
                Console.Write("zapiš známku: ");
                znamka = int.Parse(Console.ReadLine());
                if (znamka >= 1 && znamka <= 5)
                {
                    Console.WriteLine("známka je v pořádku");
                }
                else if (znamka <= 6)
                {
                    Console.WriteLine("bruh what did you do");
                }
                else
                {
                    Console.WriteLine("neplatné číslo");
                }

                Console.WriteLine("--------------");
                Console.ReadKey();
            }
        }
    }
}
