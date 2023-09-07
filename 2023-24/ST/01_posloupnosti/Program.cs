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
                List<int> posloupnost = new List<int>(5);
                while(true)
                {
                    line = data.ReadLine();
                    if (line == null)
                    {
                        Console.WriteLine("end");
                        break;
                    }
                    // for(int i = 0; i < line.Length; i++)
                    string number = "";
                    int counter = 0;
                    foreach (var character in line)
                    {
                        if (character != ' '){
                            number += character;
                        }
                        else{
                            posloupnost.Add(int.Parse(number));
                            number = "";
                        }
                        counter++;
                    }
                    posloupnost.Add(int.Parse(number));

                    if (posloupnost.Count < 3)
                    {
                        Console.WriteLine($"Sequence {sequence_counter} is not long enough");
                        posloupnost = new List<int>(5);
                        sequence_counter++;
                        continue;
                    }

                    int lastnum = 0;
                    bool breakHappened = false;
                    foreach (var num in posloupnost)
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


                    for (int i = 0; i <= posloupnost.Count; i++)
                    {
                        if (true)
                        {
                                
                        }
                    }


                    posloupnost = new List<int>(5);
                    sequence_counter++;
                }
            }

            Console.ReadKey();
        }
    }
}
