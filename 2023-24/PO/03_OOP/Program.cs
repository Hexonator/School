using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _03_OOP;

class Kruh
{
    int polomer;

    double Plocha()
    {
        return Math.PI * polomer * polomer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kruh k = new();
    }
}
