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
                case 2: label2.Text = "Þubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayýs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Aðustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasým"; break;
                case 12: label2.Text = "Aralýk"; break;
                default: label2.Text = "Hatalý Ay"; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim=textBox2.Text;
            switch (mevsim)
            {
                case "yaz": label4.Text = "Haziran, Temmuz , Aðustos"; break;
                case "kýs": label4.Text = "Aralýk, Ocak , Þubat"; break;
                case "sonbahar": label4.Text = "Eylül , Ekim , Kasým"; break;
                case "ilkbahar": label4.Text = "Mart, Nisan , Mayýs"; break;
                default: label4.Text = "Hatalý Mevsim"; break;
            }

        }
    }
}