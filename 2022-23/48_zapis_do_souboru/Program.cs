using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_zapis_do_souboru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "žluťoučký kůň zpíval příliš ďábelské ódy";
            using (StreamWriter sw = new StreamWriter(@"..\..\new.txt", false))
            {
                sw.WriteLine(text);
                sw.WriteLine("ahoj");
                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i);
                }
            }
            string slovo;
            using (StreamWriter sw1 = new StreamWriter(@"..\..\words.txt"))
            {
                while(true)
                {
                    slovo = Console.ReadLine();
                    if (slovo != "konec")
                    {
                        sw1.WriteLine(slovo);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
