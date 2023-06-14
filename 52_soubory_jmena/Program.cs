using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_soubory_jmena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader names = new StreamReader(@"..\..\jmena.txt");
            int count = int.Parse(names.ReadLine());
            string[] name_array = new string[count];
            Console.WriteLine(count);
            for (int i = 0; i < 6 ; i++)
            {
                name_array[i] = names.ReadLine();
                Console.WriteLine(name_array[i]);
            }

            names.Close();



            StreamWriter names_output = new StreamWriter(@"..\..\jmena_output.txt");
            foreach (var name in name_array)
            {
                names_output.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
