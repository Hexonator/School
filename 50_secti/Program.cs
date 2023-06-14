using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_secti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader numbers = new StreamReader(@"..\..\cisla.txt"))
            {
                string numbers_read = numbers.ReadLine();
                while (numbers_read != null)
                {
                    bool isFirst = true;
                    string str1 = "", str2 = "";
                    int num1, num2;
                    foreach (var digit in numbers_read)
                    {
                        if (isFirst && digit != ' ')
                        {
                            str1 += digit;
                        }
                        else if (isFirst && digit == ' ')
                        {
                            isFirst= false;
                        }
                        else
                        {
                            str2+= digit;
                        }
                    }
                    num1 = int.Parse(str1);
                    num2 = int.Parse(str2);
                    Console.WriteLine(num1 + num2);

                    numbers_read = numbers.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
