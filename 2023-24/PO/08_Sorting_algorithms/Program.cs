using System.Data.SqlTypes;
using System.Diagnostics;

namespace _08_Sorting_algorythms;

class Program
{
    static int array_length = 10000;
    static bool runSelectionSort = true;
    static bool runBubbleSort = true;
    static bool printResults = false;


    static int[] GenerateRandomArray(int array_length){
        Random rand = new();
        int[] random_array = new int[array_length];
        for (int i = 0; i < array_length; i++)
        {
            random_array[i] = rand.Next(100);
        }
        return random_array;
    }

    static bool IsSorted(int[] array, int array_length){
        for (int i = 1; i < array_length; i++)
        {
            if (array[i] < array[i-1])
            {
                return false;
            }
        }
        return true;
    }

    static void PrintArray(int[] array){
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] SelectionSort(int[] array, int array_length){
        for (int i = 0; i < array_length; i++)
        {
            int smallest_index = i;
            for (int j = i; j < array_length; j++)
            {
                if (array[j] < array[smallest_index])
                {
                    smallest_index = j;
                }
            }
            if (printResults)
            {
                PrintArray(array);
            }

            // switching of current and smallest index
            (array[smallest_index], array[i]) = (array[i], array[smallest_index]);
            if (IsSorted(array, array_length)){
                return array;
            }
        }
        return Array.Empty<int>();
    }

    static int[] BubbleSort(int[] array, int array_length){
        bool switchOccured = true;
        while (switchOccured)
        {
            switchOccured = false;

            for (int i = 1; i < array_length; i++)
            {
                if (array[i] < array[i-1])
                {
                    (array[i-1], array[i]) = (array[i], array[i-1]);
                    switchOccured = true;
                }
            }
        }
        return array;
    }
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(array_length);
        int[] sorted_array = new int[array_length];
        if (runSelectionSort)
        {
            Console.WriteLine("Selection sort started");
            Stopwatch selection_sort_time = new();
            selection_sort_time.Start();
            sorted_array = SelectionSort(array, array_length);
            selection_sort_time.Stop();
            Console.WriteLine(
                "Selection sort ran for " +
                $"{selection_sort_time.ElapsedMilliseconds}ms with an array with length {array_length}"
                            );
            if (IsSorted(sorted_array, array_length)){
                Console.WriteLine("Sorted!");
            }
            else{
                Console.WriteLine("Something isn't working");
            }
            Console.WriteLine();
        }
        if (runBubbleSort)
        {
            Console.WriteLine("Bubble sort started");
            Stopwatch bubble_sort_time = new();
            bubble_sort_time.Start();
            sorted_array = BubbleSort(array, array_length);
            bubble_sort_time.Stop();
            Console.WriteLine(
                "Bubble sort ran for " +
                $"{bubble_sort_time.ElapsedMilliseconds}ms with an array with length {array_length}"
                            );
            if (IsSorted(sorted_array, array_length)){
                Console.WriteLine("Sorted!");
            }
            else{
                Console.WriteLine("Something isn't working");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
