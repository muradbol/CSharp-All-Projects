namespace MontOfTheYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "Ocak"; break;
                case 2: label2.Text = "�ubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "May�s"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "A�ustos"; break;
                case 9: label2.Text = "Eyl�l"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kas�m"; break;
                case 12: label2.Text = "Aral�k"; break;
                default: label2.Text = "Hatal� Ay"; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim=textBox2.Text;
            switch (mevsim)
            {
                case "yaz": label4.Text = "Haziran, Temmuz , A�ustos"; break;
                case "k�s": label4.Text = "Aral�k, Ocak , �ubat"; break;
                case "sonbahar": label4.Text = "Eyl�l , Ekim , Kas�m"; break;
                case "ilkbahar": label4.Text = "Mart, Nisan , May�s"; break;
                default: label4.Text = "Hatal� Mevsim"; break;
            }

        }
    }
}