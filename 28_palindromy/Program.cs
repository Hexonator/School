using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_palindromy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string rev_word = "", word = Console.ReadLine();
                if (word != "")
                {
                    for (int i = word.Length - 1; i > -1; i--)
                    {
                        rev_word += word[i];
                    }
                    Console.WriteLine($"{word}-{rev_word}");

                    if (word == rev_word)
                    {
                        Console.WriteLine($"{word} is a palindrome!");
                    }
                    else
                    {
                        Console.WriteLine($"{word} is not a palindrome!");
                    }
                    Console.WriteLine("------------------------");
                }
                else
                {
                    Console.WriteLine("bruh it's empty of course it's a palindrome");
                    Console.WriteLine("------------------------");
                }

            }
        }
    }
}
