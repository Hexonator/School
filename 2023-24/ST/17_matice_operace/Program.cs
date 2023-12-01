using System;
using System.Collections;
using System.IO;
using System.Numerics;

namespace _17_matice_operace
{
    class Program
    {
        static List<List<int>> ReadMatrixFromFile(string location)
        {
            List<List<int>> matrix = new();
            string data = "";

            using(StreamReader sr = new(location))
            {
                data = sr.ReadToEnd();
            }

            int count = 0;
            int line = 0;
            int height, width = 0;
            string placeholder = "";
            foreach (var character in data)
            {
                if (character == ' ' || character == '\n')
                {
                    switch (count)
                    {
                        case 0:
                            height = int.Parse(placeholder);
                            for (int i = 0; i < height; i++)
                            {
                                matrix.Add(new List<int> {});
                            }
                            break;
                        case 1:
                            width = int.Parse(placeholder);
                            break;
                        default:
                            if ((count - 2) % width == 0)
                            {
                                line = (count-2) / width;
                            }
                            matrix[line].Add(int.Parse(placeholder));
                            break;
                    }
                    count++;
                    placeholder = "";
                }
                else if(character == '\r')
                {
                    continue;
                }
                else
                {
                    placeholder += character;
                }
            }

            return matrix;
        }
        static void Main(string[] args)
        {
            List<List<int>> matrix1 = ReadMatrixFromFile("matrix1.txt");
            Console.WriteLine(matrix1);
        }
    }
}
