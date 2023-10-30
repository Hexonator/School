using System;

namespace _5_ShapeDrawer
{
    internal class Text : Shape
    {
        protected int size;
        protected string text;
        protected Color text_color;
        public Text(int posX, int posY, int size, string text, Color text_color) : base(posX, posY)
        {
            this.size = size;
            this.text = text;
            this.text_color = text_color;
        }

        public override void Draw(Graphics g)
        {
            Font textFont = new("Arial", size);
            SolidBrush textBrush = new(text_color);
            g.DrawString(text, textFont, textBrush, posX, posY);
        }
    }
}