using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_pocet_samohlasek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string samohlasky = "aaeéěiíoóuúůyý";
            int pocet_samohlasek = 0;
            string veta = "Z této věty by se měly spočítat samohlásky";
            Console.WriteLine($"Věta: {veta}");

            foreach (var i in veta)
            {
                if (samohlasky.Contains(i))
                {
                    pocet_samohlasek++;
                }
            }
            Console.WriteLine($"Ve větě je {pocet_samohlasek} samohlasek");
            Console.ReadKey();
        }
    }
}
