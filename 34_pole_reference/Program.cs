using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_pole_reference
{
    internal class Program
    {
        static void VypisPole(int[] pole)
        {
            foreach (var i in pole)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
            static void Main(string[] args)
        {
            // Pole je referenční datový typ, to znamená, že pole jsou jen odkazy k datům
            int[] pole1 = new int[] { 1, 2, 3 };
            int[] pole2 = new int[] { 4, 5, 6 };
            VypisPole(pole1);
            VypisPole(pole2);
            Console.WriteLine();
            pole1 = pole2; // Tady je pole 1 propojené s polem 2 a tím pádem se ztrácí původní odkaz pole 1
            VypisPole(pole1);
            VypisPole(pole2);
            Console.WriteLine();
            pole1[1] = 100; // Sice se mění pole 1 ale má odkaz k poli 2, takže prakticky mění pole 2
            pole2[2] = 1000;
            VypisPole(pole1);
            VypisPole(pole2);

            Console.ReadKey();
        }
    }
}
