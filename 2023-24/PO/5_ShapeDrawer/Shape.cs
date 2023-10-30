using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ShapeDrawer
{
    internal class Shape
    {
        protected int posX, posY;

        public Shape(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public virtual void Draw(Graphics g)
        {
            Font drawFont = new("Arial", 16);
            SolidBrush drawBrush = new(Color.Black);
            g.DrawString("base", drawFont, drawBrush, posX, posY);
        }

        public virtual bool CheckCoords(int x, int y) 
        {
            return false; // implement function and mby add pen for drawing
        }
    }
}
