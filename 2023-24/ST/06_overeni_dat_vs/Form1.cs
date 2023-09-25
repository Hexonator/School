namespace _06_overeni_dat_vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a))
            {
                if (a > 0 && a < 1000)
                {
                    button1.Enabled = true;
                    label2.Text = "Entered number is within range";
                }
                else
                {
                    button1.Enabled = false;
                    label2.Text = "Enter number is out of range";
                }
            }
            else if (textBox1.Text == "tvoje máma")
            {
                label2.Text = "TVOJE MÁMA";
            }
            else
            {
                button1.Enabled = false;
                label2.Text = "A number wasn't entered";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            if (number % 2 == 0)
            {
                label1.Text = "Number is even";
            }
            else
            {
                label1.Text = "Number is odd";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}