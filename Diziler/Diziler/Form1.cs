namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslý", "Hakan", "Ayse", "Demet" };
            label1.Text = kisiler[6];
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            label2.Text = sayilar[0].ToString();
        }
    }
}