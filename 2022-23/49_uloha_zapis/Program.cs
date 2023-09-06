using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _49_uloha_zapis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word;
            //List<string> words = new List<string>(10);
            //while (true)
            //{
            //    word = Console.ReadLine();
            //    if (word == "")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        words.Add(word);
            //    }
            //}
            //using (StreamWriter even = new StreamWriter(@"..\..\even.txt"))
            //{
            //    for (int i = 0; i < words.Count - 1; i +=2)
            //    {
            //        even.WriteLine(words[i]);
            //    }
            //}
            //using (StreamWriter odd = new StreamWriter(@"..\..\odd.txt"))
            //{
            //    for (int i = 1; i < words.Count - 1; i+=2)
            //    {
            //        odd.WriteLine(words[i]);
            //    }
            //}

            StreamWriter even = new StreamWriter(@"..\..\even.txt");
            StreamWriter odd = new StreamWriter(@"..\..\odd.txt");

            string word;
            bool isEven = true;
            while (true)
            {
                word = Console.ReadLine();
                if (word == "")
                {
                    break;
                }
                else
                {
                    if (isEven)
                    {
                        even.WriteLine(word);
                    }
                    else
                    {
                        odd.WriteLine(word);
                    }
                    isEven = !isEven;
                }
            }

            even.Close();
            odd.Close();
        }
    }
}
