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
        public GameLoop(bool[,] GameState) {
            this.GameState = GameState;
        }

        public bool[,] GameState { get; }

        public void GetGraphics(Graphics g)
        {

        }

        public void DrawGrid(Graphics g, int fieldWidth, int fieldHeight)
        {
            int game_length, width, height = GameState.Length, game_x, game_y;
            Pen pen = new(Color.Black, 1);
            
            // Vertical lines
            for (int x = 0; x < fieldWidth; x++)
            {
                Point p1 = new(0, x);
                Point p2 = new(fieldHeight, x);
                g.DrawLine(pen, p1, p2);
            }

            // Horizontal lines
            for (int y = 0; y < fieldHeight; y++)
            {
                Point p1 = new(0, y);
                Point p2 = new(fieldWidth, y);
                g.DrawLine(pen, p1, p2);
            }
        }
    }
}
