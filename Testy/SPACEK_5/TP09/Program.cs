using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace TP09
{
    internal class Program
    {
        static string IsBinary(string text)
        {
            if (text == "")
            {
                return "neni binarni cislo";
            }
            foreach (var character in text)
            {
                if (!( character == '1' || character == '0'))
                {
                    return "neni binarni cislo";
                }
            }
            return "je binarni cislo";
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                string text = Console.ReadLine();
                Console.WriteLine(IsBinary(text));
            }

            Console.ReadLine();
        }
    }
}
