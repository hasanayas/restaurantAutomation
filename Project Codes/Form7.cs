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
    public partial class Form7 : Form
    {
        public static int dizi = 0;
        Form4 sayfa = new Form4();
        public bool kontrol;
        public static string isim;
        public static string masano;
        public static string tarih;
        public static string saat;
        public string[] goruntuleme = new string[100];
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            monthCalendar1.Location = new Point(360,70);
            monthCalendar1.Size = new Size(640,270);

            checkBox1.Location = new Point(380, 320);
            checkBox2.Location = new Point(380, 360);
            checkBox3.Location = new Point(380, 400);
            checkBox4.Location = new Point(380, 440);
            checkBox5.Location = new Point(380, 480);
            checkBox6.Location = new Point(630, 320);
            checkBox7.Location = new Point(630, 360);
            checkBox8.Location = new Point(630, 400);
            checkBox9.Location = new Point(630, 440);
            checkBox10.Location = new Point(630, 480);
            checkBox11.Location = new Point(870, 320);
            checkBox12.Location = new Point(870, 360);
            checkBox13.Location = new Point(870, 400);
            checkBox14.Location = new Point(870, 440);
            checkBox15.Location = new Point(870, 480);
            
            checkBox1.Size = new Size(91, 17);
            checkBox2.Size = new Size(91, 17);
            checkBox3.Size = new Size(91, 17);
            checkBox4.Size = new Size(91, 17);
            checkBox5.Size = new Size(91, 17);
            checkBox6.Size = new Size(91, 17);
            checkBox7.Size = new Size(91, 17);
            checkBox8.Size = new Size(91, 17);
            checkBox9.Size = new Size(91, 17);
            checkBox10.Size = new Size(91, 17);
            checkBox11.Size = new Size(91, 17);
            checkBox12.Size = new Size(91, 17);
            checkBox13.Size = new Size(91, 17);
            checkBox14.Size = new Size(91, 17);
            checkBox15.Size = new Size(91, 17);

            checkBox1.Text = "09.00 - 10.00";
            checkBox2.Text = "10.00 - 11.00";
            checkBox3.Text = "11.00 - 12.00";
            checkBox4.Text = "12.00 - 13.00";
            checkBox5.Text = "13.00 - 14.00";
            checkBox6.Text = "14.00 - 15.00"; 
            checkBox7.Text = "15.00 - 16.00";
            checkBox8.Text = "16.00 - 17.00";
            checkBox9.Text = "17.00 - 18.00";
            checkBox10.Text = "18.00 - 19.00";
            checkBox11.Text = "19.00 - 20.00";
            checkBox12.Text = "20.00 - 21.00";
            checkBox13.Text = "21.00 - 22.00";
            checkBox14.Text = "22.00 - 23.00";
            checkBox15.Text = "23.00 - 00.00";

            btn_tamam.Location = new Point(584, 540);
            btn_tamam.Size = new Size(81, 23);

            btn_iptal.Location = new Point(670, 540);
            btn_iptal.Size = new Size(81, 23);

            btn_randevu.Location = new Point(600, 570);
            btn_randevu.Size = new Size(131, 23);

            btn_geri.Location = new Point(1200, 600);
            btn_geri.Size = new Size(81, 23);

            btn_tamam.Text = "TAMAM";
            btn_iptal.Text = "İPTAL";
            btn_randevu.Text = "RANDEVULARIM";
            btn_geri.Text = "GERİ";
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            masano = Form4.tableno.ToString();
            tarih = monthCalendar1.SelectionRange.Start.ToShortDateString();
            if (DateTime.Now.ToShortDateString() == tarih)
            {
                if (uye.online == true)
                {
                    isim = uye.suanki_kullanici;
                }
                if (checkBox1.Checked)
                {
                    checkBox1.BackColor = Color.White;
                    saat = checkBox1.Text;
                    checkBox1.Enabled = false;
                    checkBox1.Checked = false;
                }
                else if (checkBox2.Checked)
                {
                    checkBox2.BackColor = Color.White;
                    saat = checkBox2.Text;
                    checkBox2.Enabled = false;
                    checkBox2.Checked = false;
                }
                else if (checkBox3.Checked)
                {
                    checkBox3.BackColor = Color.White;
                    saat = checkBox3.Text;
                    checkBox3.Enabled = false;
                    checkBox3.Checked = false;
                }
                else if (checkBox4.Checked)
                {
                    checkBox4.BackColor = Color.White;
                    saat = checkBox4.Text;
                    checkBox4.Enabled = false;
                    checkBox4.Checked = false;
                }
                else if (checkBox5.Checked)
                {
                    checkBox5.BackColor = Color.White;
                    saat = checkBox5.Text;
                    checkBox5.Enabled = false;
                    checkBox5.Checked = false;
                }
                else if (checkBox6.Checked)
                {
                    checkBox6.BackColor = Color.White;
                    saat = checkBox6.Text;
                    checkBox6.Enabled = false;
                    checkBox6.Checked = false;
                }
                else if (checkBox7.Checked)
                {
                    checkBox7.BackColor = Color.White;
                    saat = checkBox7.Text;
                    checkBox7.Enabled = false;
                    checkBox7.Checked = false;
                }
                else if (checkBox8.Checked)
                {
                    checkBox8.BackColor = Color.White;
                    saat = checkBox8.Text;
                    checkBox8.Enabled = false;
                    checkBox8.Checked = false;
                }
                else if (checkBox9.Checked)
                {
                    checkBox9.BackColor = Color.White;
                    saat = checkBox9.Text;
                    checkBox9.Enabled = false;
                    checkBox9.Checked = false;
                }
                else if (checkBox10.Checked)
                {
                    checkBox10.BackColor = Color.White;
                    saat = checkBox10.Text;
                    checkBox10.Enabled = false;
                    checkBox10.Checked = false;
                }
                else if (checkBox11.Checked)
                {
                    checkBox11.BackColor = Color.White;
                    saat = checkBox11.Text;
                    checkBox11.Enabled = false;
                    checkBox11.Checked = false;
                }
                else if (checkBox12.Checked)
                {
                    checkBox12.BackColor = Color.White;
                    saat = checkBox12.Text;
                    checkBox12.Enabled = false;
                    checkBox12.Checked = false;
                }
                else if (checkBox13.Checked)
                {
                    checkBox13.BackColor = Color.White;
                    saat = checkBox13.Text;
                    checkBox13.Enabled = false;
                    checkBox13.Checked = false;
                }
                else if (checkBox14.Checked)
                {
                    checkBox14.BackColor = Color.White;
                    saat = checkBox14.Text;
                    checkBox14.Enabled = false;
                    checkBox14.Checked = false;
                }
                else if (checkBox15.Checked)
                {
                    checkBox15.BackColor = Color.White;
                    saat = checkBox15.Text;
                    checkBox15.Enabled = false;
                    checkBox15.Checked = false;
                }
                Form1.personelAnasayfa.randevu_ekle(isim, masano, tarih, saat);
                kontrol = false;
            }
            else
                MessageBox.Show("Yanlış Gündesiniz");
            
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            try 
            {
                masano = Form4.tableno.ToString();
                tarih = monthCalendar1.SelectionRange.Start.ToShortDateString();
                if (uye.online == true)
                {
                    isim = uye.suanki_kullanici;
                }
                if (checkBox1.Checked && goruntuleme.Contains("checkBox1"))
                {
                    checkBox1.BackColor = Color.White;
                    saat = checkBox1.Text;
                    checkBox1.Enabled = true;
                    checkBox1.Checked = false;
                }
                else if (checkBox2.Checked && goruntuleme.Contains("checkBox2"))
                {
                    checkBox2.BackColor = Color.White;
                    saat = checkBox2.Text;
                    checkBox2.Enabled = true;
                    checkBox2.Checked = false;
                }
                else if (checkBox3.Checked && goruntuleme.Contains("checkBox3"))
                {
                    checkBox3.BackColor = Color.White;
                    saat = checkBox3.Text;
                    checkBox3.Enabled = true;
                    checkBox3.Checked = false;
                }
                else if (checkBox4.Checked && goruntuleme.Contains("checkBox4"))
                {
                    checkBox4.BackColor = Color.White;
                    saat = checkBox4.Text;
                    checkBox4.Enabled = true;
                    checkBox4.Checked = false;
                }
                else if (checkBox5.Checked && goruntuleme.Contains("checkBox5"))
                {
                    checkBox5.BackColor = Color.White;
                    saat = checkBox5.Text;
                    checkBox5.Enabled = true;
                    checkBox5.Checked = false;
                }
                else if (checkBox6.Checked && goruntuleme.Contains("checkBox6"))
                {
                    checkBox6.BackColor = Color.White;
                    saat = checkBox6.Text;
                    checkBox6.Enabled = true;
                    checkBox6.Checked = false;
                }
                else if (checkBox7.Checked && goruntuleme.Contains("checkBox7"))
                {
                    checkBox7.BackColor = Color.White;
                    saat = checkBox7.Text;
                    checkBox7.Enabled = true;
                    checkBox7.Checked = false;
                }
                else if (checkBox8.Checked && goruntuleme.Contains("checkBox8"))
                {
                    checkBox8.BackColor = Color.White;
                    saat = checkBox8.Text;
                    checkBox8.Enabled = true;
                    checkBox8.Checked = false;
                }
                else if (checkBox9.Checked && goruntuleme.Contains("checkBox9"))
                {
                    checkBox9.BackColor = Color.White;
                    saat = checkBox9.Text;
                    checkBox9.Enabled = true;
                    checkBox9.Checked = false;
                }
                else if (checkBox10.Checked && goruntuleme.Contains("checkBox10"))
                {
                    checkBox10.BackColor = Color.White;
                    saat = checkBox10.Text;
                    checkBox10.Enabled = true;
                    checkBox10.Checked = false;
                }
                else if (checkBox11.Checked && goruntuleme.Contains("checkBox11"))
                {
                    checkBox11.BackColor = Color.White;
                    saat = checkBox11.Text;
                    checkBox11.Enabled = true;
                    checkBox11.Checked = false;
                }
                else if (checkBox12.Checked && goruntuleme.Contains("checkBox12"))
                {
                    checkBox12.BackColor = Color.White;
                    saat = checkBox12.Text;
                    checkBox12.Enabled = true;
                    checkBox12.Checked = false;
                }
                else if (checkBox13.Checked && goruntuleme.Contains("checkBox13"))
                {
                    checkBox13.BackColor = Color.White;
                    saat = checkBox13.Text;
                    checkBox13.Enabled = true;
                    checkBox13.Checked = false;
                }
                else if (checkBox14.Checked && goruntuleme.Contains("checkBox14"))
                {
                    checkBox14.BackColor = Color.White;
                    saat = checkBox14.Text;
                    checkBox14.Enabled = true;
                    checkBox14.Checked = false;
                }
                else if (checkBox15.Checked && goruntuleme.Contains("checkBox15"))
                {
                    checkBox15.BackColor = Color.White;
                    saat = checkBox15.Text;
                    checkBox15.Enabled = true;
                    checkBox15.Checked = false;
                }
                Form1.personelAnasayfa.randevu_sil(isim, masano, tarih, saat);
                goruntuleme = new string[100];
                dizi = 0;
            }
            catch(Exception)
            {
                MessageBox.Show("Seçili tarih yanlış");
            }   
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (uye.online == true)
            {
                isim = uye.suanki_kullanici;
            }
            int satir = Form5.sayac;
            for(int i=0; i<satir;i++)
            {
                string tablo_saat = Form1.personelAnasayfa.saat(i);
                string tablo_masa = Form1.personelAnasayfa.masa(i);
                string tablo_ad = Form1.personelAnasayfa.name(i);
                if (checkBox1.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox1.Checked = false;
                    checkBox1.BackColor = Color.White;
                    checkBox1.Enabled = false;
                }
                else if (checkBox2.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox2.Checked = false;
                    checkBox2.BackColor = Color.White;
                    checkBox2.Enabled = false;
                }
                else if (checkBox3.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox3.Checked = false;
                    checkBox3.BackColor = Color.White;
                    checkBox3.Enabled = false;
                }
                else if (checkBox4.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox4.Checked = false;
                    checkBox4.BackColor = Color.White;
                    checkBox4.Enabled = false;
                }
                else if (checkBox5.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox5.Checked = false;
                    checkBox5.BackColor = Color.White;
                    checkBox5.Enabled = false;
                }
                else if (checkBox6.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox6.Checked = false;
                    checkBox6.BackColor = Color.White;
                    checkBox6.Enabled = false;
                }
                else if (checkBox7.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox7.Checked = false;
                    checkBox7.BackColor = Color.White;
                    checkBox7.Enabled = false;
                }
                else if (checkBox1.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox8.Checked = false;
                    checkBox8.BackColor = Color.White;
                    checkBox8.Enabled = false;
                }
                else if (checkBox9.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox9.Checked = false;
                    checkBox9.BackColor = Color.White;
                    checkBox9.Enabled = false;
                }
                else if (checkBox10.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox10.Checked = false;
                    checkBox10.BackColor = Color.White;
                    checkBox10.Enabled = false;
                }
                else if (checkBox11.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox11.Checked = false;
                    checkBox11.BackColor = Color.White;
                    checkBox11.Enabled = false;
                }
                else if (checkBox12.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox12.Checked = false;
                    checkBox12.BackColor = Color.White;
                    checkBox12.Enabled = false;
                }
                else if (checkBox13.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox13.Checked = false;
                    checkBox13.BackColor = Color.White;
                    checkBox13.Enabled = false;
                }
                else if (checkBox14.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox14.Checked = false;
                    checkBox14.BackColor = Color.White;
                    checkBox14.Enabled = false;
                }
                else if (checkBox15.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox15.Checked = false;
                    checkBox15.BackColor = Color.White;
                    checkBox15.Enabled = false;
                }
            }
            goruntuleme = new string[100];
            dizi = 0;
            sayfa.Show();
            this.Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            kontrol = true;
            if (uye.online == true)
            {
                isim = uye.suanki_kullanici;
            }
            int satir = Form5.sayac;
            for (int i = 0; i < satir; i++)
            {
                string tablo_saat = Form1.personelAnasayfa.saat(i);
                string tablo_masa = Form1.personelAnasayfa.masa(i);
                string tablo_ad = Form1.personelAnasayfa.name(i);
                if (checkBox1.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox1.BackColor = Color.Red;
                    checkBox1.Enabled = true;
                    goruntuleme[dizi] = "checkBox1";
                    dizi++;
                }
                else if (checkBox2.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox2.BackColor = Color.Red;
                    checkBox2.Enabled = true;
                    goruntuleme[dizi] = "checkBox2";
                    dizi++;
                }
                else if (checkBox3.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox3.BackColor = Color.Red;
                    checkBox3.Enabled = true;
                    goruntuleme[dizi] = "checkBox3";
                    dizi++;
                }
                else if (checkBox4.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox4.BackColor = Color.Red;
                    checkBox4.Enabled = true;
                    goruntuleme[dizi] = "checkBox4";
                    dizi++;
                }
                else if (checkBox5.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox5.BackColor = Color.Red;
                    checkBox5.Enabled = true;
                    goruntuleme[dizi] = "checkBox5";
                    dizi++;
                }
                else if (checkBox6.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox6.BackColor = Color.Red;
                    checkBox6.Enabled = true;
                    goruntuleme[dizi] = "checkBox6";
                    dizi++;
                }
                else if (checkBox7.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox7.BackColor = Color.Red;
                    checkBox7.Enabled = true;
                    goruntuleme[dizi] = "checkBox7";
                    dizi++;
                }
                else if (checkBox1.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox8.BackColor = Color.Red;
                    checkBox8.Enabled = true;
                    goruntuleme[dizi] = "checkBox8";
                    dizi++;
                }
                else if (checkBox9.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox9.BackColor = Color.Red;
                    checkBox9.Enabled = true;
                    goruntuleme[dizi] = "checkBox9";
                    dizi++;
                }
                else if (checkBox10.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox10.BackColor = Color.Red;
                    checkBox10.Enabled = true;
                    goruntuleme[dizi] = "checkBox10";
                    dizi++;
                }
                else if (checkBox11.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox11.BackColor = Color.Red;
                    checkBox11.Enabled = true;
                    goruntuleme[dizi] = "checkBox11";
                    dizi++;
                }
                else if (checkBox12.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox12.BackColor = Color.Red;
                    checkBox12.Enabled = true;
                    goruntuleme[dizi] = "checkBox12";
                    dizi++;
                }
                else if (checkBox13.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox13.BackColor = Color.Red;
                    checkBox13.Enabled = true;
                    goruntuleme[dizi] = "checkBox13";
                    dizi++;
                }
                else if (checkBox14.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox14.BackColor = Color.Red;
                    checkBox14.Enabled = true;
                    goruntuleme[dizi] = "checkBox14";
                    dizi++;
                }
                else if (checkBox15.Text == tablo_saat && tablo_masa == masano && tablo_ad == isim)
                {
                    checkBox15.BackColor = Color.Red;
                    checkBox15.Enabled = true;
                    goruntuleme[dizi] = "checkBox15";
                    dizi++;
                }
            }
        }
    }
}
