namespace _14_prejezd
{
    public partial class Form1 : Form
    {
        bool toggle = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new(Color.Black);
            Brush b = new SolidBrush(Color.Black);
            Brush r = new SolidBrush(Color.Red);
            Rectangle rect = new(190, 90, 340, 170);
            Rectangle rect1 = new(200, 100, 150, 150);
            Rectangle rect2 = new(370, 100, 150, 150);


            g.FillRectangle(b, rect);
            if (toggle)
            {
                g.FillEllipse(r, rect1);
                toggle = false;
            }
            else
            {
                g.FillEllipse(r, rect2);
                toggle = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}