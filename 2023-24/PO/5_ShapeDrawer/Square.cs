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
        protected Color text_color;

        public Square(int posX, int posY, int size, Color text_color) : base(posX, posY)
        {
            this.size = size;
            this.text_color = text_color;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(text_color), posX, posY, size, size);
        }
    }
}
