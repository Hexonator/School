namespace _11_kresleni_mys_klavesnice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            string button = "";
            switch (e.Button)
            {
                case MouseButtons.Left:
                    button = "left";
                    break;
                case MouseButtons.Right:
                    button = "right";
                    break;
                case MouseButtons.Middle:
                    button = "middle";
                    break;
                default:
                    button = "unknown";
                    break;
            }
            label1.Text = $"{button} was pressed at ({e.X},{e.Y})";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string button = e.KeyCode.ToString();
            label1.Text = $"{button} was pressed";
        }
    }
}