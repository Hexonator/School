namespace _8_kvadraticka_rovnice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            errorField.Text = string.Empty;
            x1_result.Text = string.Empty;
            x2_result.Text = string.Empty;

            if (x2_textBox.Text == "" ||
                x_textBox.Text == "" ||
                num_textBox.Text == "")
            {
                errorField.Text = "Některé z polí je prázdné";
            }
            else
            {
                int a, b, c;
                try
                {
                    a = int.Parse(x2_textBox.Text);
                    b = int.Parse(x_textBox.Text);
                    c = int.Parse(num_textBox.Text);
                }
                catch (System.FormatException)
                {
                    errorField.Text = "Nebylo zadáno číslo";
                }
                a = int.Parse(x2_textBox.Text);
                b = int.Parse(x_textBox.Text);
                c = int.Parse(num_textBox.Text);

                double D = Math.Pow(b, 2) - 4 * a * c;
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);

                if (double.IsNaN(x1) || double.IsNaN(x2))
                {
                    errorField.Text = "Řešení není v R";
                }
                else
                {
                    x1_result.Text = x1.ToString();
                    x2_result.Text = x2.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorField.Text = string.Empty;
            x1_result.Text = string.Empty;
            x2_result.Text = string.Empty;
            x2_textBox.Clear();
            x_textBox.Clear();
            num_textBox.Clear();
            errorField.Text = "Čisto!";
        }
    }
};