namespace Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi % 2== 0 ||sayi>=10)
            {
                label1.Text = "10'dan B�y�k Veya  Say� �ifttir ";

            }
            else
            {
                label1.Text = " 10'dan B�y�k de�il veya �ift say� de�ildir. ";
            }
        }
    }
}