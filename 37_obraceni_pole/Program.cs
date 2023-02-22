using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_obraceni_pole
{
    internal class Program
    {
        static void ReverseArray(int[] array)
        {
            int smaller_length = array.Length -1;
            int[] reverse_array = new int[array.Length];
            for (int i = 0; i < smaller_length; i++)
            {
                reverse_array[i] = array[smaller_length - i];
            }
            WriteArray(reverse_array);
        }
        static void WriteArray(int[] array)
        {
            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void FillArray(int[] array)
        {
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = num;
                num++;
            }
        }
        static void EvenIndex(int[] array)
        {
            int[] even_array = array;
            for (int i = 1; i <= array.Length - 1; i+2)
            {
                even_array[i] = 0;
            }
            WriteArray(even_array);
        }
        static void Main(string[] args)
        {
            int[] array = new int[20];
            FillArray(array);
            WriteArray(array);
            ReverseArray(array);
            EvenIndex(array);

            Console.ReadKey();
        }
    }
}
