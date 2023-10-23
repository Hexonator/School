namespace _5_ShapeDrawer
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes_list = new() { };
        public Form1()
        {
            InitializeComponent();
        }

        private void PaintInWindow(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new(Color.Black, 2);

            foreach (Shape shape in shapes_list)
            {
                shape.Draw(g);
            }
        }

        private void ClickOnWindow(object sender, MouseEventArgs e)
        {
            int size = (int)UpDownSize.Value;
            int x = e.X - size/2;
            int y = e.Y - size/2;
            if (RadioButtonSquare.Checked)
            {
                shapes_list.Add(new Square(x, y, size));
            }
            else if (RadioButtonCircle.Checked)
            {
                shapes_list.Add(new Circle(x, y, size));
            }

            Refresh();
        }
    }
}