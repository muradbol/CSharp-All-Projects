using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinifOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            car rb2 = new car();
            rb2.renk = "Yeşil";
            rb2.hiz = 300;
            rb2.motor = 1455.55;
            rb2.durum = '2';
            rb2.fiyat = 55214;
            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.motor.ToString();
            label4.Text = rb2.fiyat.ToString();
            label5.Text = rb2.durum.ToString();
            pictureBox1.BackColor = Color.CadetBlue;
        }
        
        }
    }

