using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_podmínky_trojúhelníka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int A, B, C;
                Console.Write("zadej A: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("zadej B: ");
                B = int.Parse(Console.ReadLine());
                Console.Write("zadej C: ");
                C = int.Parse(Console.ReadLine());

                if (A * B * C != 0)
                {
                    if (A + B > C && B + C > A && A + C > B)
                    {
                        if (A == B && B == C)
                        {
                            Console.WriteLine("Trojúhelník je rovnostranný");
                        }
                        else if ((A != B && A == C) || (B != C && B == A) || (A != C && A == B))
                        {
                            Console.WriteLine("Trojúhelník je rovnoramenný");
                        }
                        else
                        {
                            Console.WriteLine("Trojůhelník je obecný");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Trojúhelník nelze sestrojit");
                    }
                }
                else
                {
                    Console.WriteLine("Trojůhelník neexistuje");
                }
                Console.WriteLine("--------------------");
            }
        }
    }
}
