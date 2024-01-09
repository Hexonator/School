namespace _09_Game_Of_Life
{
    public partial class Form1 : Form
    {
        private GameLoop gl;
        private int fieldWidth, fieldHeight;
        private int increment;

        public Form1()
        {
            InitializeComponent();

            increment = (int)Increment_UpDown.Value;
            fieldWidth = GameField.Width;
            Width_UpDown.Maximum = fieldWidth / increment;
            fieldHeight = GameField.Height;
            Height_UpDown.Maximum = fieldHeight / increment;

            GameLoop gl;
            GameField.Refresh();
        }

        private void DrawInPanel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GameLoop_Launch(g);
        }

        public void GameLoop_Launch(Graphics g)
        {
            int width = (int)Width_UpDown.Value;
            int height = (int)Height_UpDown.Value;
            bool[,] GameState = new bool[width, height];
            GameLoop gl = new(GameState, increment);
            gl.DrawGrid(g);
        }

        private void RefreshValues()
        {
            increment = (int)Increment_UpDown.Value;
            fieldWidth = GameField.Width;
            Width_UpDown.Maximum = fieldWidth / increment;
            fieldHeight = GameField.Height;
            Height_UpDown.Maximum = fieldHeight / increment;
        }

        private void StartClick(object sender, EventArgs e)
        {
            GameField.Refresh();
        }
        private void IncrementValueChange(object sender, EventArgs e)
        {

            GameField.Refresh();
        }
    }
}