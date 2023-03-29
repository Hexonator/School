using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_list
{
    internal class Program
    {
        static void Write_list(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Divider();
        }

        static void Divider()
        {
            Console.WriteLine("----------------");
        }
        static void Main(string[] args)
        {
            List<string> days = new List<string>();
            //Pridani polozek po jedne
            days.Add("Pondeli");
            days.Add("Utery");
            days.Add("Streda");
            days.Add("Ctvrtek");
            days.Add("Patek");
            days.Add("Sobota");
            days.Add("Nedele");
            Write_list(days);

            // Vypis polozky s urcitym indexem
            Console.WriteLine($"polozka s indexem 0 je {days[0]}");
            Divider();

            // Mazani polozky podle indexu
            days.RemoveAt(0);
            Write_list(days);

            // Mazani polozky podle obsahu
            days.Remove("Utery");
            Write_list(days);


            Console.ReadKey();
        }
    }
}
