namespace _20_password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Button_Click(object sender, EventArgs e)
        {
            Password_generator_class gen = new Password_generator_class();
            int PasswordLen = (int)PassLength_UpDown.Value;

            string password = gen.Generate_password(PasswordLen);

            Password_TextBox.Text = password;
        }
    }
}