using System.Windows.Forms;

namespace _09_Game_Of_Life
{
    public partial class Form1 : Form
    {
        private GameLoop gl;
        private int fieldWidth, fieldHeight;
        private int increment = 15;

        public Form1()
        {
            InitializeComponent();
            int width = 30;
            int height = 30;

            Width_UpDown.Value = width;
            Height_UpDown.Value = height;

            Increment_UpDown.Value = increment;
            fieldWidth = GameField.Width;
            fieldHeight = GameField.Height;
            GameField.Refresh();
        }

        private void DrawInPanel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = (int)Width_UpDown.Value;
            int height = (int)Height_UpDown.Value;
            GameLoop gl = new(g, increment, width, height, true);
            this.gl = gl;
            //gl.Launch(g);
        }

        private void StartClick(object sender, EventArgs e)
        {
            GameField.Refresh();
        }

        private void IncrementValueChange(object sender, EventArgs e)
        {
            increment = (int)Increment_UpDown.Value;
            GameField.Refresh();
        }

        private void GameField_Click(object sender, EventArgs e)
        {
            Point point = GameField.PointToClient(Cursor.Position);
            int x, y;
            (x, y) = this.gl.SendClick(point);
            DebugTextBox.AppendText($"\r\n ({x}, {y})");
        }
    }
}