using System.Numerics;

namespace _18_gaussova_eliminacni_metoda;

class Program
{
    static double EPS = 0.000001;

    static double[,] GetMatrix(string filename){
        double[,] matrix;
        using (StreamReader sr = new(filename)){
            int num_of_x = int.Parse(sr.ReadLine());
            matrix = new double[num_of_x+1, num_of_x];
            int x = 0;
            int y = 0;
            string value = "";
            string line = "";
            for (int i = 0; i < num_of_x; i++)
            {
                line = sr.ReadLine();
                string[] nums = line.Split(" ");
                foreach (string num in nums)
                {
                    matrix[x, y] = double.Parse(num);
                    x++;
                }
                x = 0;
                y++;
            }
            
        }
        return matrix;
    }
    static void Main(string[] args)
    {
        double[,] matrix = GetMatrix("matrix_1.txt");
        Console.ReadKey();
    }
}
