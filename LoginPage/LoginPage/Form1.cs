namespace LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Murat" && textBox2.Text == "1234")
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}