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
        private bool isSelected;

        public bool IsSelected { get => isSelected; set => isSelected = value; }

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
            return false;
        }

        // TODO: add a pen for drawing?
    }
}
