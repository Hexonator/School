using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_posloupnosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader data = new StreamReader(@"..\..\posloupnosti.txt", Encoding.UTF8))
            {
                string line;
                int sequence_counter = 1;
                List<int> seq = new List<int>(5);
                while(true)
                {
                    // Converting data to lists
                    line = data.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string number = "";
                    foreach (var character in line)
                    {
                        if (character != ' '){
                            number += character;
                        }
                        else{
                            seq.Add(int.Parse(number));
                            number = "";
                        }
                    }
                    seq.Add(int.Parse(number));

                    // Check if sequence is long enough
                    if (seq.Count < 3)
                    {
                        Console.WriteLine($"Sequence {sequence_counter} is not long enough");
                        seq = new List<int>(5);
                        sequence_counter++;
                        continue;
                    }

                    // Check if nummbers are in order
                    int lastnum = 0;
                    bool breakHappened = false;
                    foreach (var num in seq)
                    {
                        if (num < lastnum)
                        {
                            Console.WriteLine($"Sequence {sequence_counter} is invalid. Numbers aren't in order");
                            breakHappened = true;
                            break;
                        }
                        lastnum = num;
                    }

                    if (breakHappened) { continue; }

                    // Check if numbers are in equal increments
                    int delta;
                    bool isEquallyIncremented = true;
                    for (int i = 0; i <= seq.Count-3 && isEquallyIncremented; i++)
                    {
                        delta = seq[i+1] - seq[i];
                        if (seq[i] + 2 * delta != seq[i+2])
                        {
                            Console.WriteLine($"Sequence {sequence_counter} is not equally incremented");
                            isEquallyIncremented = false;
                            break;
                        }
                    }

                    if (isEquallyIncremented)
                    {
                        Console.WriteLine($"Sequence {sequence_counter} is equally incremented");
                    }

                    // Check if numbers are in exponential increments
                    for (int i = 0; i < seq.Count-1; i++)
                    {
                        
                    }


                    seq = new List<int>(5);
                    sequence_counter++;
                }
            }

            Console.ReadKey();
        }
    }
}
