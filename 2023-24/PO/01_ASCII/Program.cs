using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _01_ASCII;

class Program
{
    static void CodeASCIIart(string filename){
        using (StreamReader text = new(filename, Encoding.UTF8))
            {
                string line = text.ReadLine();
                while (line != null)
                {
                    if (line == "")
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int j = 0; j < int.Parse(line[1..]); j++)
                        {
                            Console.Write(line[0]);
                        }
                    }
                    line = text.ReadLine();
                }
            }
            Console.ReadKey();
    }

    static void DecodeASCIIart(string input_filename, string output_filename)
    {
        StreamWriter output = new (output_filename);
        StreamReader input = new(input_filename, Encoding.UTF8);
        string line = input.ReadLine();
        if (line != null)
        {
            char lastchar = line[0];
            int counter = -1;
            foreach (var character in line)
            {
                if (character == lastchar)
                {
                    counter++;
                }
                else
                {
                    output.Write($"{lastchar}{counter}");
                    counter = 0;
                }
                lastchar = character;
            }
        }
        input.Close();
        output.Close();
    }
    static void Main(string[] args)
    {
        for (int i = 1; i <= 7; i++)
        {
            CodeASCIIart($"ascii-{i}.txt");
        }
        Console.ReadKey();

        DecodeASCIIart("fullascii-1.txt", "fullascii_output-1.txt");
    }
}
