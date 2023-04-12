using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_dictionary
{
    class Program
    {
        static void ExistujePolozka(Dictionary<int, string> dic, int key)
        {
            if (dic.ContainsKey(key))
            {
                Console.WriteLine($"polozka {key} existuje");
            }
            else
            {
                Console.WriteLine($"polozka {key} neexistuje");
            }
        }
        static void Main(string[] args)
        {
            // Vytvoreni slovniku s klicem int a hodnotou string
            Dictionary<int, string> jmena = new Dictionary<int, string>();
            jmena.Add(10, "Jan Novak");
            jmena.Add(15, "Alena Machu");
            jmena.Add(20, "Yuri Tarded");

            foreach (var clovek in jmena)
            {
                Console.WriteLine($"zamestnanec {clovek.Key}, jmeno {clovek.Value}");
            }

            Console.WriteLine($"Zamestanec cislo 20 je {jmena[20]}");

            ExistujePolozka(jmena, 9);
            ExistujePolozka(jmena, 20);


            Console.ReadKey();
        }
    }
}
