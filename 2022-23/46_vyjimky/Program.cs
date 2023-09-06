using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_vyjimky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("Zadej prvni cislo: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Zadej druhe cislo: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    double c = a / b;
                    Console.WriteLine(c);
                }
                catch (DivideByZeroException exception)
                {
                    //Console.WriteLine("Nulou se neda delit");

                    Console.WriteLine(exception.Message);
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    // I kdyz je sama o sobe, napise, co je za problem ale neda se rozlisit, co se stane u vyjimek
                }
                finally
                {
                    Console.WriteLine("konec");
                    //provede se vzdy
                }

                Console.WriteLine("--------------------");
            }
        }
    }
}
