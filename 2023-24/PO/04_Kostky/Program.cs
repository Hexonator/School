namespace _04_Hody_Kostkou;

class Dice()
{
    int num_of_sides, dice_num;
    Random rand = new();
    public Dice()
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

    int[] throw_probabilities = new[num_of_sides * dice_num];

    public int ThrowDice()
    {
        int throw_sum = 0;
        for (int i = 0; i <= dice_num; i++)
        {
            throw_sum += rand.Next(0, num_of_sides);
        }
        return throw_sum;
    }

    public void WriteProbabilities()
    {
        int index = 3;
        foreach (var num in throw_probabilities)
        {
            Console.WriteLine($"sum {3} fell {num} times, which occured in {}% of cases"); #TODO add percent counter
            index++;
        }
    }
    #TODO make function that throws dice n times
}

class Program
{
    static void Main(string[] args)
    {
        Dice D6 = new();
        
    }
}
