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
        public bool HasLaunched = false;
        public int width, height, increment;
        public bool[,] gamestate;
        public Graphics g;

        public GameLoop(Graphics g, int increment, int width, int height, bool gridVisible = false) {
            this.increment = increment;
            this.width = width;
            this.height = height;
            this.gamestate = new bool[width, height];
            this.g = g;
            if (gridVisible){
                DrawGrid(g);
            }
        }

        private void DrawGrid(Graphics g)
        {
            int width = this.width * increment;
            int height = this.height * increment;
            Pen pen = new(Color.Black, 1);
            pen.DashPattern = new float[]{3, 3};
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
            g.Dispose();
            pen.Dispose();
        }

        public void UpdateSquares(int x, int y)
        {
            Graphics g = this.g;
            Pen pen = new(Color.Black, 1);
            // TODO: keeps throwing errors
            g.DrawRectangle(pen, x, y, increment, increment);
            g.Dispose();
        }

        public Tuple<int, int> SendClick(Point coords)
        {
            int x = coords.X;
            int y = coords.Y;
            UpdateSquares(x, y);
            return new Tuple<int, int>(x, y);
        }
    }
}
