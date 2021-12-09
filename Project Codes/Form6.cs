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
    public partial class Form6 : Form
    {
        public int satir = 0;
        public static double toplamFiyat = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            combo_corba.Size = new Size(141, 20);
            combo_yemek.Size = new Size(141, 20);
            combo_icecek.Size = new Size(141, 20);
            combo_tatli.Size = new Size(141, 20);
            combo_corba.Location = new Point(450, 50);
            combo_yemek.Location = new Point(600, 50);
            combo_icecek.Location = new Point(750, 50);
            combo_tatli.Location = new Point(900, 50);
            combo_corba.Text = "Corbalar";
            combo_icecek.Text = "Icecekler";
            combo_yemek.Text = "Yemekler";
            combo_tatli.Text = "Tatlilar";
            combo_corba.Items.Add("Mercimek Corbasi");
            combo_corba.Items.Add("Domates Corbasi");
            combo_corba.Items.Add("Iskembe Corbasi");
            combo_corba.Items.Add("Tarhana Corbasi");
            combo_yemek.Items.Add("Adana Kebap");
            combo_yemek.Items.Add("Lahmacun");
            combo_yemek.Items.Add("Pide");
            combo_yemek.Items.Add("Tavuk Doner");
            combo_yemek.Items.Add("Pizza");
            combo_yemek.Items.Add("Cigkofte");
            combo_icecek.Items.Add("Ayran");
            combo_icecek.Items.Add("Kola");
            combo_icecek.Items.Add("Gazoz");
            combo_icecek.Items.Add("Cay");
            combo_tatli.Items.Add("Kunefe");
            combo_tatli.Items.Add("Sutlac");
            combo_tatli.Items.Add("Kemal Pasa");
            corba_ekle.Size = new Size(141, 20);
            yemek_ekle.Size = new Size(141, 20);
            icecek_ekle.Size = new Size(141, 20);
            tatli_ekle.Size = new Size(141, 20);
            corba_ekle.Location = new Point(450, 80);
            yemek_ekle.Location = new Point(600, 80);
            icecek_ekle.Location = new Point(750, 80);
            tatli_ekle.Location = new Point(900, 80);
            corba_ekle.Text = "Ekle";
            yemek_ekle.Text = "Ekle";
            icecek_ekle.Text = "Ekle";
            tatli_ekle.Text = "Ekle";
            text_corba.Location = new Point(450, 230);
            text_yemek.Location = new Point(450, 260);
            text_icecek.Location = new Point(770, 230);
            text_tatli.Location = new Point(770, 260);
            text_corba.Size = new Size(170, 20);
            text_yemek.Size = new Size(170, 20);
            text_icecek.Size = new Size(170, 20);
            text_tatli.Size = new Size(170, 20);
            text_corba.Text = "Corbalar";
            text_yemek.Text = "Yemekler";
            text_icecek.Text = "Icecekler";
            text_tatli.Text = "Tatlilar";
            numeric_corba.Location = new Point(630, 230);
            numeric_yemek.Location = new Point(630, 260);
            numeric_icecek.Location = new Point(950, 230);
            numeric_tatli.Location = new Point(950, 260);
            numeric_corba.Size = new Size(50, 20);
            numeric_yemek.Size = new Size(50, 20);
            numeric_icecek.Size = new Size(50, 20);
            numeric_tatli.Size = new Size(50, 20);
            tablo_corba.Location = new Point(690, 230);
            tablo_yemek.Location = new Point(690, 260);
            tablo_icecek.Location = new Point(1010, 230);
            tablo_tatli.Location = new Point(1010, 260);
            tablo_corba.Size = new Size(60, 20);
            tablo_yemek.Size = new Size(60, 20);
            tablo_icecek.Size = new Size(60, 20);
            tablo_tatli.Size = new Size(60, 20);
            tablo_corba.Text = "Ekle";
            tablo_yemek.Text = "Ekle";
            tablo_icecek.Text = "Ekle";
            tablo_tatli.Text = "Ekle";
            text_fiyat.Location = new Point(720, 370);
            text_alinan.Location = new Point(720, 400);
            text_paraustu.Location = new Point(720, 460);
            btn_paraustu.Location = new Point(720, 430);
            btn_temizle.Location = new Point(720, 490);
            text_fiyat.Size = new Size(110, 20);
            text_alinan.Size = new Size(110, 20);
            text_paraustu.Size = new Size(110, 20);
            btn_paraustu.Size = new Size(110, 20);
            btn_temizle.Size = new Size(110, 20);
            btn_paraustu.Text = "Para Ustu";
            btn_temizle.Text = "Temizle";
            btn_hesapla.Location = new Point(120, 580);
            btn_hesapla.Size = new Size(100, 20);
            btn_hesapla.Text = "Hesapla";
            btn_geri.Location = new Point(1250, 590);
            btn_geri.Size = new Size(75, 30);
            btn_geri.Text = "Geri";
            tablo.Location = new Point(30, 50);
            tablo.Size = new Size(330, 510);
        }

        private void btn_paraustu_Click(object sender, EventArgs e)
        {
            string fiyat = text_fiyat.Text;
            string odenen = text_alinan.Text;
            if (Convert.ToDouble(fiyat) <= Convert.ToDouble(odenen))
            {

                Hesaplama p = new Hesap(Convert.ToDouble(fiyat), Convert.ToDouble(odenen));
                text_paraustu.Text = (Convert.ToString(p.paraustu));
            }
            else
                MessageBox.Show("Eksik Para");
        }

        private void corba_ekle_Click(object sender, EventArgs e)
        {
            string corba = combo_corba.Text;
            text_corba.Text = corba;
            combo_corba.Text = "Corbalar";
        }

        private void yemek_ekle_Click(object sender, EventArgs e)
        {
            string yemek = combo_yemek.Text;
            text_yemek.Text = yemek;
            combo_yemek.Text = "Yemekler";
        }

        private void icecek_ekle_Click(object sender, EventArgs e)
        {
            string icecek = combo_icecek.Text;
            text_icecek.Text = icecek;
            combo_icecek.Text = "Icecekler";
        }

        private void tatli_ekle_Click(object sender, EventArgs e)
        {
            string tatli = combo_tatli.Text;
            text_tatli.Text = tatli;
            combo_tatli.Text = "Tatlilar";
        }

        private void tablo_corba_Click(object sender, EventArgs e)
        {
            if (text_corba.Text == "Corbalar")
            {
                return;
            }
            DataGridViewRow row = (DataGridViewRow)tablo.Rows[0].Clone();
            double adet = Convert.ToDouble(numeric_corba.Value);
            row.Cells[0].Value = text_corba.Text;
            row.Cells[1].Value = numeric_corba.Value;
            if (text_corba.Text == "Mercimek Corbasi")
            {
                double fiyat = taneFiyati.mercimek;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_corba.Text == "Domates Corbasi")
            {
                double fiyat = taneFiyati.domates;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_corba.Text == "Iskembe Corbasi")
            {
                double fiyat = taneFiyati.iskembe;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_corba.Text == "Tarhana Corbasi")
            {
                double fiyat = taneFiyati.tarhana;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            tablo.Rows.Add(row);
            text_corba.Text = "Corbalar";
            numeric_corba.Value = 0;
            satir++;
        }

        private void tablo_yemek_Click(object sender, EventArgs e)
        {
            if (text_yemek.Text == "Yemekler")
            {
                return;
            }
            DataGridViewRow row = (DataGridViewRow)tablo.Rows[0].Clone();
            double adet = Convert.ToDouble(numeric_yemek.Value);
            row.Cells[0].Value = text_yemek.Text;
            row.Cells[1].Value = numeric_yemek.Value;
            if (text_yemek.Text == "Adana Kebap")
            {
                double fiyat = taneFiyati.adana;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_yemek.Text == "Lahmacun")
            {
                double fiyat = taneFiyati.lahmacun;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_yemek.Text == "Pide")
            {
                double fiyat = taneFiyati.pide;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_yemek.Text == "Tavuk Doner")
            {
                double fiyat = taneFiyati.tavuk;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_yemek.Text == "Pizza")
            {
                double fiyat = taneFiyati.pizza;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (tablo_yemek.Text == "Cigkofte")
            {
                double fiyat = taneFiyati.cigkofte;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            tablo.Rows.Add(row);
            text_yemek.Text = "Yemekler";
            numeric_yemek.Value = 0;
            satir++;
        }

        private void tablo_icecek_Click(object sender, EventArgs e)
        {
            if (text_icecek.Text == "Icecekler")
            {
                return;
            }
            DataGridViewRow row = (DataGridViewRow)tablo.Rows[0].Clone();
            double adet = Convert.ToDouble(numeric_icecek.Value);
            row.Cells[0].Value = text_icecek.Text;
            row.Cells[1].Value = numeric_icecek.Value;
            if (text_icecek.Text == "Ayran")
            {
                double fiyat = taneFiyati.ayran;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_icecek.Text == "Kola")
            {
                double fiyat = taneFiyati.kola;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_icecek.Text == "Gazoz")
            {
                double fiyat = taneFiyati.gazoz;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_icecek.Text == "Cay")
            {
                double fiyat = taneFiyati.cay;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            tablo.Rows.Add(row);
            text_icecek.Text = "Icecekler";
            numeric_icecek.Value = 0;
            satir++;
        }

        private void tablo_tatli_Click(object sender, EventArgs e)
        {
            if (text_tatli.Text == "Tatlilar")
            {
                return;
            }
            DataGridViewRow row = (DataGridViewRow)tablo.Rows[0].Clone();
            double adet = Convert.ToDouble(numeric_tatli.Value);
            row.Cells[0].Value = text_tatli.Text;
            row.Cells[1].Value = numeric_tatli.Value;
            if (text_tatli.Text == "Kunefe")
            {
                double fiyat = taneFiyati.kunefe;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_tatli.Text == "Sutlac")
            {
                double fiyat = taneFiyati.sutlac;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            else if (text_tatli.Text == "Kemal Pasa")
            {
                double fiyat = taneFiyati.pide;
                ToplamSonuc tabloFiyati = new ToplamSonuc(fiyat, adet);
                row.Cells[2].Value = (tabloFiyati.toplamFiyat);
            }
            tablo.Rows.Add(row);
            text_tatli.Text = "Tatlilar";
            numeric_tatli.Value = 0;
            satir++;
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int sira = 0;
            while (sira < satir)
            {
                string deger = tablo.Rows[sira].Cells[2].Value.ToString();
                toplamFiyat = toplamFiyat + Convert.ToDouble(deger);
                sira++;
            }
            text_fiyat.Text = Convert.ToString(toplamFiyat);
            toplamFiyat = 0;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            //tablo.Rows.Clear();
            for (int i = 0; i < satir; i++)
            {
                tablo.Rows.RemoveAt(i);
            }
            satir = 0;
            text_fiyat.Text = "";
            text_alinan.Text = "";
            text_paraustu.Text = "";
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form5 personelanasayfa = new Form5();
            this.Hide();
            personelanasayfa.Show();
        }
    }
}
