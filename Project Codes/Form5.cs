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
    public partial class Form5 : Form
    {
        public static int sayac = 0;
        static public string[,] tablo = new string[10, 3];
        public static Form6 masa1 = new Form6();
        public static Form6 masa2 = new Form6();
        public static Form6 masa3 = new Form6();
        public static Form6 masa4 = new Form6();
        public static Form6 masa5 = new Form6();
        public static Form6 masa6 = new Form6();
        public static Form6 masa7 = new Form6();
        public static Form6 masa8 = new Form6();
        public static Form6 masa9 = new Form6();
        public static Form6 masa10 = new Form6();
        public static Form6 masa11 = new Form6();
        public static Form6 masa12 = new Form6();
        public static Form6 masa13 = new Form6();
        public static Form6 masa14 = new Form6();
        public static Form6 masa15 = new Form6();
        public static Form6 masa16 = new Form6();
        public static Form6 masa17 = new Form6();
        public static Form6 masa18 = new Form6();
       
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
            btn_cikis.Text = "Çıkış";
            btn_cikis.Location = new Point(1200, 600);
            btn_cikis.Size = new Size(100, 50);
            tablo_randevu.Size = new Size(430, 600);
            tablo_randevu.Location = new Point(100, 50);
            masa_1.Size = new Size(60, 60);
            masa_2.Size = new Size(60, 60);
            masa_3.Size = new Size(60, 60);
            masa_4.Size = new Size(60, 60);
            masa_5.Size = new Size(60, 60);
            masa_6.Size = new Size(60, 60);
            masa_7.Size = new Size(60, 60);
            masa_8.Size = new Size(60, 60);
            masa_9.Size = new Size(60, 60);
            masa_10.Size = new Size(60, 60);
            masa_11.Size = new Size(60, 60);
            masa_12.Size = new Size(60, 60);
            masa_13.Size = new Size(60, 60);
            masa_14.Size = new Size(60, 60);
            masa_15.Size = new Size(60, 60);
            masa_16.Size = new Size(60, 60);
            masa_17.Size = new Size(60, 60);
            masa_18.Size = new Size(60, 60);
            masa_1.Location = new Point(810, 205);
            masa_2.Location = new Point(810, 286);
            masa_3.Location = new Point(810, 366);
            masa_4.Location = new Point(912, 414);
            masa_5.Location = new Point(988, 414);
            masa_6.Location = new Point(1063, 414);
            masa_7.Location = new Point(1140, 414);
            masa_8.Location = new Point(1218, 414);
            masa_9.Location = new Point(1218, 339);
            masa_10.Location = new Point(1218, 260);
            masa_11.Location = new Point(1218, 183);
            masa_12.Location = new Point(1129, 153);
            masa_13.Location = new Point(1052, 153);
            masa_14.Location = new Point(975, 153);
            masa_15.Location = new Point(897, 153);
            masa_16.Location = new Point(1092, 275);
            masa_17.Location = new Point(1015, 275);
            masa_18.Location = new Point(940, 275);
            masa_1.Text = "1";
            masa_2.Text = "2";
            masa_3.Text = "3";
            masa_4.Text = "4";
            masa_5.Text = "5";
            masa_6.Text = "6";
            masa_7.Text = "7";
            masa_8.Text = "8";
            masa_9.Text = "9";
            masa_10.Text = "10";
            masa_11.Text = "11";
            masa_12.Text = "12";
            masa_13.Text = "13";
            masa_14.Text = "14";
            masa_15.Text = "15";
            masa_16.Text = "16";
            masa_17.Text = "17";
            masa_18.Text = "18";
        }
        public void randevu_ekle(string kulAd, string masa, string tarih, string saat)
        {
            DataGridViewRow row = (DataGridViewRow)tablo_randevu.Rows[0].Clone();
            row.Cells[0].Value = kulAd;
            row.Cells[1].Value = masa; 
            row.Cells[2].Value = tarih; 
            row.Cells[3].Value = saat;
            tablo_randevu.Rows.Add(row);
            sayac++;
        }
        public string name(int i)
        {
            return tablo_randevu.Rows[i].Cells[0].Value.ToString();
        }
        public string masa(int i)
        {
            return tablo_randevu.Rows[i].Cells[1].Value.ToString();
        }
        public string tarih(int i)
        {
            return tablo_randevu.Rows[i].Cells[2].Value.ToString();
        }
        public string saat(int i)
        {
            return tablo_randevu.Rows[i].Cells[3].Value.ToString();
        }
        public void randevu_sil(string kulAd, string masa, string tarih, string saat)
        {
            try
            {
                int count = 0;
                while (count <= sayac)
                {
                    string tablo_isim = tablo_randevu.Rows[count].Cells[0].Value.ToString();
                    string tablo_masa = tablo_randevu.Rows[count].Cells[1].Value.ToString();
                    string tablo_tarih = tablo_randevu.Rows[count].Cells[2].Value.ToString();
                    string tablo_saat = tablo_randevu.Rows[count].Cells[3].Value.ToString();
                    if (kulAd == tablo_isim && masa == tablo_masa && tarih == tablo_tarih && saat == tablo_saat)
                    {
                        tablo_randevu.Rows.RemoveAt(count);
                        sayac--;
                    }
                    count++;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Seçili Tarih Yanlış");
            }
            
        }
        private void masa_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa1.Show();
        }

        private void masa_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa2.Show();
        }

        private void masa_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa3.Show();
        }

        private void masa_4_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa4.Show();
        }

        private void masa_5_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa5.Show();
        }

        private void masa_6_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa6.Show();
        }

        private void masa_7_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa7.Show();
        }

        private void masa_8_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa8.Show();
        }

        private void masa_9_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa9.Show();
        }

        private void masa_10_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa10.Show();
        }

        private void masa_11_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa11.Show();
        }

        private void masa_12_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa12.Show();
        }

        private void masa_13_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa13.Show();
        }

        private void masa_14_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa14.Show();
        }

        private void masa_15_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa15.Show();
        }

        private void masa_16_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa16.Show();
        }

        private void masa_17_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa17.Show();
        }

        private void masa_18_Click(object sender, EventArgs e)
        {
            this.Hide();
            masa18.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form4.anasayfa.Show();
            this.Hide();
        }
    }
}
