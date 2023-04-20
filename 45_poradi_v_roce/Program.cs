using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _45_poradi_v_roce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] month_lengths = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            Console.WriteLine("napis datum ve formatu X.X.");
            Console.WriteLine("enter pro ukonceni programu");
            Console.WriteLine();

            //int year_length = 0;
            //foreach (var month in month_lengths)
            //{
            //    year_length += month;
            //}
            //Console.WriteLine(year_length);

            while (true)
            {
                Console.Write("Datum: ");
                string date = Console.ReadLine();

                if (date == "")
                {
                    break;
                }

                int month = 0;
                int day = 0;
                bool dayDone = false;
                foreach (var character in date)
                {
                    if (character != '.' && !dayDone)
                    {
                        day = int.Parse(Convert.ToString(day) + character);
                        continue;
                    }
                    else if (!dayDone)
                    {
                        dayDone = true;
                        continue;
                    }

                    if (character != '.' && dayDone)
                    {
                        month = int.Parse(Convert.ToString(month) + character);
                    }
                }

                //Console.WriteLine(day);
                //Console.WriteLine(month);

                int day_number = 0;
                for (int i = 0; i < month-1; i++)
                {
                    day_number += month_lengths[i];
                }
                day_number += day;

                Console.WriteLine(day_number);
            }
        }
    }
}
