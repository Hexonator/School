using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Threading;
using System.Text;

namespace _07_Bludiste;

class Program
{
    static dynamic ConvertData(string filename){
        List<List<string>> maze = new();
        int width = -1;
        int height = -1;
        int startX = -1;
        int startY = -1;
        int endX = -1;
        int endY = -1;

        using (StreamReader sr = new(filename)){
            string first_line = sr.ReadLine();
            string[] parts = first_line.Split(' ');
            height = int.Parse(parts[0]);
            width = int.Parse(parts[1]);

            string data = sr.ReadToEnd();
            int y = 0;
            int x = 0;
            maze.Add(new List<string> {});
            foreach (char block in data){
                if (block == 'S')
                {
                    startX = x;
                    startY = y;
                }
                else if (block == 'C'){
                    endX = x;
                    endY = y;
                }
                if (block == '\n')
                {
                    continue;
                }
                else if (block == '\r'){
                    maze.Add(new List<string> {});
                    y++;
                    x = 0;
                }
                else{
                    maze[y].Add(block.ToString());
                    x++;
                }
            }
        }
        dynamic exp = new ExpandoObject();
            exp.maze = maze;
            exp.startX = startX;
            exp.startY = startY;
            exp.endX = endX;
            exp.endY = endY;
            exp.width = width;
            exp.height = height;

        return exp;
    }
    
    static dynamic GetMaze(string filename){
        dynamic exp = ConvertData(filename);
        int startX = exp.startX;
        int startY = exp.startY;
        int endX = exp.endX;
        int endY = exp.endY;
        int width = exp.width;
        int height = exp.height;

        if (width == -1 || height == -1)
        {
            Console.WriteLine("No height or width found");
            exp.success = false;
            return exp;
        }
        else if (startX == -1 || startY == -1)
        {
            Console.WriteLine("No start found");
            exp.success = false;
            return exp;
        }
        else if (endX == -1 || endY == -1)
        {
            Console.WriteLine("No end found");
            exp.success = false;
            return exp;
        }

        exp.success = true;
        return exp;
    }

    static void SolveMazeRecursively(string filename, int debugLevel = 0){

        dynamic exp = GetMaze(filename);
        List<List<string>> maze = exp.maze;
        int startX = exp.startX;
        int startY = exp.startY;
        int width = exp.width;
        int height = exp.height;

        // Draw initial maze
        DrawMaze(maze, width, height, true);

        List<int[]> solution_path = new();

        //Create stopwatch to time results
        Stopwatch solve_time = new();
        solve_time.Start();
        Solve(maze, startX, startY, width, height, solution_path, debugLevel);
        solve_time.Stop();
        string precise_miliseconds = solve_time.Elapsed.TotalMilliseconds + "ms";
        if (solution_path.Count > 0){
            DrawMaze(maze, width, height);
            FillMazeSolution(maze, solution_path);
            Console.WriteLine($"Time elapsed: " + precise_miliseconds);
            Console.ReadKey();
        }
        else{
            Console.WriteLine("No solution found");
            Console.WriteLine($"Time elapsed: " + precise_miliseconds);
            Console.ReadKey();
        }
    }

    static bool Solve(List<List<string>> maze,
                      int x, int y,
                      int width, int height,
                      List<int[]> solution_path,
                      int debugLevel){
        if (maze[y][x] == "C")
        {
            return true;
        }
        maze[y][x] = "X";

        if (debugLevel == 1)
        {
            DrawMaze(maze, width, height);
        }
        else if (debugLevel > 1)
        {
            DrawMaze(maze, width, height, true);
        }
        
        // Right
        if (CheckXY(maze, x+1, y, width, height))
        {
            if (Solve(maze, x+1, y, width, height, solution_path, debugLevel))
            {
                if (maze[y][x+1] != "C")
                {
                    solution_path.Add(new int[2] {x+1, y});
                }
                return true;
            }
        }
        // Bottom
        if (CheckXY(maze, x, y+1, width, height))
        {
            if (Solve(maze, x, y+1, width, height, solution_path, debugLevel))
            {
                if (maze[y+1][x] != "C")
                {
                    solution_path.Add(new int[2] {x, y+1});
                }
                return true;
            }
        }
        // Left
        if (CheckXY(maze, x-1, y, width, height))
        {
            if (Solve(maze, x-1, y, width, height, solution_path, debugLevel))
            {
                if (maze[y][x-1] != "C")
                {
                    solution_path.Add(new int[2] {x-1, y});
                }
                return true;
            }
        }
        // Top
        if (CheckXY(maze, x, y-1, width, height))
        {
            if (Solve(maze, x, y-1, width, height, solution_path, debugLevel))
            {
                if (maze[y-1][x] != "C")
                {
                    solution_path.Add(new int[2] {x, y-1});
                }
                return true;
            }
        }

        return false;
    }

    static bool CheckXY(List<List<string>> maze,
                        int x, int y,
                        int width, int height){

        if (x >= 0 && x < width && y >= 0 && y < height)
        {
            if (maze[y][x] == "." || maze[y][x] == "C")
            {
                return true;
            }
        }
        return false;
    }

    static List<List<string>> CopyMaze(List<List<string>> maze)
    {
        List<List<string>> copy = new();
        foreach (var row in maze)
        {
            List<string> newRow = new(row);
            copy.Add(newRow);
        }
        return copy;
    }

    static void FillMazeSolution(List<List<string>> maze,
                                 List<int[]> solution_path){
        int x,y;
        foreach (int[] coord in solution_path)
        {
            x = coord[0];
            y = coord[1];
            maze[y][x] = "X";
        }
        Console.WriteLine($"Maze succesfully solved with path length {solution_path.Count}");
    }

    static void DrawMaze(List<List<string>> maze, int width, int height, bool stopAfter = false, int longest_string = 1){
        StringBuilder buffer = new StringBuilder();

        for (int y = 0; y < height; y++)
        {
            foreach (string block in maze[y])
            {
                buffer.Append(block + " ");
            }
            buffer.AppendLine();
        }

        Console.Clear();
        Console.Write(buffer.ToString());

        if (stopAfter)
        {
            Console.ReadKey();
        }
        else{
            Thread.Sleep(10);
        }
    }

    static void SolveMazeBreadthFirst(string filename, int debugLevel = 0){
        List<int[]> queue = new();

    }

    static void Main(string[] args)
    {
        for (int i = 1; i <= 6; i++)
        {
            SolveMazeRecursively("Zadani/bludiste"+ i +".txt", 1);
        }

        for (int i = 1; i <= 6; i++)
        {
            SolveMazeBreadthFirst("Zadani/bludiste"+ i +".txt");
        }
        Console.ReadKey();
    }
}
