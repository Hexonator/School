using System.ComponentModel;
using System.Diagnostics;

namespace _07_Bludiste;

class Program
{
    static dynamic ConvertData(string filename,
                               List<List<string>> maze){
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

            string data =  sr.ReadToEnd();
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
        dynamic expando = new ExpandoObject();  // TODO: make it work!
        start_coords = new int[2] {startX, startY};
        end_coords = new int[2] {endX, endY};
        width_height = new int[2] {width, height};
        return maze;
    }
    static void SolveMazeRecursively(string filename, int debugLevel = 0){

        List<List<string>> maze = new();

        int[] start_coords = new int[2];
        int[] end_coords = new int[2];
        int[] width_height = new int[2];
        ConvertData(filename, maze, start_coords, end_coords, width_height);
        int startX = start_coords[0];
        int startY = start_coords[1];
        int endX = end_coords[0];
        int endY = end_coords[1];
        int width = width_height[0];
        int height = width_height[1];

        if (width == -1 || height == -1)
        {
            Console.WriteLine("No height or width found");
            return;
        }
        else if (startX == -1 || startY == -1)
        {
            Console.WriteLine("No start found");
            return;
        }
        else if (endX == -1 || endY == -1)
        {
            Console.WriteLine("No end found");
            return;
        }

        string divider = "";
        for (int i = 0; i < width*2+10; i++)
        {
            divider += "-";
        }

        Console.WriteLine(divider);

        DrawMaze(maze, width, height);
        List<int[]> solution_path = new();
        List<List<string>> maze_copy = CopyMaze(maze);
        Solve(maze_copy, startX, startY, width, height, solution_path, debugLevel);
        if (solution_path.Count > 0){
            FillMazeSolution(maze, solution_path);
            DrawMaze(maze, width, height);
        }
        else{
            Console.WriteLine("No solution found");
        }
        Console.WriteLine(divider);
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

        if (debugLevel > 0)
        {
            DrawMaze(maze, width, height);
            Console.ReadKey();
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
    }

    static void DrawMaze(List<List<string>> maze, int width, int height, int longest_string = 1){
        Console.WriteLine();
        for (int y = 0; y < height; y++)
        {
            foreach (string block in maze[y])
            {
                Console.Write(block + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void SolveMazeBreadthFirst(string filename, int debugLevel = 0){

    }

    static void Main(string[] args)
    {
        for (int i = 1; i <= 6; i++)
        {
            SolveMazeRecursively("Zadani/bludiste"+ i +".txt");
        }

        // for (int i = 1; i <= 6; i++)
        // {
        //     SolveMazeRecursively("Zadani/bludiste"+ i +".txt");
        // }
        Console.ReadKey();
    }
}
