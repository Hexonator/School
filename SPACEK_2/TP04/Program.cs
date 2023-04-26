// See https://aka.ms/new-console-template for more information

int input, zeroes, negative, positive, count;

zeroes = 0;
positive = 0;
negative = 0;
input = 0;
count = 1;


do
{
    Console.Write($"Cislo {count} = ");
    input = int.Parse(Console.ReadLine());
    if (input == 1000)
    {
        Console.WriteLine("---------------------");
    }
    else if (input > 100 || input < -100 && input != 1000)
    {
        Console.WriteLine("Cislo neni v intervalu <-100,100>");
    }
    else if (input == 0)
    {
        zeroes++;
    }
    else if (input < 0)
    {
        negative++;
    }
    else
    {
        positive++;
    }
    count++;
} while (input != 1000);

Console.WriteLine($"Počet záporných - {negative}");
Console.WriteLine($"Počet kladných - {positive}");
Console.WriteLine($"Počet nul - {zeroes}");
Console.ReadKey();
