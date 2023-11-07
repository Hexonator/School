using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _5_ShapeDrawer
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes_list = new() { };
        private int lastSelectedIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        //-------- My functions ---------

        private int ObjectIsOnCoords(int x, int y)
        {
            for (int i = 0; i < shapes_list.Count; i++)
            {
                Shape shape = shapes_list[i];
                if (shape.CheckCoords(x, y))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool isShapeSelected()
        {
            if (lastSelectedIndex != -1 && shapes_list[lastSelectedIndex].IsSelected == true)
            {
                return true;
            }
            return false;
        }

        private void changeShapeSize(int index, int size)
        {
            shapes_list[index].ChangeSize(size);
            Refresh();
        }

        private void uncheckAll()
        {
            if (isShapeSelected())
            {
                shapes_list[lastSelectedIndex].IsSelected = false;
                Refresh();
            }
        }

        //-------- My functions end -----

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
                // finds if object is on coords
                int foundObjectIndex = ObjectIsOnCoords(e.X, e.Y);
                // found = index; not found = -1
                if (foundObjectIndex != -1)
                {
                    if (lastSelectedIndex != foundObjectIndex && lastSelectedIndex != -1 && lastSelectedIndex < shapes_list.Count)
                    {
                        shapes_list[lastSelectedIndex].IsSelected = false;
                    }
                    shapes_list[foundObjectIndex].IsSelected = true;
                    UpDownSize.Value = shapes_list[foundObjectIndex].Size;
                    if (shapes_list[foundObjectIndex].GetType().Name == "Text")
                    {
                        TextInputBox.Text = shapes_list[foundObjectIndex].GetString();
                    }
                    lastSelectedIndex = foundObjectIndex;
                }
                else
                {
                    if (lastSelectedIndex != -1)
                    {
                        shapes_list[lastSelectedIndex].IsSelected = false;
                    }
                }
            }
            else
            {
                int size = (int)UpDownSize.Value;
                // x and y is set so the shape appears with the cursor in the middle and not the corner
                int x = e.X - size / 2;
                int y = e.Y - size / 2;
                Color shape_color = colorSelectButton.BackColor;

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
                    if (TextInputBox.Text.Length > 0)
                    {
                        shapes_list.Add(new Text(x, y, size, TextInputBox.Text, shape_color));
                        // TODO: make it so editing selected text changes it
                    }
                }
            }

            Refresh();
        }

        private void colorSelectButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorSelect = new();
            colorSelect.Color = colorSelectButton.BackColor;

            if (colorSelect.ShowDialog() == DialogResult.OK)
                colorSelectButton.BackColor = colorSelect.Color;
        }

        private void ButtonDeleteSelected_Click(object sender, EventArgs e)
        {
            if (isShapeSelected())
            {
                shapes_list.RemoveAt(lastSelectedIndex);
                Refresh();
            }
        }

        private void UpDownSize_ValueChanged(object sender, EventArgs e)
        {
            if (isShapeSelected())
            {
                changeShapeSize(lastSelectedIndex, (int)UpDownSize.Value);
            }
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            if (isShapeSelected())
            {
                shapes_list[lastSelectedIndex].IsSelected = false;
            }
            shapes_list.Clear();
            Refresh();
        }


        private void RadioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            uncheckAll();
            UpDownSize.Value = 100;
            TextInputBox.Text = "";
        }

        private void RadioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            uncheckAll();
            UpDownSize.Value = 100;
            TextInputBox.Text = "";
        }

        private void RadioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            uncheckAll();
            UpDownSize.Value = 30;
        }

        private void TextInputBox_TextChanged(object sender, EventArgs e)
        {
            if (isShapeSelected())
            {
                if (shapes_list[lastSelectedIndex].GetType().Name == "Text")
                {
                    shapes_list[lastSelectedIndex].ChangeString(TextInputBox.Text);
                }
                Refresh();
            }
        }

        private void RadioButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonSelect.Checked)
            {
                TextInputBox.Text = "";
            }
        }
    }
}