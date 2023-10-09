using System.Data;

namespace _04_Hody_Kostkou;

class Dice
{
    int num_of_sides;
    int dice_num;
    int throw_amount;
    Random rand = new();
    int[] throw_probabilities = new int[10];
    public Dice()
    {
        if (!(num_of_sides > 0 && dice_num > 0))
        {
            while (true)
            {
                Console.WriteLine("Enter number of dice:");
                if (int.TryParse(Console.ReadLine(), out int dice_out))
                {
                    dice_num = dice_out;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number, try again.");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter number of sides per dice:");
                if (int.TryParse(Console.ReadLine(), out int sides_out))
                {
                    num_of_sides = sides_out;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number, try again.");
                }
            }
        }
        int[] throws = new int[num_of_sides * dice_num + 1];
        throw_probabilities = throws;
    }

    public int ThrowDice()
    {
        int throw_sum = 0;
        for (int i = 0; i < dice_num; i++)
        {
            throw_sum += rand.Next(1, num_of_sides + 1);
        }
        return throw_sum;
    }

    public void ThrowDiceNTimes(int dice_throws)
    {
        int index;
        for (int i = 0; i < dice_throws; i++)
        {
            index = ThrowDice();
            if (index > 18)
            {
                Console.WriteLine("what");
            }
            throw_probabilities[index] += 1;
        }
        throw_amount = dice_throws;
        WriteProbabilities();
    }

    public void WriteProbabilities()
    {
        int throw_sum = 0;
        double percentage;
        foreach (var count_of_throws in throw_probabilities)
        {
            if (count_of_throws == 0)
            {
                throw_sum++;
                continue;
            }
            percentage = (double)count_of_throws / throw_amount * 100;
            Console.WriteLine($"sum {throw_sum,-4} fell {count_of_throws,-8} times, which occurred in {Math.Round(percentage, 3),-8}% of cases");
            throw_sum++;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dice D6 = new();
        D6.ThrowDiceNTimes(1000000);
        Console.ReadKey();
    }
}
