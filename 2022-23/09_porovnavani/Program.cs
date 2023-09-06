using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_porovnavani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, c;
                Console.Write("zadej A: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("zadej B: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("zadej C: ");
                c = int.Parse(Console.ReadLine());

                string maxStr;
                int max;
                if (a > b)
                {
                    max = a;
                    maxStr = "A";
                }
                else
                {
                    max = b;
                    maxStr = "B";
                }

                if (c > max)
                {
                    max = c;
                    maxStr = "C";
                }

                Console.WriteLine("The biggest number is " + maxStr + " " + max);

                Console.WriteLine("--------------------");
                Console.ReadKey();
            }
        }
    }
}
