namespace _21_hra_NIM
{
    public partial class Form1 : Form
    {
        public int EdgeMargin = 50;
        public int width;
        public int height;
        public int fullMatchCount;

        public Form1()
        {
            InitializeComponent();


            width = Drawing_Panel.Width - EdgeMargin;
            height = Drawing_Panel.Height - EdgeMargin;
            fullMatchCount = (int)GameSize_UpDown.Value;
        }

        private void GameSize_ValChange(object sender, EventArgs e)
        {
            fullMatchCount = (int)GameSize_UpDown.Value;
            Drawing_Panel.Invalidate();
        }

        private void Drawing_Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen matchPen = new Pen(Color.SandyBrown, 10);
            Pen tipPen = new Pen(Color.OrangeRed, 13);

            int match_drawing_increment = width / fullMatchCount;

            for (int i = 0; i < fullMatchCount; i++)
            {
                int x = EdgeMargin + i * match_drawing_increment;
                Point p1 = new Point(x, EdgeMargin);
                Point p2 = new Point(x, height);
                g.DrawLine(matchPen, p1, p2);
                Point p3 = new Point(x, EdgeMargin + 15);
                g.DrawLine(tipPen, p1, p3);
            }
        }
    }
}