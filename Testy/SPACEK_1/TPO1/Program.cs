using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num1, num2, num3, num4;
                Console.Write("Prvni cislo: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Druhe cislo: ");
                num2 = int.Parse(Console.ReadLine());
                Console.Write("Treti cislo: ");
                num3 = int.Parse(Console.ReadLine());
                Console.Write("Ctvrte cislo: ");
                num4 = int.Parse(Console.ReadLine());

                int rect1, rect2;
                rect1 = num1 * num2;
                rect2 = num3 * num4;
                if (rect1 > rect2)
                    Console.WriteLine("Obdélník se stranami " + num1 + "x" + num2 + "cm má větší obsah než obdélník se stranami " + num3 + "x" + num4 + "cm.");
                else
                    Console.WriteLine("Obdélník se stranami " + num3 + "x" + num4 + "cm má větší obsah než obdélník se stranami " + num1 + "x" + num2 + "cm.");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
