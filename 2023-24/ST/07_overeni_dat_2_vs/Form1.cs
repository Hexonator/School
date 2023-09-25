namespace _07_overeni_dat_2_vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            string s = textBox1.Text;
            try
            {
                a = int.Parse(s);
                if (a <= 0 || a >= 1000)
                {
                    label1.Text = "Number has to be in range <0, 1000>";
                }
                else
                {
                    if (a % 2 == 0)
                    {
                        label1.Text = "Number is odd";
                    }
                    else
                    {
                        label1.Text = "Number is even";
                    }
                }
            }
            catch (Exception)
            {
                label1.Text = "Enter a number you dumbass";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}