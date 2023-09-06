using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_pole_procvicovani
{
    internal class Program
    {
        static void RandomArrayFill(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 9);
            }
        }
        static void WriteArray(int[] array)
        {
            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static int BiggestValue(int[] array)
        {
            int max = int.MinValue;
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        static int BiggestValueIndex(int[] array)
        {
            int max = BiggestValue(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    return i;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                int[] array = new int[10];
                WriteArray(array);
                RandomArrayFill(array);
                WriteArray(array);
                Console.WriteLine(BiggestValue(array));
                Console.WriteLine(BiggestValueIndex(array));

                Console.ReadKey();
                Console.WriteLine("-----------------");
            }
        }
    }
}
