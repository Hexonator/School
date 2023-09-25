namespace _05_slevy_vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1 = entered_number1.Value;
            string sale = comboBox1.Text;

            switch (sale)
            {
                case "sleva 10%":
                    num1 *= 0.9m;
                    break;
                case "sleva 20%":
                    num1 *= 0.8m;
                    break;
                case "sleva 30%":
                    num1 *= 0.7m;
                    break;
                case "sleva 50%":
                    num1 *= 0.5m;
                    break;
                default:
                    break;
            }
            label1.Text = num1.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}