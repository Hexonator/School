using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06
{
    internal class Program
    {
        static void VypisPole(int[] pole)
        {
            foreach (var i in pole)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void NaplnPole(int[] pole)
        {
            Random rand = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rand.Next(0, 9);
            }
        }

        static int PocetLichych(int[] pole)
        {
            int pocet_lichych = 0;
            foreach (int cislo in pole)
            {
                if (cislo%2 == 0)
                {
                    pocet_lichych++;
                }
            }
            return pocet_lichych;
        }

        static void UpravenePole(int[] arrray)
        {
            for (int i = 1; i < arrray.Length; i+=2)
            {
                arrray[i] = 0;
            }
        }

        static void NaplnRuznymi(int[] pole)
        {
            if (pole.Length != 10)
            {
                return;
            }

            int[] pouzite_nahodne_cisla = new int[10];
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = 0;
                pouzite_nahodne_cisla[i] = -1;
            }

            Random rand = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                bool nebylo_pouzite = true;
                while (pole[i] == 0)
                {
                    int nahodne_cislo = rand.Next(0, 20);
                    foreach (int cislo in pouzite_nahodne_cisla)
                    {
                        if (cislo == nahodne_cislo)
                        {
                            nebylo_pouzite = false;
                        }
                    }
                    if (nebylo_pouzite)
                    {
                        pouzite_nahodne_cisla[i] = nahodne_cislo;
                        pole[i] = nahodne_cislo;
                    }
                    nebylo_pouzite = true;
                }
            }
        }

        static bool JeSestupne(int[] pole)
        {
            int index = 0;
            for (int i = pole.First(); i >= pole.First() - pole.Length+1; i--)
            {
                if (pole[index] != i)
                {
                    return false;
                }
                index++;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] pole = new int[10];
            NaplnPole(pole);
            VypisPole(pole);
            Console.WriteLine(PocetLichych(pole));
            UpravenePole(pole);
            VypisPole(pole);
            NaplnRuznymi(pole);
            VypisPole(pole);

            //int sestupne_cislo = 20;
            //for (int i = 0; i < 10; i++)
            //{
            //    pole[i] = sestupne_cislo;
            //    sestupne_cislo--;
            //}
            if (JeSestupne(pole))
            {
                Console.WriteLine("Pole je sestupně seřazené");
            }
            else
            {
                Console.WriteLine("Pole není sestupně seřazené");
            }


            Console.ReadKey();
        }
    }
}
