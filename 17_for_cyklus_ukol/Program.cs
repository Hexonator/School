using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_for_cyklus_ukol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A,B;
            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("B can't be bigger than A");
            }
            else
            {
                int sum_of_odd, sum_of_even, odd_count, even_count;
                sum_of_odd = 0;
                odd_count = 0;
                even_count = 0;
                sum_of_even = 0;

                for (int i = A; i <= B + 2; i++)
                {
                    if (i%2 == 0)
                    {
                        sum_of_even += i;
                        even_count++;
                    }
                    else
                    {
                        sum_of_odd += i;
                        odd_count++;
                    }
                }

                Console.WriteLine("Průměr lichých čísel je " + sum_of_odd/odd_count + " a průměr sudých je " + sum_of_even/even_count);
            }
            Console.ReadKey();
        }
    }
}
