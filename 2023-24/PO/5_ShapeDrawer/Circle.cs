using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _5_ShapeDrawer
{
    internal class Circle : Shape
    {
        protected int size;
        protected Color shape_color;

        public Circle(int posX, int posY, int size, Color shape_color) : base(posX, posY, size)
        {
            this.size = size;
            this.shape_color = shape_color;
        }

        public override void Draw(Graphics g)
        {
            if (IsSelected)
            {
                g.DrawEllipse(new Pen(shape_color, 5), posX, posY, size, size);
            }
            else
            {
                g.DrawEllipse(new Pen(shape_color), posX, posY, size, size);
            }
        }

        public override bool CheckCoords(int x, int y)
        {
            double radius = size / 2;
            double centerX = posX + radius;
            double centerY = posY + radius;
            double distance = Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY));
            if (distance < radius)
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
