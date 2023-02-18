using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_serazovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int a, b, c, mezi;
                Console.Write("zadej A: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("zadej B: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("zadej C: ");
                c = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    mezi = a;
                    a = b;
                    b = mezi;
                }
                if (b > c)
                {
                    mezi = b;
                    b = c;
                    c = mezi;
                }
                if (a > b)
                {
                    mezi = a;
                    a = b;
                    b = mezi;
                }
                string s = "";
                Console.WriteLine(a + s + b + s + c);
                Console.WriteLine("--------------------------");
            }
        }
    }
}
