using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_while_nejvetsi_spolecny_delitel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Napis a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Napis b: ");
            b = int.Parse(Console.ReadLine());
            int a_save = a;
            int b_save = b;

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            Console.WriteLine($"Největší společný dělitel {a_save} a {b_save} je {a}");
            Console.ReadKey();
        }
    }
}
