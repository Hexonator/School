using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_dvoupole_procvicovani
{
    internal class Program
    {
        static void vypis_pole(int[,] pole)
        {
            for (int r = 0; r < pole.GetLength(0); r++)
            {
                for (int s = 0; s < pole.GetLength(1); s++)
                {
                    Console.Write($"{pole[r, s]} ");
                }
                Console.WriteLine();
            }
        }
        static void random_fill(int[,] array)
        {
            Random rand = new Random();
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int s = 0; s < array.GetLength(1); s++)
                {
                    array[r, s] = rand.Next(10, 99);
                }
            }
        }

        static int biggest_on_diagonal(int[,] array)
        {
            int biggest_num = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (biggest_num < array[i, i])
                {
                    biggest_num = array[i, i];
                }
            }
            return biggest_num;
        }

        static void smaller_than_input(int[,] array)
        {
            int input = int.Parse(Console.ReadLine());
            for (int r = 0; r < array.GetLength(0); r++)
            {
                if (r < 9)
                    Console.Write($"{r + 1} | ");
                else
                    Console.Write($"{r + 1}| ");

                for (int s = 0; s < array.GetLength(1); s++)
                {
                    if (input > array[r, s])
                    {
                        Console.Write($" [{r},{s}] ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            const int radek = 10;
            const int sloupec = 10;
            int[,] dve_dimenze = new int[radek, sloupec];
            vypis_pole(dve_dimenze);
            Console.WriteLine();
            random_fill(dve_dimenze);
            vypis_pole(dve_dimenze);
            Console.WriteLine();
            Console.WriteLine(biggest_on_diagonal(dve_dimenze));
            Console.WriteLine();
            smaller_than_input(dve_dimenze);

            Console.ReadKey();
        }
    }
}
