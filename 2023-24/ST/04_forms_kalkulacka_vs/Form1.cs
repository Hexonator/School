namespace _04_forms_kalkulacka_vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number1.Text != "" && number2.Text != "")
            {
                double num1 = double.Parse(number1.Text);
                double num2 = double.Parse(number2.Text);
                int operation = comboBox1.SelectedIndex;
                double answer = 0;

                switch (operation)
                {
                    case 0: answer = num1 + num2;
                        break;
                    case 1: answer = num1 - num2;
                        break;
                    case 2: answer = num1 * num2;
                        break;
                    case 3: answer = num1 / num2;
                        break;
                    default:
                        break;
                }
                label1.Text = answer.ToString;
            }
        }
    }
}