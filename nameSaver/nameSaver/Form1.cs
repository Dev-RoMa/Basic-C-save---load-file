using System.IO;

namespace nameSaver
{
    public partial class Form1 : Form
    {
        private string filePath = "data.txt";

        public Form1()
        {
            InitializeComponent();

            // Load the contents of the file into the text box
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string contents = reader.ReadToEnd();
                    textBox1.Text = contents;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the contents of the text box
            string contents = textBox1.Text;

            // Write the contents to a file, overwriting any existing file
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.Write(contents);
            }

            // Display a message box to confirm that the data was saved
            MessageBox.Show("Data saved successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Load the contents of the file into the text box
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string contents = reader.ReadToEnd();
                    textBox1.Text = contents;
                }

                // Display a message box to confirm that the data was loaded
                MessageBox.Show("Data loaded successfully!");
            }
            else
            {
                // Display a message box if the file does not exist
                MessageBox.Show("No data file found.");
            }
        }
    }
}
