
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_jednorozmerne_pole
{
    internal class Program
    {
        static void VypisPole(int[] pole)
        {
            //for (int i = 0; i < pole.Length; i++)
            //{
            //    Console.Write(pole[i] + " ");
            //}
            foreach (var i in pole)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void VypisPole(char[] pole)
        {
            foreach (var i in pole)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void VypisPole(string[] pole)
        {
            foreach (var i in pole)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static int NejvetsiHodnota(int[] pole)
        {
            int max = int.MinValue;
            foreach (var i in pole)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static int[] FillWithRandom(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // Dokončit funkci
            }
        }
        static void Main(string[] args)
        {
            int[] pole = new int[3];
            pole[0] = 1;
            pole[1] = 2;
            pole[2] = 3;
            VypisPole(pole);

            int[] pole2 = new int[5] {10, 20, 30, 40, 50};
            // pětka nemusí být definovaná, je to ale rychlejší, když je známá velikost pole
            VypisPole(pole2);

            int[] pole3 = new int[10];
            for (int i = 0; i < pole3.Length; i++)
            {
                pole3[i] = (i + 1) * 100;
            }
            VypisPole(pole3);

            char[] pole_charu = new char[3] {'A', 'B', 'C'};
            VypisPole(pole_charu);

            string[] barvy = new string[5] {"modra", "zluta", "cervena", "oranzova", "ruzova"};

            VypisPole(barvy);
            Array.Sort(barvy);
            VypisPole(barvy);
            Array.Reverse(barvy);
            VypisPole(barvy);

            // Prace s knihovnou Random
            int[] random_array= new int[10];
            Random rand = new Random();
            for (int i = 0; i < random_array.Length; i++)
            {
                int num = rand.Next(0, random_array.Length);

                random_array[i] = num;
            }
            VypisPole(random_array);
            Console.WriteLine(NejvetsiHodnota(random_array));

            Console.ReadKey();
        }
    }
}
