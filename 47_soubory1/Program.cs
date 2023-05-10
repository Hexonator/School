using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Nastroje pro praci se soubory

namespace _47_soubory1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr1 = new StreamReader("text.txt", Encoding.UTF8);
            string s1 = sr1.ReadToEnd();
            Console.WriteLine(s1);
            sr1.Close();

            using (StreamReader sr2 = new StreamReader(@"..\..\text2.txt", Encoding.UTF8)) // @"" = raw string; print("\\n") = \n
            {
                string s2 = sr2.ReadToEnd();
                Console.WriteLine(s2);
            }

            //Cteni souboru a pocitani radku

            using (StreamReader sr3 = new StreamReader(@"..\..\text2.txt", Encoding.UTF8))
            {
                string line;
                int linecount = 0;
                while ((line = sr3.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    linecount++;
                }
                Console.WriteLine($"text2.txt ma {linecount} radku");
            }


            Console.ReadKey();
        }
    }
}
