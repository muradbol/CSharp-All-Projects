namespace SinifOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car rb = new car();
            rb.renk = "Kýrmýzý";
            rb.hiz = 200;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.YIL = -2500;
            rb.MARKA = "Volvo ";
            rb.plaka = "34 JM 1474  ";
            rb.muayene = 2023;
            rb.sahip = "Murat BOLELLÝ  ";
            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKA.ToString();
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.sahip;
            label10.Text = rb.plaka;

            pictureBox1.BackColor = Color.CadetBlue;

        }
    }
}