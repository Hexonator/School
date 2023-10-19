namespace _13_auticko_animace
{
    public partial class Form1 : Form
    {
        Image car = Image.FromFile("auto.png");
        int x = 50;
        int y = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = car.Width / 3;
            int height = car.Height / 3;

            g.DrawImage(car, new Point(x, y));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 2;
            Refresh();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}