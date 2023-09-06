using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_desetinna_cisla_text
{
    internal class Program
    {
        static List<double> findCloseFar(string location)
        {
            List<double> list = new List<double>();

            StreamReader numbers = new StreamReader(location);

            while (!numbers.EndOfStream)
            {
                list.Add(double.Parse(numbers.ReadLine()));
            }

            numbers.Close();

            foreach (var num in list)
            {
                Console.WriteLine(num);
            }

            find(list);

            return list;
        }

        static double getDistance(double a, double b)
        {
            return Math.Abs(a - b);
        }

        static void find(List<double> list)
        {
            Console.WriteLine();
            Console.Write("Your number:");
            double input = double.Parse(Console.ReadLine());
            double max = list[0];
            double min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                double num = list[i];

                if (getDistance(num, input) > getDistance(max, input))
                {
                    max = num;
                }

                if (getDistance(num, input) < getDistance(min, input))
                {
                    min = num;
                }
            }
            Console.WriteLine($"{min} is the closest number");
            Console.WriteLine($"{max} is the furthest number");
        }

        static void Main(string[] args)
        {
            List<double> listofnums = findCloseFar(@"..\..\cisla.txt");

            Console.ReadKey();
        }
    }
}
