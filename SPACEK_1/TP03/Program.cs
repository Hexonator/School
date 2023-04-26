using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4x + 3 < 5y");
            while (true)
            {
                int numX, numY;
                Console.Write("x = ");
                numX = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                numY = int.Parse(Console.ReadLine());

                if (4 * numX + 3 < 5 * numY)
                {
                    Console.WriteLine("Statement is true");
                    Console.WriteLine(4 * numX + 3 + " < " + numY*5);
                }
                else
                {
                    Console.WriteLine("Statement is false");
                    Console.WriteLine(4 * numX + 3 + " !< " + numY * 5);
                }

                Console.WriteLine("---------------------");
            }
        }
    }
}
