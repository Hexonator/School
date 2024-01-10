using System.Windows.Forms;
using System.Threading.Tasks;

namespace _09_Game_Of_Life
{
    public partial class Form1 : Form
    {
        private GameLoop gl;
        private int fieldWidth, fieldHeight;
        private int increment = 15;
        private int clicX = -1; private int clYck = -1;
        private List<(int, int)> AliveCells = new();
        private int width, height;
        private bool endPressed = false;

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

            // Launch only at the beginning when the class needs to be initiated
            if (gl == null)
            {
                this.width = (int)Width_UpDown.Value;
                this.height = (int)Height_UpDown.Value;
                GameLoop gl = new(increment, width, height, true);
                this.gl = gl;
            }

            var gamestate = gl.gamestate;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bool isAlive = gamestate[x, y];
                    SolidBrush whiteBrush = new(Color.White);
                    SolidBrush blackBrush = new(Color.Black);
                    if (isAlive)
                    {
                        g.FillRectangle(blackBrush, x * increment, y * increment, increment, increment);
                    }
                }
            }

            Pen pen = new(Color.Black, 1);
            if (Grid_CheckBox.Checked)
            {
                int width = this.width * increment;
                int height = this.height * increment;
                pen.DashPattern = new float[] { 3, 3 };
                // Vertical lines
                for (int x = 0; x <= width; x += increment)
                {
                    Point p1 = new(x, 0);
                    Point p2 = new(x, height);
                    g.DrawLine(pen, p1, p2);
                }

                // Horizontal lines
                for (int y = 0; y <= height; y += increment)
                {
                    Point p1 = new(0, y);
                    Point p2 = new(width, y);
                    g.DrawLine(pen, p1, p2);
                }
            }
            else
            {
                g.DrawRectangle(pen, 0, 0, width * increment, height * increment);
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            endPressed = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => TimeLoop());
        }

        private void TimeLoop()
        {
            while (true)
            {
                gl.NextGeneration();
                Thread.Sleep((int)TimeStep_UpDown.Value);
                if (endPressed)
                {
                    endPressed = false;
                    break;
                }
                UpdateUIOnUIThread();
            }
        }

        // Because the while loop is running on another thread,
        // GameLoop.Refresh() needs to be run in a special function
        private void UpdateUIOnUIThread()
        {
            if (GameField.InvokeRequired)
            {
                GameField.Invoke(new MethodInvoker(delegate
                {
                    GameField.Refresh();
                }));
            }
            else
            {
                GameField.Refresh();
            }
        }

        private void StepClick(object sender, EventArgs e)
        {
            gl.NextGeneration();
            GameField.Refresh();
        }

        private void IncrementValueChange(object sender, EventArgs e)
        {
            this.increment = (int)Increment_UpDown.Value;
            if (gl != null)
            {
                gl.increment = (int)Increment_UpDown.Value;
            }
            GameField.Refresh();
        }

        private void GameField_Click(object sender, EventArgs e)
        {
            Point point = GameField.PointToClient(Cursor.Position);
            this.clicX = point.X - (point.X % increment);
            this.clYck = point.Y - (point.Y % increment);
            this.gl.UpdateGameState(clicX, clYck);
            DebugTextBox.AppendText($"\r\n ({clicX / increment}, {clYck / increment})");
            this.AliveCells.Add((clicX, clYck));
            GameField.Refresh();
        }

        private void Width_ValueChange(object sender, EventArgs e)
        {
            this.gl = null;
            GameField.Refresh();
        }

        private void Height_ValueChanged(object sender, EventArgs e)
        {
            this.gl = null;
            GameField.Refresh();
        }
    }
}