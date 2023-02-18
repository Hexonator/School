using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_znak_retezec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datový typ znak
            char znak = 'n';
            int cislo_znaku;
            cislo_znaku = znak;
            Console.WriteLine($"znak {znak} má v ASCII hodnotu {cislo_znaku}");

            int cislo_znaku2 = 429;

            Console.WriteLine($"cislo {cislo_znaku2} je v ASCII '{(char)cislo_znaku2}'");

            //datový typ řetězce - string
            string sentence = "Hello world!";
            Console.WriteLine(sentence);
            Console.WriteLine(sentence[3]);
            Console.WriteLine(sentence.Substring(3, 6));

            int length = sentence.Length;
            Console.WriteLine($"The sentence has {length} characters");

            string word = "    sunny   ";
            Console.WriteLine(word);
            Console.WriteLine(word.Trim());

            Console.WriteLine(sentence.Replace("world", "universe"));


            Console.ReadKey();
        }
    }
}
