using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractCode
{
    public partial class FormGetPasscode : Form
    {
        public FormGetPasscode()
        {
            InitializeComponent();
        }

        private void FormGetPasscode_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetCode_Click(object sender, EventArgs e)
        {
            // Global Declarations.
            StreamReader inputFile;

            // Try to Open a file, catch errors if there are.
            try
            {
                // Open the file with explorer.
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    // Open the file and get a StreamReader object.               
                    inputFile = File.OpenText(OpenFile.FileName);

                    // Filetype Validation.
                    if (!OpenFile.ToString().Contains(".txt"))
                    {
                        MessageBox.Show("That is not a (.txt) file!!!");
                    }
                    else
                    {
                        // Declare variables to hold all the passscodes.
                        string sPasscode = "";
                        string sTempPasscode = "";
                        string sTempTwoPasscode = "";

                        // Read the file's contents.
                        while (!inputFile.EndOfStream)
                        {                          
                            // Get lines.
                            sTempPasscode = inputFile.ReadLine() + "\n";

                            // Check if the line have //ygoprodeck.com/pics/ substring.
                            Boolean temp = false;
                            temp = sTempPasscode.Contains("src=\"https://ygoprodeck.com/pics/");

                            // If the line contains it.
                            if (temp)
                            {
                                // Get this substring in this format /pics/########.
                                sTempTwoPasscode = sTempPasscode.Substring(sTempPasscode.LastIndexOf("/pics/"), 14) + "\n";

                                // Getting the first char after /pics/#.
                                char tempChar = sTempTwoPasscode[7];

                                // If that char is a number.
                                if ((int)Char.GetNumericValue(tempChar) >= 0 && (int)Char.GetNumericValue(tempChar) <= 9)
                                {
                                    // Get the whole 8-digit number.
                                    sPasscode = sTempTwoPasscode.Substring(6,8) + "\n";

                                    // Add the Passcode to the ListBox.
                                    listBoxPasscode.Items.Add(sPasscode);
                                }
                            }      
                        }
                    }

                    // Copying all values from the listbox to the textBox.
                    String text = "";
                    foreach (var item in listBoxPasscode.Items)
                    {
                        text += item.ToString(); // /n to print each item on new line or you omit /n to print text on same line
                    }
                    textBoxPasscode.Text = text;

                    // Close the file.
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("You clicked the Cancel button.");
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }                              
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the Program.
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear anything currently in the ListBox.
            listBoxPasscode.Items.Clear();
            textBoxPasscode.Text = "";
        }
    }
}