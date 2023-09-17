namespace ForeachDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           /* string[] kisiler = { "Ali","Ahmet","Mehmet","Mesut","Pýnar","Berna" };
            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }*/
            int toplam = 0;
            int[] sinavlar = { 70, 65, 85, 100, 90 };
            foreach (int x in sinavlar)
            {
                listBox1.Items.Add(x);
                toplam = toplam + x;
            }
            label1.Text= toplam.ToString();
            int ortalama = 0;
            ortalama = toplam / sinavlar.Length;
            label1.Text=ortalama.ToString();

        }
    }
}