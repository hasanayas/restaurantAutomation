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
    public partial class Form1 : Form
    {
        uye yeniUye = new uye();
        personeler yeniPer = new personeler();
        public static Form8 personelKayit = new Form8();
        public static Form5 personelAnasayfa = new Form5();
        public static Form4 masasec = new Form4();
        public static Form2 sifremiunuttum = new Form2();
        public static Form3 sifremidegis = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ad.BackColor = Color.Transparent;
            soyad.BackColor = Color.Transparent;
            kullaniciAdi.BackColor = Color.Transparent;
            mailAdresi.BackColor = Color.Transparent;
            kullaniciParola.BackColor = Color.Transparent;
            parolaTekrari.BackColor = Color.Transparent;
            sorular.BackColor = Color.Transparent;
            guvenlikCevabi.BackColor = Color.Transparent;
            kullaniciCinsiyet.BackColor = Color.Transparent;
            girisAdi.BackColor = Color.Transparent;
            girisParola.BackColor = Color.Transparent;
            erkek.BackColor = Color.Transparent;
            kadin.BackColor = Color.Transparent;

            ad.Location = new Point(600, 200);
            ad.Size = new Size(31, 20);
            soyad.Location = new Point(600, 230);
            soyad.Size = new Size(59, 20);
            kullaniciAdi.Location = new Point(600, 260);
            kullaniciAdi.Size = new Size(106, 20);
            mailAdresi.Location = new Point(600, 290);
            mailAdresi.Size = new Size(70, 20);
            kullaniciParola.Location = new Point(600, 320);
            kullaniciParola.Size = new Size(47, 20);
            parolaTekrari.Location = new Point(600, 350);
            parolaTekrari.Size = new Size(145, 20);
            sorular.Location = new Point(600, 380);
            sorular.Size = new Size(140, 20);
            guvenlikCevabi.Location = new Point(600, 410);
            guvenlikCevabi.Size = new Size(55, 20);
            kullaniciCinsiyet.Location = new Point(600, 440);
            kullaniciCinsiyet.Size = new Size(72, 20);
            girisAdi.Location = new Point(815, 40);
            girisAdi.Size = new Size(93, 20);
            girisParola.Location = new Point(1050, 40);
            girisParola.Size = new Size(42, 20);

            isim.Location = new Point(750, 190);
            isim.Size = new Size(190, 20);
            soyisim.Location = new Point(750, 220);
            soyisim.Size = new Size(190, 20);
            kullanici.Location = new Point(750, 250);
            kullanici.Size = new Size(190, 20);
            email.Location = new Point(750, 280);
            email.Size = new Size(190, 20);
            parolasi.Location = new Point(750, 310);
            parolasi.Size = new Size(190, 20);
            tekrari.Location = new Point(750, 340);
            tekrari.Size = new Size(190, 20);         
            cevabi.Location = new Point(750, 400);
            cevabi.Size = new Size(190, 20);
            girisKullanici.Location = new Point(910, 40);
            girisKullanici.Size = new Size(129, 20);
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
            kullaniciAdi.Text = "KULLANICI ADI";
            mailAdresi.Text = "MAİL ADRESİ";
            kullaniciParola.Text = "KULLANICI PAROLA";
            parolaTekrari.Text = "PAROLA TEKRARI";
            sorular.Text = "SORULAR";
            guvenlikCevabi.Text = "CEVAP";
            kullaniciCinsiyet.Text = "CİNSİYET";
            girisAdi.Text = "KULLANICI ADI";
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
            string kullaniciadi = kullanici.Text;
            string mail = email.Text;
            string parola = parolasi.Text;
            string guvenlik = guvenlikSorulari.Text;
            string cevap = cevabi.Text;

            if (erkek.Checked == true)
            {
                string cinsiyet = "Erkek";
                Kullanici yeniKullanici = new Kullanici(ad, soyad, mail, kullaniciadi, parola, guvenlik, cevap, cinsiyet);
                yeniKullanici.box();
                yeniUye.kayit(ad, soyad, mail, kullaniciadi, parola, guvenlik, cevap, cinsiyet); 
            }
            else
            {
                string cinsiyet = "Kadın";
                Kullanici yeniKullanici = new Kullanici(ad, soyad, mail, kullaniciadi, parola, guvenlik, cevap, cinsiyet);
                yeniKullanici.box();
                yeniUye.kayit(ad, soyad, mail, kullaniciadi, parola, guvenlik, cevap, cinsiyet); 
            }
            isim.Text = "";
            soyisim.Text = "";
            kullanici.Text = "";
            email.Text = "";
            parolasi.Text = "";
            tekrari.Text = "";
            cevabi.Text = "";
            girisKullanici.Text = "";
            girisParolasi.Text = "";
            guvenlikSorulari.Text = "";
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = girisKullanici.Text;
            string sifre = girisParolasi.Text;
            if (yeniUye.giris(kullaniciadi, sifre))
            {
                masasec.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanici Adini veya Sifreyi Yanlis Girdiniz");
        }

        private void şifremiUnuttumToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 sifremiunuttum = new Form2();
           sifremiunuttum.Show();
        }

        private void şifremiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form3 sifremidegis = new Form3();
           sifremidegis.Show();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelKayit.Show();
            this.Hide();
        }
        public void sifunut(string kullaniciAd,string guvenlikSoru,string cevabi)
        {
            yeniUye.sifremiUnuttum(kullaniciAd, guvenlikSoru, cevabi);
        }
        public void sifdeg(string kullanici_adi, string parola, string guvenlikSoru, string cevap, string yeni)
        {
            yeniUye.sifreDegis(kullanici_adi, parola, guvenlikSoru,cevap,yeni);
            MessageBox.Show("Parolanız Başarıyla Değiştirilmiştir.");
        }
        public void persifunut(string personel_no, string guvenlikSoru, string cevabi)
        {
            yeniPer.sifremiUnuttum(personel_no, guvenlikSoru, cevabi);
        }
        public void persifdeg(string personel_no, string parola, string guvenlikSoru, string cevap, string yeni)
        {
            yeniPer.sifreDegis(personel_no, parola, guvenlikSoru, cevap, yeni);
            MessageBox.Show("Parolanız Başarıyla Değiştirilmiştir.");
        }
        public bool pergir(string personel_no, string parola)
        {
            if (yeniPer.giris(personel_no, parola))
            {
                return true;
            }
            else
                return false;
        }
        public void perkay(string isim, string soyisim, string email, string personelNo, string parolasi, string guvenlikSorusu, string cevabi, string cinsiyeti)
        {
            yeniPer.kayit(isim, soyisim, email, personelNo, parolasi, guvenlikSorusu, cevabi, cinsiyeti);
        }
    }
}
