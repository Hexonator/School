namespace _9_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string napis = b.Text;

            if (napis == "prvni")
            {
                label1.Text = "prvni";
            }
            else if (napis == "druhe")
            {
                label1.Text = "druhe";
            }
            else
            {
                label1.Text = napis;
            }

            Random r = new Random();
            Point random_point = b.Location;
            random_point.X = Math.Abs(r.Next(0, 400));
            random_point.Y = Math.Abs(r.Next(0, 200));

            b.Text = "tvoje mama";
            b.Location = random_point;
        }
    }
}