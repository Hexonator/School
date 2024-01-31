using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace _110_Txt_to_Hex
{
    public partial class Form1 : Form
    {
        string filename = "";
        Dictionary<string, string[]> binFile = new Dictionary<string, string[]>();
        int bitIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void convertTxtToHex(string filename)
        {
            binFile.Clear();
            bitIndex = 0;
            binDisplayTextBox.Text = "Processing...";

            try
            {
                StreamReader sr = new StreamReader(filename);
                bool fileEnd = false;
                while (!fileEnd)
                {
                    string hexIndex = bitIndex.ToString("x8");
                    binFile[hexIndex] = new string[16];
                    for (int i = 0; i < 16; i++)
                    {
                        if (sr.Peek() == -1)
                        {
                            fileEnd = true;
                            break;
                        }
                        string hexValue = sr.Read().ToString("x2");
                        binFile[hexIndex][i] = hexValue;
                        bitIndex++;
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(
                "Invalid file path",
                "You useless dumbass",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }

        }

        public string getHexToString()
        {
            string return_string = "";
            StreamReader sr = new StreamReader(filename);
            string tempString = "";

            foreach (var key in binFile.Keys)
            {
                return_string += key + " ";
                foreach (var bit in binFile[key])
                {
                    if (bit == null)
                    {
                        return_string += "   ";
                        tempString += "_";
                        continue;
                    }
                    return_string += bit + " ";
                    char fileChar = (char)sr.Read();
                    if (fileChar.ToString() == System.Environment.NewLine || fileChar == '\n')
                    {
                        tempString += "..";
                    }
                    else
                    {
                        tempString += fileChar;
                    }
                }
                return_string += $"|{tempString}|";
                tempString = "";
                return_string += System.Environment.NewLine;
            }
            sr.Close();
            return return_string;
        }

        private void BrowseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filenameTextBox.Text = openFile.FileName;
                filename = openFile.FileName;
            }
            else
            {
                filename = "";
                filenameTextBox.Text = "";
            }
        }

        private void getBinButton_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                MessageBox.Show(
                "You haven't selected a file",
                "You useless dumbass",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            else
            {
                convertTxtToHex(filename);
                binDisplayTextBox.Text = getHexToString();
            }
        }

        private void filenameTextBox_TextChanged(object sender, EventArgs e)
        {
            filename = filenameTextBox.Text;
        }
    }
}