using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_metody_odkaz_hodnota
{
    internal class Program
    {
        // NEMĚLI BYCHOM VRACET HODNOTY PŘES "ref" KDYŽ JE MŮŽEME VRACET POMOCÍ FUNKCE!!
        static void vypocetH(int h)
        {
            h *= h;
            Console.WriteLine($"hodnota uvnitř metody je {h}");
        }
        static void vypocetO(ref int h)
        {
            h *= h;
            Console.WriteLine($"hodnota uvnitř metody je {h}");
        }
        static void Main(string[] args)
        {
            int cislo = 5;
            Console.WriteLine($"hodnota před zavoláním metody vypocetH {cislo}");
            vypocetH(cislo);
            Console.WriteLine($"hodnota po zavolání metody vypocetH {cislo}");

            // "O" jako odkaz
            int cisloO = 5;
            Console.WriteLine($"hodnota před zavoláním metody vypocetO {cisloO}");
            vypocetO(ref cisloO);
            Console.WriteLine($"hodnota po zavolání metody vypocetO {cisloO}");

            Console.ReadLine();
        }
    }
}
