using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form4 : Form
    {
        public static int tableno = 0;
        public static Form1 anasayfa = new Form1();
        public static Form7 tarih1 = new Form7();
        public static Form7 tarih2 = new Form7();
        public static Form7 tarih3 = new Form7();
        public static Form7 tarih4 = new Form7();
        public static Form7 tarih5 = new Form7();
        public static Form7 tarih6 = new Form7();
        public static Form7 tarih7 = new Form7();
        public static Form7 tarih8 = new Form7();
        public static Form7 tarih9 = new Form7();
        public static Form7 tarih10 = new Form7();
        public static Form7 tarih11 = new Form7();
        public static Form7 tarih12 = new Form7();
        public static Form7 tarih13 = new Form7();
        public static Form7 tarih14 = new Form7();
        public static Form7 tarih15 = new Form7();
        public static Form7 tarih16 = new Form7();
        public static Form7 tarih17 = new Form7();
        public static Form7 tarih18 = new Form7();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            masa_1.Size = new Size(95,101);
            masa_2.Size = new Size(95, 101);
            masa_3.Size = new Size(95, 101);
            masa_4.Size = new Size(95, 101);
            masa_5.Size = new Size(95, 101);
            masa_6.Size = new Size(95, 101);
            masa_7.Size = new Size(95, 101);
            masa_8.Size = new Size(95, 101);
            masa_9.Size = new Size(95, 101);
            masa_10.Size = new Size(95, 101);
            masa_11.Size = new Size(95, 101);
            masa_12.Size = new Size(95, 101);
            masa_13.Size = new Size(95, 101);
            masa_14.Size = new Size(95, 101);
            masa_15.Size = new Size(95, 101);
            masa_16.Size = new Size(95, 101);
            masa_17.Size = new Size(95, 101);
            masa_18.Size = new Size(95, 101);

            masa_1.Location = new Point(132, 100);
            masa_2.Location = new Point(132, 258);
            masa_3.Location = new Point(132, 393);
            masa_4.Location = new Point(298, 447);
            masa_5.Location = new Point(466, 447);
            masa_6.Location = new Point(629, 447);
            masa_7.Location = new Point(792, 447);
            masa_8.Location = new Point(957, 393);
            masa_9.Location = new Point(957, 258);
            masa_10.Location = new Point(957, 130);
            masa_11.Location = new Point(792, 81);
            masa_12.Location = new Point(629, 81);
            masa_13.Location = new Point(466, 81);
            masa_14.Location = new Point(298, 81);
            masa_15.Location = new Point(292, 258);
            masa_16.Location = new Point(466, 258);
            masa_17.Location = new Point(629, 258);
            masa_18.Location = new Point(792, 258);
            button1.Text = "ÇIKIŞ";
            button1.Location = new Point(1200,20);
            button1.Size = new Size(90, 25 );

            masa_1.Text = "Masa 1";
            masa_2.Text = "Masa 2";
            masa_3.Text = "Masa 3";
            masa_4.Text = "Masa 4";
            masa_5.Text = "Masa 5";
            masa_6.Text = "Masa 6";
            masa_7.Text = "Masa 7";
            masa_8.Text = "Masa 8";
            masa_9.Text = "Masa 9";
            masa_10.Text = "Masa 10";
            masa_11.Text = "Masa 11";
            masa_12.Text = "Masa 12";
            masa_13.Text = "Masa 13";
            masa_14.Text = "Masa 14";
            masa_15.Text = "Masa 15";
            masa_16.Text = "Masa 16";
            masa_17.Text = "Masa 17";
            masa_18.Text = "Masa 18";

            WindowState = FormWindowState.Maximized;
        }

        private void masa_1_Click(object sender, EventArgs e)
        {
            tableno = 1;
            tarih1.Show();
            this.Hide();
        }

        private void masa_2_Click(object sender, EventArgs e)
        {
            tableno = 2;
            tarih2.Show();
            this.Hide();
        }

        private void masa_3_Click(object sender, EventArgs e)
        {
            tableno = 3;
            tarih3.Show();
            this.Hide();
        }

        private void masa_4_Click(object sender, EventArgs e)
        {
            tableno = 4;
            tarih4.Show();
            this.Hide();
        }

        private void masa_5_Click(object sender, EventArgs e)
        {
            tableno = 5;
            tarih5.Show();
            this.Hide();
        }

        private void masa_6_Click(object sender, EventArgs e)
        {
            tableno = 6;
            tarih6.Show();
            this.Hide();
        }

        private void masa_7_Click(object sender, EventArgs e)
        {
            tableno = 7;
            tarih7.Show();
            this.Hide();
        }

        private void masa_8_Click(object sender, EventArgs e)
        {
            tableno = 8;
            tarih8.Show();
            this.Hide();
        }

        private void masa_9_Click(object sender, EventArgs e)
        {
            tableno = 9;
            tarih9.Show();
            this.Hide();
        }

        private void masa_10_Click(object sender, EventArgs e)
        {
            tableno = 10;
            tarih10.Show();
            this.Hide();
        }

        private void masa_11_Click(object sender, EventArgs e)
        {
            tableno = 11;
            tarih11.Show();
            this.Hide();
        }

        private void masa_12_Click(object sender, EventArgs e)
        {
            tableno = 12;
            tarih12.Show();
            this.Hide();
        }

        private void masa_13_Click(object sender, EventArgs e)
        {
            tableno = 13;
            tarih13.Show();
            this.Hide();
        }

        private void masa_14_Click(object sender, EventArgs e)
        {
            tableno = 14;
            tarih14.Show();
            this.Hide();
        }

        private void masa_15_Click(object sender, EventArgs e)
        {
            tableno = 15;
            tarih15.Show();
            this.Hide();
        }

        private void masa_16_Click(object sender, EventArgs e)
        {
            tableno = 16;
            tarih16.Show();
            this.Hide();

        }

        private void masa_17_Click(object sender, EventArgs e)
        {
            tableno = 17;
            tarih17.Show();
            this.Hide();
        }

        private void masa_18_Click(object sender, EventArgs e)
        {
            tableno = 18;
            tarih18.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uye.online = false;
            anasayfa.Show();
            this.Hide();
        }
    }
}
