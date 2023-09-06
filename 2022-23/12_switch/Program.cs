using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo 1-7, vypíšu den");
            while (true)
            {
                string volba = Console.ReadLine();
                switch (volba)
                {
                    case "1":
                        Console.WriteLine("pondělí");
                        break;
                    case "2":
                        Console.WriteLine("úterý");
                        break;
                    case "3":
                        Console.WriteLine("středa");
                        break;
                    case "4":
                        Console.WriteLine("čtvrtek");
                        break;
                    case "5":
                        Console.WriteLine("pátek");
                        break;
                    case "6":
                        Console.WriteLine("sobota");
                        break;
                    case "7":
                        Console.WriteLine("neděle");
                        break;
                    default:
                        Console.WriteLine("číslo od 1 do 7 ty demente");
                        break;
                }
                Console.WriteLine("----------------");
            }
        }
    }
}
