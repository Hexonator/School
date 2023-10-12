using System.Runtime.CompilerServices;

namespace _12_graphDrawer
{
    public partial class Form1 : Form
    {
        int height, width;
        int increment = 10;
        public Form1()
        {
            InitializeComponent();
        }

        public List<int> TextProcessing(string input)
        {
            // x=0, sin=1, cos=2, tg=3, cotg=4
            // +=10, -=20, *=30, /=40

            return new List<int> { 0 };
        }

        public void DrawGrid(Graphics g, Pen G_pen, int width, int height, int unitline_len, int div_unitline_len_add)
        {
            // vertical
            g.DrawLine(G_pen, width / 2, 0, width / 2, height);

            bool usedDivider = false;
            for (int i = 0; i <= height / 2 / increment; i++)
            {
                if (i % 4 == 0)
                {
                    unitline_len += div_unitline_len_add;
                    usedDivider = true;
                }
                g.DrawLine(G_pen, G_CoordsToF_Coords(width, height, -unitline_len / 2, i * increment),
                    G_CoordsToF_Coords(width, height, unitline_len / 2, i * increment));
                g.DrawLine(G_pen, G_CoordsToF_Coords(width, height, -unitline_len / 2, -i * increment),
                    G_CoordsToF_Coords(width, height, unitline_len / 2, -i * increment));
                if (usedDivider)
                {
                    unitline_len -= div_unitline_len_add;
                    usedDivider = false;
                }
            }

            // horizontal
            g.DrawLine(G_pen, 0, height / 2, width, height / 2);

            usedDivider = false;
            for (int i = 0; i <= width / 2 / increment; i++)
            {
                if (i % 4 == 0)
                {
                    unitline_len += div_unitline_len_add;
                    usedDivider = true;
                }
                g.DrawLine(G_pen, G_CoordsToF_Coords(width, height, i * increment, -unitline_len / 2),
                    G_CoordsToF_Coords(width, height, i * increment, unitline_len / 2));
                g.DrawLine(G_pen, G_CoordsToF_Coords(width, height, -i * increment, -unitline_len / 2),
                    G_CoordsToF_Coords(width, height, -i * increment, unitline_len / 2));
                if (usedDivider)
                {
                    unitline_len -= div_unitline_len_add;
                    usedDivider = false;
                }
            }

        }

        private void graphField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen G_pen = new(Color.Black, 1);
            height = graphField.Height;
            width = graphField.Width;
            int unitline_len = 10;
            int div_unitline_len_add = 6;

            DrawGrid(g, G_pen, width, height, unitline_len, div_unitline_len_add);
        }
        static Point G_CoordsToF_Coords(int width, int height, int x, int y)
        {
            int newX = x + width / 2;
            int newY = y + height / 2;
            return new Point(newX, newY);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<int> text_result = TextProcessing(EntryBox.Text);
                if (text_result[0] == 1)
                {

                }
                else
                {
                    infoBox.Text = "Function entered is invalid";
                }
            }
        }

    }
}