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
    static void CodeASCIIart(string filename, bool doReadkey){
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
            if (doReadkey)
            {
                Console.ReadKey();
            }
    }

    static void DecodeASCIIart(string input_filename, string output_filename)
    {
        StreamWriter output = new (output_filename);
        StreamReader input = new(input_filename, Encoding.UTF8);
        string line = input.ReadLine();
        while (line != null)
        {
            char lastchar = line[0];
            int counter = -1;
            if (line == "")
            {
                output.WriteLine();
            }
            else
            {
                foreach (var character in line)
                {
                    if (character == lastchar)
                    {
                        counter++;
                    }
                    else
                    {
                        output.WriteLine($"{character}{counter}");
                        counter = 1;
                    }
                    lastchar = character;
                }
                line = input.ReadLine();
                output.WriteLine();
            }
        }
        input.Close();
        output.Close();
    }
    static void Main(string[] args)
    {
        // for (int i = 1; i <= 7; i++)
        // {
        //     CodeASCIIart($"ascii-{i}.txt", false);
        // }
        // Console.ReadKey();

        DecodeASCIIart("fullascii-1.txt", "fullascii_output-1.txt");

        CodeASCIIart("fullascii_output-1.txt", true);
    }
}
