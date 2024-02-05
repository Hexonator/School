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
        private int zoom = 13;
        private int timeLoopSpeed;
        private int clicX = -1; private int clYck = -1;
        private List<(int, int)> AliveCells = new();
        private int width, height;
        private bool endRequested = false;
        private bool timeLoopRunning = false;
        private int genCount = 0;

        public Form1()
        {
            InitializeComponent();
            int width = 40;
            int height = 30;

            Width_UpDown.Value = width;
            Height_UpDown.Value = height;

            Increment_Slider.Value = zoom;
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
                GameLoop gl = new(zoom, width, height, true);
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
                        g.FillRectangle(whiteBrush, x * zoom, y * zoom, zoom, zoom);
                    }
                }
            }

            Pen pen = new(Color.White, 1);
            if (Grid_CheckBox.Checked)
            {
                int width = this.width * zoom;
                int height = this.height * zoom;
                pen.DashPattern = new float[] { 3, 3 };
                // Vertical lines
                for (int x = 0; x <= width; x += zoom)
                {
                    Point p1 = new(x, 0);
                    Point p2 = new(x, height);
                    g.DrawLine(pen, p1, p2);
                }

                // Horizontal lines
                for (int y = 0; y <= height; y += zoom)
                {
                    Point p1 = new(0, y);
                    Point p2 = new(width, y);
                    g.DrawLine(pen, p1, p2);
                }
            }
            else
            {
                g.DrawRectangle(pen, 0, 0, width * zoom, height * zoom);
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            endRequested = true;
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
            }
        }

        private void TimeLoop()
        {
            while (true)
            {
                gl.NextGeneration();
                Thread.Sleep(timeLoopSpeed);
                if (endRequested)
                {
                    endRequested = false;
                    timeLoopRunning = false;
                    genCount = 0;
                    break;
                }
                genCount++;
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
            if (PercentAlive_Label.InvokeRequired)
            {
                PercentAlive_Label.Invoke(new MethodInvoker(delegate
                {
                    if (gl.percent_alive.ToString().Length > 3)
                        PercentAlive_Label.Text = gl.percent_alive.ToString().Substring(0, 4) + "%";
                    else
                        PercentAlive_Label.Text = gl.percent_alive.ToString() + ".0%";
                }));
            }
            else
            {
                if (gl.percent_alive.ToString().Length > 3)
                    PercentAlive_Label.Text = gl.percent_alive.ToString().Substring(0, 4) + "%";
                else
                    PercentAlive_Label.Text = gl.percent_alive.ToString() + ".0%";
            }
            if (NumOfGenerations_Label.InvokeRequired)
            {
                NumOfGenerations_Label.Invoke(new MethodInvoker(delegate
                {
                    NumOfGenerations_Label.Text = genCount.ToString();
                }));
            }
            else
            {
                NumOfGenerations_Label.Text = genCount.ToString();
            }
            bool isStable = gl.older_perc == gl.percent_alive;
            if (IsStable_Label.InvokeRequired)
            {
                IsStable_Label.Invoke(new MethodInvoker(delegate
                {
                    IsStable_Label.Text = isStable ? "Stable" : "Unstable";
                }));
            }
            else
            {
                IsStable_Label.Text = isStable ? "Stable" : "Unstable";
            }
        }

        private void StepClick(object sender, EventArgs e)
        {
            endRequested = true;
            gl.NextGeneration();
            UpdateUIOnUIThread();
        }

        private void GameField_Click(object sender, EventArgs e)
        {
            Point point = GameField.PointToClient(Cursor.Position);
            this.clicX = point.X - (point.X % zoom);
            this.clYck = point.Y - (point.Y % zoom);
            this.gl.UpdateGameState(clicX, clYck);
            this.AliveCells.Add((clicX, clYck));
            GameField.Refresh();
        }

        private void Width_ValueChange(object sender, EventArgs e)
        {
            endRequested = true;
            this.gl = null;
            genCount = 0;
            GameField.Refresh();
        }

        private void Height_ValueChanged(object sender, EventArgs e)
        {
            endRequested = true;
            this.gl = null;
            genCount = 0;
            GameField.Refresh();
        }

        private void GridCheckChanged(object sender, EventArgs e)
        {
            GameField.Refresh();
        }

        private void Speed_Slider_ValueChanged(object sender, EventArgs e)
        {
            timeLoopSpeed = Speed_Slider.Value * 100;
            if (timeLoopSpeed > 1000)
            {
                SpeedLabel.Text = $"Speed: {(float)timeLoopSpeed / 1000}s";
            }
            else
            {
                SpeedLabel.Text = $"Speed: {timeLoopSpeed}ms";
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            endRequested = true;
            this.gl = null;
            genCount = 0;
            GameField.Refresh();
        }

        private void IncrementSliderValChange(object sender, EventArgs e)
        {
            this.zoom = Increment_Slider.Value + 5;
            if (gl != null)
            {
                gl.increment = Increment_Slider.Value + 5;
            }
            GameField.Refresh();
        }

        private Tuple<bool[,], int, int> readFile(string path)
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
                width = int.Parse(size.Substring(0, widthIndex));
                height = int.Parse(size.Substring(heightIndex));

                if (width == -1 || height == -1)
                {
                    return null;
                }
            }

            bool[,] new_gamestate = new bool[width, height];
            // Reading the gamestate
            for (int y = 0; y < height; y++)
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    continue;
                }
                try
                {
                    for (int x = 0; x < width; x++)
                    {
                        char cell = line[x];
                        new_gamestate[x, y] = cell == 'X';
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(
                    "Try swapping width and height in the txt provided",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return null;
                }
            }

            sr.Close();
            return new(new_gamestate, width, height);
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://www.youtube.com/watch?v=dQw4w9WgXcQ"}"));
        }

        private void LoadFile_Pressed(object sender, EventArgs e)
        {
            endRequested = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                bool[,] new_gamestate;
                int width, height;
                (new_gamestate, width, height) = readFile(filename);
                if (new_gamestate != null)
                {
                    this.gl.ReplaceGameState(new_gamestate, width, height);
                    this.width = width;
                    this.height = height;
                    GameField.Refresh();
                }
            }
        }

        private void RandomFill_Button_Click(object sender, EventArgs e)
        {
            int percentage = RandomFill_Slider.Value;
            bool[,] new_gamestate = new bool[width, height];
            Random rand = new Random();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    new_gamestate[x, y] = percentage >= rand.Next(100) ? true : false;
                }
            }
            this.gl.ReplaceGameState(new_gamestate, width, height);
            GameField.Refresh();
        }

        private void RandomFill_Slider_ValueChanged(object sender, EventArgs e)
        {
            RandomFill_Label.Text = "Random fill: " + RandomFill_Slider.Value.ToString() + "%";
        }
    }
}