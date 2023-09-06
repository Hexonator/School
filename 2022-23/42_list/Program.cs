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
        static void Write_list(List<int> list)
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
            List<string> days = new List<string>(7); // Je dobre priblizne urcovat jak velky list bude, protoze potom zabira min pameti
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

            // Vlozeni na index
            days.Insert(0, "Pondeli");
            days.Insert(1, "Utery");
            Write_list(days);

            // Zjisteni obsahu konkretniho prvku
            if (days.Contains("Streda"))
                Console.WriteLine("obsahuje");
            else
                Console.WriteLine("neobsahuje");
            Divider();

            //Zjisteni poctu prvku v listu
            Console.WriteLine($"Pocet prvku v listu je {days.Count}");


            Divider();

            List<int> list2 = new List<int>(10) { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            for(int i = 0; i < list2.Count; i++)
            {
                list2[i] = i*2;
            }
            Write_list(list2);

            Divider();

            List<string> colors = new List<string>(10);
            string line;
            do
            {
                line = Console.ReadLine();
                if (line == "konec")
                {
                    break;
                }
                colors.Add(line);
            } while (true);
            Console.WriteLine();
            Write_list(colors);
           

            Console.ReadKey();
        }
    }
}
