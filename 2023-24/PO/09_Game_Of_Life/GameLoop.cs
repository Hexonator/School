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
        public GameLoop(bool[,] GameState, int increment) {
            this.GameState = GameState;
            this.increment = increment;
        }

        public bool[,] GameState { get; }
        public int increment { get; }

        public void GetGraphics(Graphics g)
        {

        }

        public void DrawGrid(Graphics g)
        {
            int width = GameState.GetLength(0) * increment;
            int height = GameState.GetLength(1) * increment;
            Pen pen = new(Color.Black, 1);
            
            // Vertical lines
            for (int x = 0; x <= width; x += increment)
            {
                Point p1 = new(x, 0);
                Point p2 = new(x, height);
                g.DrawLine(pen, p1, p2);
            }

            // Horizontal lines
            for (int y = 0; y <= height; y += increment)
            {
                Point p1 = new(0, y);
                Point p2 = new(width, y);
                g.DrawLine(pen, p1, p2);
            }
        }
    }
}
