namespace _09_Game_Of_Life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawInPanel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GameLoop()
        }

        private void StartClick(object sender, EventArgs e)
        {
            GameLoop_Launch();
        }
        public void GameLoop_Launch()
        {
            int width = (int)Width_UpDown.Value;
            int height = (int)Height_UpDown.Value;
            bool[,] GameState = new bool[width, height];
            GameLoop gl = new(GameState);
            gl.DrawGrid(g, width, height);
        }
    }
}