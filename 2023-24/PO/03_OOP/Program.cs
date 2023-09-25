using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Linq.Expressions;

namespace _03_OOP;

class Kruh
{
    
    private int polomer;

    public Kruh()
    {
        polomer = 0;
    }

    public Kruh(int polomerInit)
    {
        polomer = polomerInit;
    }

    public double Plocha()
    {
        return Math.PI * polomer * polomer;
    }
}

class Trojuhelnik
{
    private int a, b, c;

    public Trojuhelnik(int a_input, int b_input, int c_input)
    {
        a = a_input;
        b = b_input;
        c = c_input;
    }

    public double Obsah()
    {
        int s = a + b + c;
        double S = s*(s-a)*(s-b)*(s-c);
        return Math.Sqrt(S);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kruh k = new(3);

        double plocha = k.Plocha();
        Console.WriteLine(plocha);

        Trojuhelnik m = new(10, 20, 30);
        double obsah = m.Obsah();
        Console.WriteLine(obsah);
    }
}
