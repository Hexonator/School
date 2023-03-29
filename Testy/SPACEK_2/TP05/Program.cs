// See https://aka.ms/new-console-template for more information

int A, B, num, count;

Console.Write("A = ");
A = int.Parse(Console.ReadLine());
Console.Write("B = ");
B = int.Parse(Console.ReadLine());

if (A > B)
{
    int AB;
    AB = A;
    A = B;
    B = AB;
}

Console.WriteLine($"<{A},{B}>");

count = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Cislo {i+1} = ");
    num = int.Parse(Console.ReadLine());
    if (A <= num && num <= B)
    {
        count++;
    }

}

Console.WriteLine("---------------");
Console.WriteLine($"Čísel z intervalu je {count}");
Console.ReadKey();