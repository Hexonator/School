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
        public Square(int posX, int posY, int size) : base(posX, posY)
        {
            this.size = size;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black), posX, posY, size, size);
        }
    }
}
