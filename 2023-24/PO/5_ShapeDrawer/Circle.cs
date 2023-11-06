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
        protected Color shape_color;

        public Circle(int posX, int posY, int radius, Color shape_color) : base(posX, posY)
        {
            this.radius = radius;
            this.shape_color = shape_color;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(shape_color), posX, posY, radius, radius);
        }
    }
}
