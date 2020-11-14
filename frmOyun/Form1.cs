using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmOyun
{
    public partial class Form1 : Form
    {
        //static int toplam = 0;
        static int sure = 0;
        int puan = 0;
        Random rdn = new Random();
        string secim;
        string E, H;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*puan += 5;*/
            Button btn = (Button)sender;
            puan += int.Parse(btn.Text);
            label2.Text = $"Skor:{puan}";
            btn.Dispose();

            if (puan > 500 || puan ==500)
            {

                MessageBox.Show(puan + label3.Text + label4.Text + " Kaybettin.Bir daha oynayalmı mı?");


                /*if (secim == E)
                {

                    Application.Restart();

                }
                else if (secim == H)
                {

                    MessageBox.Show("Skorunuz:" + puan);
                    this.Close();
                }*/



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random rdn = new Random();
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rdn.Next(this.ClientSize.Width - btn.Width), rdn.Next(this.ClientSize.Height
                - btn.Height));
            btn.Text = rdn.Next(100).ToString();
            btn.Click += button1_Click;
            this.Controls.Add(btn);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //sure--;
            label1.Text = sure.ToString();
            sure = sure + 1;
            label1.Text = Convert.ToString(sure);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
