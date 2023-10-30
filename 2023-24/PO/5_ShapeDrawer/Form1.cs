namespace _5_ShapeDrawer
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes_list = new() { };
        public Form1()
        {
            InitializeComponent();
        }

        //-------- My functions---------

        private bool ObjectIsOnCoords(int x, int y)
        {
            for (int i = 0; i < shapes_list.Count; i++)
            {
                Shape shape = shapes_list[i];
                if (shape.CheckCoords(x, y)) // TODO: implement returning index of object
                {
                    return true;
                }
            }
            return false;
        }

        //-------- My functions end-----

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
            if (RadioButtonSelect.Checked)
            {
                if (ObjectIsOnCoords(e.X, e.Y))
                {
                    // TODO implement accepting  of index
                }
            }
            else
            {
                int size = (int)UpDownSize.Value;
                int x = e.X - size / 2;
                int y = e.Y - size / 2;
                Color shape_color;
                switch (ColorComboBox.Text)
                {
                    case "Green":
                        shape_color = Color.Green; break;
                    case "Red":
                        shape_color = Color.Red; break;
                    case "Blue":
                        shape_color = Color.Blue; break;
                    case "Black":
                        shape_color = Color.Black; break;
                    case "White":
                        shape_color = Color.White; break;
                    default:
                        shape_color = Color.Black; break;
                }
                if (RadioButtonSquare.Checked)
                {
                    shapes_list.Add(new Square(x, y, size, shape_color));
                }
                else if (RadioButtonCircle.Checked)
                {
                    shapes_list.Add(new Circle(x, y, size, shape_color));
                }
                else if (RadioButtonText.Checked)
                {
                    shapes_list.Add(new Text(x, y, size, TextInputBox.Text, shape_color));
                }
            }

            Refresh();
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            shapes_list.Clear();
            Refresh();
        }

        private void RadioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            UpDownSize.Value = 100;
        }

        private void RadioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            UpDownSize.Value = 100;
        }

        private void RadioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            UpDownSize.Value = 30;
        }
    }
}