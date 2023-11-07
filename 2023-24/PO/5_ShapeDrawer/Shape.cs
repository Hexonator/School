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
        private int size;

        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public int Size { get => size; set => size = value; }

        public Shape(int posX, int posY, int size)
        {
            this.posX = posX;
            this.posY = posY;
            this.size = size;
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

        public virtual void ChangeSize(int new_size)
        { 
            size = new_size;
        }

        public virtual void ChangeString(string new_text) { }
        public virtual string GetString() { return ""; }

        // TODO: add a pen for drawing?
    }
}
