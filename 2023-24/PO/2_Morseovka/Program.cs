using System.Net.Http.Headers;
using Microsoft.VisualBasic;
using System.Threading;

namespace _2_Morseovka
{
    class Program
    {
        static Dictionary<char, string> CreateDictOfAlphabet(string filename)
        {
            Dictionary<char, string> morsecode = new();
            using (StreamReader sr = new(filename))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    morsecode.Add(line[0], line[2..]);

                    line = sr.ReadLine();
                }
            }
            return morsecode;
        }

        static void TranslateMorseCode(string text_for_translation, Dictionary<char, string> morsecode)
        {
            string upper_text = text_for_translation.ToUpper();
            foreach (var letter in upper_text)
            {
                if (!morsecode.ContainsKey(letter) && letter != ' ')
                {
                    Console.Write("*unknown*/ ");
                    continue;
                }
                if (letter == ' ')
                {
                    Console.Write(" //");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.Write(morsecode[letter]);
                    foreach (var beep in morsecode[letter])
                    {
                        int beep_length = 100;
                        int frequency = 2000;
                        if (beep == '.')
                        {
                            Console.Beep(frequency, beep_length);
                        }
                        else
                        {
                            Console.Beep(frequency, beep_length*2);
                        }
                        Thread.Sleep(70);
                    }
                    Console.Write("/");
                    Thread.Sleep(200);
                }
            }
        }
        static void Main(string[] args)
        {
            Dictionary<char, string> morsecode = CreateDictOfAlphabet("morseovka.txt");
            Console.WriteLine(morsecode);
            Console.WriteLine("Morse code loaded");

            while(true)
            {
                Console.Write("Write your word:");
                TranslateMorseCode(Console.ReadLine(), morsecode);
                Console.ReadKey();
            }
            
        }
    }
}