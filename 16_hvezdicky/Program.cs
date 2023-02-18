using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_hvezdicky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            size = 10;
            /*
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();


            for (int i = 0; i < size; i++)
            {
                for (int k = 1; k < size-i; k++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();


            for (int i = size; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("  ");
                }
                for (int j = size; j > i; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
            */


            for (int i = 0; i < size; i++)
            {
                for (int k = 1; k < size - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int m = 0; m < 2; m++)
            {
                for (int i = 5; i < size; i++)
                {
                    for (int k = 1; k < size - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            }
            int trunk_width = size / 3;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= trunk_width; j++)
                    Console.Write("  ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
