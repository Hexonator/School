using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ShapeDrawer
{
    internal class Circle : Shape
    {
        protected int radius;
        public Circle(int posX, int posY, int radius) : base(posX, posY)
        {
            this.radius = radius;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), posX, posY, radius, radius);
        }
    }
}
