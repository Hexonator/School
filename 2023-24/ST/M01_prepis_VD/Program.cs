namespace M01_prepis_VD;

class Program
{
    static float GetAvgInInterval(int[] array, int bottom, int top){
        float average = 0;
        int count = 0;
        foreach (int num in array)
        {
            if (num >= bottom && num <= top)
            {
                average += num;
                count++;
            }
        }
        if (count > 0){
            return average/count;
        } else {
            return -1;
        }

    }
    static void Main(string[] args)
    {
        int[] test_array = new int[10] {213, 87, 54, 0, 5, 70, -5, 437, 99, 1};
        float average = GetAvgInInterval(test_array, 0, 100);
        Console.WriteLine(average);

        Console.ReadKey();
    }
}
