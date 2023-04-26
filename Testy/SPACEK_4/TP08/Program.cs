using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napis text: ");
            string text = Console.ReadLine();

            string upraveny_text = "";
            foreach (var znak in text)
            {
                if (znak == 'a' ||
                    znak == 'A' ||
                    znak == 'e' ||
                    znak == 'E' ||
                    znak == 'i' ||
                    znak == 'I' ||
                    znak == 'o' ||
                    znak == 'O' ||
                    znak == 'U' ||
                    znak == 'U')
                {
                    upraveny_text += "*";
                }
                else
                {
                    upraveny_text += znak;
                }
            }
            Console.WriteLine(upraveny_text);

            Console.ReadKey();
        }
    }
}
