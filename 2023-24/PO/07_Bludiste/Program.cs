using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Threading;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;

namespace _07_Bludiste;

class Program
{
    static List<List<string>> maze_data = new();

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
        DrawMaze(maze, true, true);

        List<int[]> solution_path = new();

        Stopwatch solve_time = new();
        solve_time.Start();
        Solve(maze, startX, startY, width, height, solution_path, debugLevel);
        maze[startY][startX] = "S";
        solve_time.Stop();
        string precise_miliseconds = solve_time.Elapsed.TotalMilliseconds + "ms";
        if (solution_path.Count > 0){
            FillMazeSolution(maze, solution_path);
            DrawMaze(maze);
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
        maze[y][x] = "+";

        if (debugLevel == 0){
        }
        else if (debugLevel == 1){
            DrawMaze(maze);
        }
        else if (debugLevel == 2){
            DrawMaze(maze, waitMsAfter: 10);
        }
        else{
            DrawMaze(maze, true);
        }
        
        // Right
        if (CheckAvailability(maze, x+1, y, width, height))
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
        if (CheckAvailability(maze, x, y+1, width, height))
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
        if (CheckAvailability(maze, x-1, y, width, height))
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
        if (CheckAvailability(maze, x, y-1, width, height))
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

    static bool CheckAvailability(List<List<string>> maze,
                        int x, int y,
                        int width, int height,
                        bool lastBreadthFirstCheck = false){

        if (x >= 0 && x < width && y >= 0 && y < height)
        {
            if (lastBreadthFirstCheck){
                if (int.TryParse(maze[y][x], out _) || maze[y][x] == "S")
                {
                    return true;
                }
            }
            else{
                if (maze[y][x] == "." || maze[y][x] == "C")
                {
                    return true;
                }
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

    static void DrawMaze(List<List<string>> maze,
                         bool stopAfter = false,
                         bool deleteAfter = true,
                         int waitMsAfter = 0){

        (int width, int height) = (maze[0].Count, maze.Count);
        bool doUpdate = false; // lets func know wheteher to print everything new
        if (maze_data.Count == 0){
            doUpdate = true;
        }
        else{
            (int data_width, int data_height) = (maze_data[0].Count, maze_data.Count);
            if (data_height != height && data_width != width)
            {
                doUpdate = true;
            }
        }
        int x = 0;
        int y = 0;
        (int _, int orY) = Console.GetCursorPosition();
        if (orY < height){
            doUpdate = true;
        }
        StringBuilder buffer = new StringBuilder();
        foreach (List<string> line in maze)
        {
            foreach (string item in line)
            {
                // Draws the maze fresh into the txt and into console
                if (doUpdate){
                    if (char.IsDigit(item[0])){
                        buffer.Append('+');
                    }
                    else{
                        buffer.Append(item);
                    }
                // Changes specific characters in the console to make it faster
                } else {
                    bool itemIsNumber = char.IsDigit(item[0]);
                    if (itemIsNumber && item != maze_data[y][x]){
                        Console.SetCursorPosition(x+1, y);
                        Console.Write('\b');
                        Console.Write('+');
                        if(doUpdate)
                            buffer.Append('+');
                    }
                    else if (itemIsNumber && item == maze_data[y][x]){
                        if(doUpdate)
                            buffer.Append('+');
                    }
                    else if (item != maze_data[y][x]){
                        Console.SetCursorPosition(x+1, y);
                        Console.Write('\b');
                        Console.Write(item);
                        if(doUpdate)
                            buffer.Append(item);
                    }
                    else {
                        if(doUpdate)
                            buffer.Append(item);
                    }
                }
                x++;
            }
            buffer.AppendLine();
            y++;
            x = 0;
        }

        if (doUpdate){
            if(deleteAfter){
                Console.Clear();
            }
            Console.WriteLine(buffer.ToString());
        }
        else {
            Console.SetCursorPosition(0, y+1);
        }

        maze_data = CopyMaze(maze);

        if (waitMsAfter > 0){
            Thread.Sleep(waitMsAfter);
        }

        if (stopAfter)
        {
            Console.ReadKey();
        }
    }
    
    static void SolveMazeBreadthFirst(string filename, int debugLevel = 0){
        Stopwatch solve_time = new();
        Queue<int[]> queue = new();
        dynamic exp = GetMaze(filename);
        List<List<string>> maze = exp.maze;
        DrawMaze(maze, true, true);
        solve_time.Start();
        int startX = exp.startX;
        int startY = exp.startY;
        int endX = exp.endX;
        int endY = exp.endY;
        int width = exp.width;
        int height = exp.height;
        int x = startX;
        int y = startY;
        bool is_solvable;
        int[] coord;
        while (true)
        {
            if (x == endX && y == endY){
                is_solvable = true;
                break;
            }

            foreach (int[] direction_coord in GetDirections(maze, x, y, width, height))
            {
                bool hasReturned = false;
                foreach (int[] item in queue)
                {
                    if (item[0] == direction_coord[0] && item[1] == direction_coord[1]){
                        hasReturned = true;
                        break;
                    }
                }
                if(hasReturned){
                    continue;
                }
                queue.Enqueue(direction_coord);
            }

            if (queue.Count == 0 && x != startX && y != startY){
                is_solvable = false;
                break;
            }

            coord = queue.Dequeue();
            x = coord[0];
            y = coord[1];
            maze[y][x] = coord[2].ToString();

            if (debugLevel == 0){
            }
            else if (debugLevel == 1){
                DrawMaze(maze);
            }
            else if (debugLevel == 2){
                DrawMaze(maze, waitMsAfter: 10);
            }
            else{
                DrawMaze(maze, true);
            }
        }
        solve_time.Stop();
        string precise_miliseconds = solve_time.Elapsed.TotalMilliseconds + "ms";
        string path_length = maze[endY][endX];
        if (is_solvable){
            BacktrackToStart(maze, endX, endY, startX, startY, width, height, debugLevel);   
            DrawMaze(maze);
            Console.WriteLine("Maze solution found with path length " + path_length);
            Console.WriteLine($"Time elapsed: " + precise_miliseconds);
            Console.ReadKey();
        }
        else{
            DrawMaze(maze);
            Console.WriteLine("No solution found");
            Console.WriteLine($"Time elapsed: " + precise_miliseconds);
            Console.ReadKey();
        }
    }

    static List<int[]> GetDirections(List<List<string>> maze, 
                                     int x, int y,
                                     int width, int height){
        
        List<int[]> dirs = new(4);
        string origin = maze[y][x];
        int depth = 0;
        if (origin != "S"){
            depth = int.Parse(origin);
        }
        // Right
        if (CheckAvailability(maze, x+1, y, width, height))
        {
            dirs.Add(new int[3] {x+1, y, depth+1});
        }
        // Bottom
        if (CheckAvailability(maze, x, y+1, width, height))
        {
            dirs.Add(new int[3] {x, y+1, depth+1});
        }
        // Left
        if (CheckAvailability(maze, x-1, y, width, height))
        {
            dirs.Add(new int[3] {x-1, y, depth+1});
        }
        // Top
        if (CheckAvailability(maze, x, y-1, width, height))
        {
            dirs.Add(new int[3] {x, y-1, depth+1});
        }
        return dirs;
    }

    static void BacktrackToStart(List<List<string>> maze, int endX, int endY,
                                 int startX, int startY,
                                 int width, int height,
                                 int debugLevel){
        int depth = int.Parse(maze[endY][endX]);
        int x = endX;
        int y = endY;
        int[] coord = new int[2] {x, y};
        int[] bad_coord = new int[2] {-1, -1};

        while (depth > 0)
        {
            x = coord[0];
            y = coord[1];
            maze[y][x] = "X";

            if (debugLevel == 0){
            }
            else if (debugLevel == 1){
                DrawMaze(maze);
            }
            else if (debugLevel == 2){
                DrawMaze(maze, waitMsAfter: 10);
            }
            else{
                DrawMaze(maze, true);
            }
            coord = GetLowestDepthCoords(maze, depth, x, y, width, height);
            depth--;
            if (coord == bad_coord)
            {
                throw new Exception("Something went really wrong");
            }
        }
        maze[endY][endX] = "C";
        maze[startY][startX] = "S";
    }

    static int[] GetLowestDepthCoords(List<List<string>> maze, int depth,
                                      int x, int y,
                                      int width, int height){

        // Top
        if (CheckAvailability(maze, x, y-1, width, height, true))
        {
            if (maze[y-1][x] == "S"){
                return new int[2] {x, y-1};
            }
            else if (int.Parse(maze[y-1][x]) == depth-1){
                return new int[2] {x, y-1};
            }
        }
        // Left
        if (CheckAvailability(maze, x-1, y, width, height, true))
        {   
            if (maze[y][x-1] == "S"){
                return new int[2] {x-1, y};
            }
            else if (int.Parse(maze[y][x-1]) == depth-1){
                return new int[2] {x-1, y};
            }
        }
        // Bottom
        if (CheckAvailability(maze, x, y+1, width, height, true))
        {   
            if (maze[y+1][x] == "S"){
                return new int[2] {x, y+1};
            }
            else if (int.Parse(maze[y+1][x]) == depth-1){
                return new int[2] {x, y+1};
            }
        }
        // Right
        if (CheckAvailability(maze, x+1, y, width, height, true))
        {   
            if (maze[y][x+1] == "S"){
                return new int[2] {x+1, y};
            }
            else if (int.Parse(maze[y][x+1]) == depth-1){
                return new int[2] {x+1, y};
            }
        }
        // shouldn't happen
        DrawMaze(maze);
        Console.WriteLine("Something went wrong");
        Console.ReadKey();
        return new int[2] {-1, -1};
    }

    static void Main(string[] args)
    {
        bool solveRecursion = true;
        bool solveBreadthFirst = true;
        // debugLevel guide:
        //  0: fastest solution possible, prints only empty maze and solution
        //  1: draws every state without waiting, usually not much slower than 0
        //  2: draws every state and waits 10ms to make it more apparent what the function is doing
        //  2+: waits after every print to console
        int debugLevel = 2;
        if (solveRecursion){
            for (int i = 1; i <= 6; i++)
            {
                SolveMazeRecursively("Zadani/bludiste"+ i +".txt", debugLevel);
            }
        }

        if (solveBreadthFirst){
            for (int i = 1; i <= 6; i++)
            {
                SolveMazeBreadthFirst("Zadani/bludiste"+ i +".txt", debugLevel);
            }
        }
        Console.ReadKey();
    }
}
