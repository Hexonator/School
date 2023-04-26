using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1/XY");
            Console.WriteLine();
            while(true)
            {
                float numX, numY;
                Console.Write("X = ");
                numX = float.Parse(Console.ReadLine());
                Console.Write("Y = ");
                numY = float.Parse(Console.ReadLine());

                if (numX * numY == 0)
                    Console.WriteLine("Nedá se dělit nulovým číslem");
                else
                {
                    Console.WriteLine(1/(numX*numY));
                }

                Console.WriteLine("---------------");
            }
        }
    }
}
