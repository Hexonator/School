using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_metody_procvicovani
{
    internal class Program
    {
        static double Prepona(int prepona_a, int prepona_b)
        {
            return Math.Sqrt(Math.Pow(prepona_a, 2) + Math.Pow(prepona_b, 2));
        }

        static double Mocnina(int a, int n)
        {
            if (a > 0 && n > 0)
                return Math.Pow(a, n);
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Prepona(5, 5));
            Console.WriteLine(Mocnina(2, 4));
            Console.ReadKey();
        }
    }
}
