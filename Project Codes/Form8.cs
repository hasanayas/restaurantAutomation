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
    public partial class Form8 : Form
    {
        //private static personeler yeniPer = new personeler();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            btn_geri.Text = "GERİ";
            btn_geri.Location = new Point(1200, 600);
            ad.BackColor = Color.Transparent;
            soyad.BackColor = Color.Transparent;
            personelNo.BackColor = Color.Transparent;
            mailAdresi.BackColor = Color.Transparent;
            personelParola.BackColor = Color.Transparent;
            parolaTekrari.BackColor = Color.Transparent;
            sorular.BackColor = Color.Transparent;
            guvenlikCevabi.BackColor = Color.Transparent;
            personelCinsiyet.BackColor = Color.Transparent;
            girisNo.BackColor = Color.Transparent;
            girisParola.BackColor = Color.Transparent;
            erkek.BackColor = Color.Transparent;
            kadin.BackColor = Color.Transparent;

            ad.Location = new Point(600, 200);
            ad.Size = new Size(31, 20);
            soyad.Location = new Point(600, 230);
            soyad.Size = new Size(59, 20);
            personelNo.Location = new Point(600, 260);
            personelNo.Size = new Size(106, 20);
            mailAdresi.Location = new Point(600, 290);
            mailAdresi.Size = new Size(70, 20);
            personelParola.Location = new Point(600, 320);
            personelParola.Size = new Size(47, 20);
            parolaTekrari.Location = new Point(600, 350);
            parolaTekrari.Size = new Size(145, 20);
            sorular.Location = new Point(600, 380);
            sorular.Size = new Size(140, 20);
            guvenlikCevabi.Location = new Point(600, 410);
            guvenlikCevabi.Size = new Size(55, 20);
            personelCinsiyet.Location = new Point(600, 440);
            personelCinsiyet.Size = new Size(72, 20);
            girisNo.Location = new Point(770, 40);
            girisNo.Size = new Size(93, 20);
            girisParola.Location = new Point(1050, 40);
            girisParola.Size = new Size(42, 20);

            isim.Location = new Point(750, 190);
            isim.Size = new Size(190, 20);
            soyisim.Location = new Point(750, 220);
            soyisim.Size = new Size(190, 20);
            personel.Location = new Point(750, 250);
            personel.Size = new Size(190, 20);
            email.Location = new Point(750, 280);
            email.Size = new Size(190, 20);
            parolasi.Location = new Point(750, 310);
            parolasi.Size = new Size(190, 20);
            tekrari.Location = new Point(750, 340);
            tekrari.Size = new Size(190, 20);
            cevabi.Location = new Point(750, 400);
            cevabi.Size = new Size(190, 20);
            girisPersonel.Location = new Point(910, 40);
            girisPersonel.Size = new Size(129, 20);
            girisParolasi.Location = new Point(1107, 40);
            girisParolasi.Size = new Size(129, 20);
            guvenlikSorulari.Location = new Point(750, 370);
            guvenlikSorulari.Size = new Size(190, 20);
            erkek.Location = new Point(750, 440);
            erkek.Size = new Size(61, 20);
            kadin.Location = new Point(850, 440);
            kadin.Size = new Size(60, 20);
            btn_kayit.Location = new Point(750, 470);
            btn_kayit.Size = new Size(190, 30);
            btn_giris.Location = new Point(1252, 40);
            btn_giris.Size = new Size(87, 22);
            ad.Text = "AD";
            soyad.Text = "SOYAD";
            personelNo.Text = "PERSONEL NUMARASİ";
            mailAdresi.Text = "MAİL ADRESİ";
            personelParola.Text = "PERSONEL PAROLA";
            parolaTekrari.Text = "PAROLA TEKRARI";
            sorular.Text = "SORULAR";
            guvenlikCevabi.Text = "CEVAP";
            personelCinsiyet.Text = "CİNSİYET";
            girisNo.Text = "PERSONEL NUMARASİ";
            girisParola.Text = "PAROLA";
            btn_giris.Text = "GİRİŞ YAP";
            btn_kayit.Text = "KAYIT OL";
            erkek.Text = "ERKEK";
            kadin.Text = "KADIN";
            WindowState = FormWindowState.Maximized;

            guvenlikSorulari.Text = "Güvenlik Soruları";
            guvenlikSorulari.Items.Add("Favori Renginiz Nedir?");
            guvenlikSorulari.Items.Add("Evcil Hayvanınızın Adı Nedir?");
            guvenlikSorulari.Items.Add("Favori Filmizin Hangisidir?");
            guvenlikSorulari.Items.Add("Favori Şarkınız Nedir?");
            guvenlikSorulari.Items.Add("Favori Kitabınızın Adı Nedir?");
            guvenlikSorulari.Items.Add("Hangi Ülkeye Gitmek İstersiniz?");
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            string ad = isim.Text;
            string soyad = soyisim.Text;
            string no = personel.Text;
            string mail = email.Text;
            string parola = parolasi.Text;
            string guvenlik = guvenlikSorulari.Text;
            string cevap = cevabi.Text;

            if (erkek.Checked == true)
            {
                string cinsiyet = "Erkek";
                Personel yeniPersonel = new Personel(ad, soyad, mail, no, parola, guvenlik, cevap, cinsiyet);
                yeniPersonel.box();
                Form4.anasayfa.perkay(ad, soyad, mail, no, parola, guvenlik, cevap, cinsiyet);
            }
            else
            {
                string cinsiyet = "Kadın";
                Personel yeniPersonel = new Personel(ad, soyad, mail, no, parola, guvenlik, cevap, cinsiyet);
                yeniPersonel.box();
                Form4.anasayfa.perkay(ad, soyad, mail, no, parola, guvenlik, cevap, cinsiyet);
            }
            isim.Text = "";
            soyisim.Text = "";
            personel.Text = "";
            email.Text = "";
            parolasi.Text = "";
            tekrari.Text = "";
            cevabi.Text = "";
            girisPersonel.Text = "";
            girisParolasi.Text = "";
            guvenlikSorulari.Text = "";
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string no = girisPersonel.Text;
            string sifre = girisParolasi.Text;
            if (Form4.anasayfa.pergir(no, sifre))
            {
                Form1.personelAnasayfa.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Personel Numarasını veya Sifreyi Yanlis Girdiniz");
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form4.anasayfa.Show();
            this.Hide();
        }
    }
}
