namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString() + " " + comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text + " ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add(dateTimePicker1.Text);
            
        }
    }
}