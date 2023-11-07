using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ShapeDrawer
{
    internal class Square : Shape
    {
        protected int size;
        protected Color shape_color;

        public Square(int posX, int posY, int size, Color shape_color) : base(posX, posY, size)
        {
            this.size = size;
            this.shape_color = shape_color;
        }

        public override void Draw(Graphics g)
        {
            if (IsSelected)
            {
                g.DrawRectangle(new Pen(shape_color, 5), posX, posY, size, size);
            }
            else
            {
                g.DrawRectangle(new Pen(shape_color), posX, posY, size, size);
            }
        }

        public override bool CheckCoords(int x, int y)
        {
            if (x > posX && y > posY && x < posX + size && y < posY + size)
            {
                return true;
            }
            return false;
        }

        public override void ChangeSize(int new_size)
        {
            this.size = new_size;
            this.Size = new_size;
        }
    }
}
