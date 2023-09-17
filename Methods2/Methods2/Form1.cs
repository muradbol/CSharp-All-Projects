using System.Runtime.Intrinsics.Arm;

namespace Methods2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int carp(int s1,int s2)
        {
            int carpim = s1 * s2;
            return carpim;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2= Convert.ToInt32(textBox2.Text);
            label1.Text = carp(s1, s2).ToString();
            
        }
    }
}