using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _38_e_sito
{
    internal class Program
    {
        static void fill_array(bool[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = true;
            }
            array[0] = false;
            array[1] = false;
        }

        static void check_primes(bool[] array)
        {
            for (int num = 2; num < (Math.Sqrt(array.Length)); num++)
            {
                if (array[num] == true)
                {
                    for (int index = 1; index < array.Length-1; index++)
                    {
                        if (index%num == 0 && index != num)
                        {
                            array[index] = false;
                        }
                    }
                }
            }
        }

        static void write_primes(bool[] array)
        {
            int index = 0;
            foreach (var i in array)
            {
                Console.Write($"{index} {i} | ");
                if (index % 10 == 0 && index != 0)
                {
                    Console.WriteLine();
                }
                index++;
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void Main(string[] args)
        {
            bool[] array = new bool[101];
            fill_array(array);
            check_primes(array);
            write_primes(array);

            Console.ReadKey();
        }
    }
}
