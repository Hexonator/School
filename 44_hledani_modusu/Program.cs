using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _44_hledani_modusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] {1, 2, 1, 8, 8, 1, 4, 5, 9, 8};
            Dictionary<int, int> number_counts = new Dictionary<int, int>(array.Length);

            foreach (var number in array)
            {
                if (number_counts.ContainsKey(number))
                {
                    number_counts[number]++;
                }
                else
                {
                    number_counts[number] = 1;
                }
            }

            int max = int.MinValue;
            List<int> most_frequent_numbers = new List<int>(array.Length);
            foreach(var key in number_counts.Keys)
            {
                if (number_counts[key] >= max)
                {
                    most_frequent_numbers.Add(key);
                    max = number_counts[key];
                }
            }

            Console.Write($"nejfrekventovanejsi cisla se objevila {max}x a jsou to:");
            foreach (var number in most_frequent_numbers)
            {
                Console.Write($" {number},");
            }

            Console.ReadKey();
        }
    }
}
