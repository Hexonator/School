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
                using(StreamReader posloupnosti = new StreamReader(@"..\..\posloupnosti.txt", Encoding.UTF8))
                {
                    string line;
                    List<int> posloupnost = new List<int>(5);
                    while(true)
                    {
                        line = posloupnosti.ReadLine();
                        if (line == null)
                        {
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
                            }
                            counter++;
                        }

                        for (int i = 0; i <= posloupnost.Count; i++)
                        {
                            if (posloupnost[i+1] + posloupnost[i])
                            {
                                
                            }
                        }


                        posloupnost = new List<int>(5);
                    }
                }
        }
    }
}
