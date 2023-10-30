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
        protected Color text_color;

        public Circle(int posX, int posY, int radius, Color text_color) : base(posX, posY)
        {
            this.radius = radius;
            this.text_color = text_color;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(text_color), posX, posY, radius, radius);
        }
    }
}
