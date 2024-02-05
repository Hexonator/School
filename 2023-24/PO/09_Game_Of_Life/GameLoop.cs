using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace _09_Game_Of_Life
{
    internal class GameLoop
    {
        public int width, height, increment;
        public bool[,] gamestate;
        public double percent_alive;
        public double old_perc, older_perc; // For stability evaluation
        public int num_of_cells;

        public GameLoop(int increment, int width, int height, bool gridVisible = false) {
            this.increment = increment;
            this.width = width;
            this.height = height;
            this.gamestate = new bool[width, height];
        }

        public void UpdateGameState(int x, int y)
        {
            x /= increment;
            y /= increment;
            if (x < width && y < height)
            {
                gamestate[x, y] = !gamestate[x, y];
                num_of_cells = width * height;
            }
            else
            {
                return;
            }
        }

        public void NextGeneration()
        {
            List<(int, int)> changes = new(); // list of changes that occur in a single gen
            num_of_cells = width * height;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (determineLife(x, y))
                    {
                        changes.Add((x, y));
                    }
                }
            }
            // apply changes after simulation
            foreach (var change in changes)
            {
                int x = change.Item1;
                int y = change.Item2;
                gamestate[x, y] = !gamestate[x, y];
            }

            int num_of_alive_cells = 0;
            foreach (var cell in gamestate)
            {
                if (cell)
                {
                    num_of_alive_cells++;
                }
            }
            older_perc = old_perc;
            old_perc = percent_alive;
            percent_alive = (double)num_of_alive_cells / num_of_cells * 100;
        }

        // Detects if a cell will change states or not
        private bool determineLife(int x, int y)
        {
            (int, int)[] directions = new (int, int)[8] { (1, 0), (0, 1), (-1, 0), (0, -1),
                                                           (1, 1), (-1, -1), (-1, 1), (1, -1)};
            int neigbhors = 0;
            bool cell = gamestate[x, y];
            foreach (var direction in directions)
            {
                int dirX = direction.Item1 + x;
                int dirY = direction.Item2 + y;
                if(dirX < 0 || dirY < 0 || dirX >= width || dirY >= height)
                {
                    continue;
                }
                if (gamestate[dirX, dirY])
                {
                    neigbhors++;
                }
            }
            // If there's less than two neighbors, the cell dies
            if (neigbhors < 2)
            {
                cell = false;
            }
            // If there's a live cell and it has 2 or 3 neighbors, the cell lives
            else if (cell && (neigbhors == 2 || neigbhors == 3))
            {
                cell = true;
            }
            // If there's more than 4 neighbors around a cell, it dies
            else if(neigbhors >= 4)
            {
                cell = false;
            }
            // If there's a dead cell and it has exactly 3 neighbors, it becomes alive
            else if (!cell && neigbhors == 3)
            {
                cell = true;
            }
            // if cell has changed return true
            // can't change it directly, because fction breaks
            if (cell != gamestate[x, y])
            {
                return true;
            }
            return false;
        }

        public void ReplaceGameState(bool[,] new_gamestate, int width, int height)
        {
            this.width = width;
            this.height = height;
            gamestate = new_gamestate;
        }
    }
}
