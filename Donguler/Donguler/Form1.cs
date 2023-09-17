namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(i.ToString() + " -Merhaba Dünya ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi2 = 0, sayi1 = 0, toplam = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam = toplam + i;

            }
            label2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi=Convert.ToInt32(textBox3.Text);
            for (int i = 1; i <=sayi; i++)
            {
                if (sayi%i==0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }
    }
}