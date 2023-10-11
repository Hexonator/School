namespace _12_graphDrawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<int> TextProcessing(string input)
        {
            // x=0, sin=1, cos=2, tg=3, cotg=4
            // +=10, -=20, *=30, /=40

            return new List<int> { 0 };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<int> text_result = TextProcessing(EntryBox.Text);
                if (text_result[0] == 1)
                {

                }
                else
                {
                    infoBox.Text = "Function entered is invalid";
                }
            }
        }
    }
}