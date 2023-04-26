using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO7
{
    internal class Program
    {
        static int[,] Vytvor_pole()
        {
            int[,] pole = new int[3, 5];
            return pole;
        }

        static void naplnPole(int[,] pole)
        {
            Random rand = new Random();
            for (int i = 0; i < pole.GetLength(1); i++)
            {
                for (int j = 0; j < pole.GetLength(0); j++)
                {
                    pole[j, i] = rand.Next(10, 29);
                }
            }
        }

        static void vypisPole(int[,] pole)
        {
            int counter = 5;
            foreach (var cislo in pole)
            {
                if (counter <= 0)
                {
                    Console.WriteLine();
                    counter = 5;
                }
                Console.Write($"{cislo} ");
                counter--;
            }
            Console.WriteLine();
        }

        static void soucetSloupcu(int[,] pole)
        {
            Console.WriteLine();
            vypisPole(pole);
            Console.Write("______________");
            int soucet;
            Console.WriteLine();
            for (int i = 0; i < pole.GetLength(1); i++)
            {
                soucet = 0;
                for (int j = 0; j < pole.GetLength(0); j++)
                {
                    soucet += pole[j, i];
                }
                Console.Write($"{soucet} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[,] pole = Vytvor_pole();
            naplnPole(pole);
            vypisPole(pole);
            soucetSloupcu(pole);

            Console.ReadKey();
        }
    }
}
