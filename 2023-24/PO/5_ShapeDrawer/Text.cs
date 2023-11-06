using System;

namespace _5_ShapeDrawer
{
    internal class Text : Shape
    {
        protected int size;
        protected string text;
        protected Color text_color;
        protected Font textFont;

        public Text(int posX, int posY, int size, string text, Color text_color) : base(posX, posY)
        {
            this.size = size;
            this.text = text;
            this.text_color = text_color;
            this.textFont = new("Arial", size);
        }

        public override void Draw(Graphics g)
        {
            SolidBrush textBrush = new(text_color);
            g.DrawString(text, textFont, textBrush, posX, posY);
        }

        public override bool CheckCoords(int x, int y)
        {
            Size stringSize = TextRenderer.MeasureText(text, textFont);
            float width = stringSize.Width;
            float height = stringSize.Height;

            if (x > posX && y > posY && x < posX + width && y < posY + height)
            {
                return true;
            }
            return false;
        }
    }
}