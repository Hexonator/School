using MathNet.Numerics;

namespace _12_graphDrawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Evaluate(string input)
        {
            // x=0, sin=1, cos=2, tg=3, cotg=4
            // +=10, -=20, *=30, /=40
            try
            {
                double result = Math(input);
            }
            catch (Exception e)
            {
                infoBox.Text = $"Error: {e.Message}";
                return int.MaxValue;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int text_result = Evaluate(EntryBox.Text);
                if (text_result != int.MaxValue)
                {
                    
                }
            }
        }
    }
}