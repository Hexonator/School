using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_dvourozmerne_pole
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
        static void random_fill(int[,] pole)
        {
            Random rand = new Random();
            for (int r = 0; r < pole.GetLength(0); r++)
            {
                for (int s = 0; s < pole.GetLength(1); s++)
                {
                    pole[r, s] = rand.Next(0, 100);
                }
            }
        }
        static void Main(string[] args)
        {
            //vytvoreni dvourozmerneho pole
            const int radek = 5;
            const int sloupec = 10;
            int[,] dve_dimenze = new int[radek, sloupec];

            //vypis_pole(dve_dimenze);

            Console.WriteLine();
            // Length - udava celkovou velikost pole
            // GetLength - velikost urcene dimenze (napr. 0 je radek nebo 1 sloupec)
            Random rand = new Random(); 
            int rand_radek = rand.Next(1, 20);
            int rand_sloupec = rand.Next(1, 20);
            int[,] pole_rand = new int[rand_radek, rand_sloupec];
            random_fill(pole_rand);
            vypis_pole(pole_rand);

            Console.ReadKey();
        }
    }
}
