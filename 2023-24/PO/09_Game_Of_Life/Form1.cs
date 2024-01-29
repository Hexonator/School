using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;

namespace _09_Game_Of_Life
{
    public partial class Form1 : Form
    {
        private GameLoop gl;
        private int increment = 13;
        private int timeLoopSpeed;
        private int clicX = -1; private int clYck = -1;
        private List<(int, int)> AliveCells = new();
        private int width, height;
        private bool endPressed = false;
        private bool timeLoopRunning = false;

        public Form1()
        {
            InitializeComponent();
            int width = 40;
            int height = 30;

            Width_UpDown.Value = width;
            Height_UpDown.Value = height;

            Increment_Slider.Value = increment;
            GameField.Refresh();

            timeLoopSpeed = Speed_Slider.Value * 100;
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
                    if (isAlive)
                    {
                        g.FillRectangle(whiteBrush, x * increment, y * increment, increment, increment);
                    }
                }
            }

            Pen pen = new(Color.White, 1);
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
            DebugTextBox.AppendText("Terminating time loop");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!timeLoopRunning)
            {
                timeLoopRunning = true;
                Task.Run(() => TimeLoop());
            }
            else
            {
                DebugTextBox.AppendText("Time loop already running\n");
            }
        }

        private void TimeLoop()
        {
            while (true)
            {
                gl.NextGeneration();
                Thread.Sleep(timeLoopSpeed);
                if (endPressed)
                {
                    endPressed = false;
                    timeLoopRunning = false;
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

        private void GameField_Click(object sender, EventArgs e)
        {
            Point point = GameField.PointToClient(Cursor.Position);
            this.clicX = point.X - (point.X % increment);
            this.clYck = point.Y - (point.Y % increment);
            this.gl.UpdateGameState(clicX, clYck);
            DebugTextBox.AppendText($"\r\n ({clicX / increment}, {clYck / increment})\n");
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

        private void GridCheckChanged(object sender, EventArgs e)
        {
            GameField.Refresh();
        }

        private void Speed_Slider_ValueChanged(object sender, EventArgs e)
        {
            timeLoopSpeed = Speed_Slider.Value * 100;
            DebugTextBox.AppendText($"Speed changed to {timeLoopSpeed}ms\n");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.gl = null;
            GameField.Refresh();
        }

        private void IncrementSliderValChange(object sender, EventArgs e)
        {
            this.increment = Increment_Slider.Value + 5;
            if (gl != null)
            {
                gl.increment = Increment_Slider.Value + 5;
            }
            GameField.Refresh();
        }

        private bool[,] readFile(string path)
        {
            int width = -1, height = -1;
            StreamReader sr = new(path, Encoding.UTF8);

            // Reading witdh and height
            string size = sr.ReadLine();
            if (size == null)
            {
                return null;
            }
            else
            {
                int widthIndex = 0;
                int heightIndex = 0;
                for (int i = 0; i < size.Length; i++)
                {
                    char character = size[i];
                    bool isNum = int.TryParse(character.ToString(), out _);
                    if (!isNum)
                    {
                        widthIndex = i;
                        heightIndex = i + 1;
                        break;
                    }
                }
                width = int.Parse(size.Substring(0, widthIndex - 1));
                height = int.Parse(size.Substring(heightIndex));

                if (width == -1 || height == -1)
                {
                    return null;
                }
            }

            // Reading the gamestate


            sr.Close();
            return null;
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://www.youtube.com/watch?v=dQw4w9WgXcQ"}"));
        }

        private void LoadFile(object sender, EventArgs e)
        {
            string filename = openFileDialog.FileName;
        }
    }
}