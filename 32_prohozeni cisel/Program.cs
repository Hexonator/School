using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_prohozeni_cisel
{
    internal class Program
    {
        static void prohozeni(ref int a, ref int b)
        {
            int mezihodnota = a;
            a = b;
            b = mezihodnota;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            prohozeni(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
