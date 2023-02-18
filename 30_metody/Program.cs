using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_metody
{
    internal class Program
    {
        // Metoda bez parametrů
        // Metoda bez návratové hodnoty
        static void Line()
        {
            Console.WriteLine("-----------------");
        }

        // S parametry
        // Bez návratové hodnoty
        static void WriteXTimes(string text, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(text);
            }
        }

        // S parametry
        // S návratovou hodnotou
        static int XthPower(int num, int power)
        {
            int solution = 1;
            for (int i = 0; i < power; i++)
            {
                solution *= num;
            }
            return solution;
        }

        //  přetížení metod
        static int AddTogether(int a, int b)
        {
            return a + b;
        }

        static int AddTogether(int a, int b, int c)
        {
            return a + b + c;
        }

        static float AddTogether(float a, float b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Alt+F4 to quit");
            Line();
            /*while (true)
            {
                // Opakování textu
                Console.Write("Word: ");
                string text = Console.ReadLine();
                Console.Write("Count: ");
                int num = int.Parse(Console.ReadLine());
                Line();
                WriteXTimes(text, num);
                Line();

                // Mocnina
                Console.Write("Number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Power: ");
                int power = int.Parse(Console.ReadLine());
                Console.WriteLine(XthPower(num, power));
                Line();
            }*/
            Console.WriteLine(AddTogether(1, 2));
            Console.WriteLine(AddTogether(1, 2, 3));
            Console.WriteLine(AddTogether(2f, 5.1f));
            Console.ReadKey();
        }
    }
}
