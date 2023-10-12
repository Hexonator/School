using System.Drawing;

namespace _12_graphDrawer
{
    public partial class Form1 : Form
    {
        static int increment = 10;
        static int step = 1;
        public List<Point> graph_points = new(400);
        public Point[] graph_points_to_draw;

        public Form1()
        {
            InitializeComponent();
        }

        public Point[] Evaluate(string input)
        {
            return new Point[10]; // arbitrary wrong value
        }
        public bool GetGraphPoints(string input)
        {
            int width = graphField.Width;
            int height = graphField.Height;
            Evaluate(input);
            for (int x = -width / 2; x < width / 2; x += step) // I'm scared that moving by step could cause it to not allign in the middle
            {
                double y = Math.Sin((double)x/80) * 140;
                graph_points.Add(new Point(x, (int)y));
            }
            graph_points_to_draw = G_CoordsToF_Coords(graph_points.ToArray());
            return true;
        }

        public void DrawGrid(Graphics g, Pen G_pen, int unitline_len, int div_unitline_len_add)
        {
            int width = graphField.Width;
            int height = graphField.Height;

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
                g.DrawLine(G_pen, G_CoordsToF_Coords(-unitline_len / 2, i * increment),
                    G_CoordsToF_Coords(unitline_len / 2, i * increment));
                g.DrawLine(G_pen, G_CoordsToF_Coords(-unitline_len / 2, -i * increment),
                    G_CoordsToF_Coords(unitline_len / 2, -i * increment));
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
                g.DrawLine(G_pen, G_CoordsToF_Coords(i * increment, -unitline_len / 2),
                    G_CoordsToF_Coords(i * increment, unitline_len / 2));
                g.DrawLine(G_pen, G_CoordsToF_Coords(-i * increment, -unitline_len / 2),
                    G_CoordsToF_Coords(-i * increment, unitline_len / 2));
                if (usedDivider)
                {
                    unitline_len -= div_unitline_len_add;
                    usedDivider = false;
                }
            }

        }

        public void graphField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen G_pen = new(Color.Black, 1);
            int unitline_len = 10;
            int div_unitline_len_add = 6;

            DrawGrid(g, G_pen, unitline_len, div_unitline_len_add);

            if (graph_points_to_draw != null && graph_points_to_draw.Length > 0)
            {
                g.DrawLines(G_pen, graph_points_to_draw.ToArray());
            }
        }

        public Point G_CoordsToF_Coords(int x, int y)
        {
            int width = graphField.Width;
            int height = graphField.Height;
            int newX = x + width / 2;
            int newY = height / 2 - y;
            return new Point(newX, newY);
        }
        public Point G_CoordsToF_Coords(Point point)
        {
            int width = graphField.Width;
            int height = graphField.Height;
            int newX = point.X + width / 2;
            int newY = height / 2 - point.Y;
            return new Point(newX, newY);
        }
        public Point[] G_CoordsToF_Coords(Point[] points)
        {
            Point[] newpoints = new Point[points.Length];
            int width = graphField.Width;
            int height = graphField.Height;
            for (int i = 0; i < points.Length; i++)
            {
                newpoints[i] = new Point(points[i].X + width / 2, height / 2 - points[i].Y);
            }
            return newpoints;
        }

        private void EntryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool pointSearchSuccess = GetGraphPoints(EntryBox.Text);
                if (pointSearchSuccess)
                {
                    graphField.Refresh();
                }
            }
        }
    }
}