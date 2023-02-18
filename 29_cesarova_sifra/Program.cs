using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_cesarova_sifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 65 - 90
            string code = "";
            string word = Console.ReadLine();
            int codenum = int.Parse(Console.ReadLine());
            for (int i = 0; i < word.Length; i++)
            {
                int char_num = word[i];
                char_num += codenum;
                if (char_num > 90)
                {
                    char_num -= 26;
                }
                else if (char_num < 65)
                {
                    char_num += 26;
                }
                code += (char)char_num;
            }
            Console.WriteLine(code);
            Console.ReadKey();
        }
    }
}
