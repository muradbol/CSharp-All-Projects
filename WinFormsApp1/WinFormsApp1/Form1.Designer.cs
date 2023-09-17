namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label7 = new Label();
            listBox2 = new ListBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Bingöl", "Bitlis", "Ankara", "Çankırı", "Samsun", "Kastamonu", "Sivas", "Ordu", "Kayseri" });
            comboBox1.Location = new Point(53, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 26);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 3;
            label1.Text = "Şehir";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Items.AddRange(new object[] { "Öğretmen", "Doktor", "Mühendis", "Aşçı", "İtfaiyeci", "Polis" });
            listBox1.Location = new Point(53, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(117, 130);
            listBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(661, 580);
            button1.Name = "button1";
            button1.Size = new Size(141, 36);
            button1.TabIndex = 6;
            button1.Text = "Bilgileri Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(703, 545);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-4, 81);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 8;
            label3.Text = "Meslek";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(203, 236);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(230, 26);
            maskedTextBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 239);
            label4.Name = "label4";
            label4.Size = new Size(176, 18);
            label4.TabIndex = 10;
            label4.Text = "Cep Telefon Numarası:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 282);
            label5.Name = "label5";
            label5.Size = new Size(161, 18);
            label5.TabIndex = 11;
            label5.Text = "T.C Kimlik Numarası:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(203, 274);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(230, 26);
            maskedTextBox2.TabIndex = 12;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(203, 315);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(230, 26);
            maskedTextBox3.TabIndex = 13;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 323);
            label6.Name = "label6";
            label6.Size = new Size(49, 18);
            label6.TabIndex = 14;
            label6.Text = "Tarih:";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(203, 347);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(230, 26);
            maskedTextBox4.TabIndex = 15;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 355);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 16;
            label7.Text = "Saat:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 18;
            listBox2.Location = new Point(21, 432);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(503, 166);
            listBox2.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(266, 391);
            button2.Name = "button2";
            button2.Size = new Size(83, 35);
            button2.TabIndex = 18;
            button2.Text = "Gönder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WIN_20230905_17_54_57_Pro;
            pictureBox1.Location = new Point(581, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(581, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 26);
            dateTimePicker1.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(639, 176);
            button3.Name = "button3";
            button3.Size = new Size(115, 31);
            button3.TabIndex = 21;
            button3.Text = "Tarihi Getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(814, 628);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(label7);
            Controls.Add(maskedTextBox4);
            Controls.Add(label6);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "s";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label6;
        private MaskedTextBox maskedTextBox4;
        private Label label7;
        private ListBox listBox2;
        private Button button2;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
    }
}