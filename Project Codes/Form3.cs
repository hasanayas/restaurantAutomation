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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            kullaniciGuvenlik.Items.Add("Favori Renginiz Nedir?");
            kullaniciGuvenlik.Items.Add("Evcil Hayvanınızın Adı Nedir?");
            kullaniciGuvenlik.Items.Add("Favori Filmizin Hangisidir?");
            kullaniciGuvenlik.Items.Add("Favori Şarkınız Nedir?");
            kullaniciGuvenlik.Items.Add("Favori Kitabınızın Adı Nedir?");
            kullaniciGuvenlik.Items.Add("Hangi Ülkeye Gitmek İstersiniz?");
            
            personelGuvenlik.Items.Add("Favori Renginiz Nedir?");
            personelGuvenlik.Items.Add("Evcil Hayvanınızın Adı Nedir?");
            personelGuvenlik.Items.Add("Favori Filmizin Hangisidir?");
            personelGuvenlik.Items.Add("Favori Şarkınız Nedir?");
            personelGuvenlik.Items.Add("Favori Kitabınızın Adı Nedir?");
            personelGuvenlik.Items.Add("Hangi Ülkeye Gitmek İstersiniz?");

            kullaniciAdi.Text = "Kullanıcı Adı";
            kullaniciParola.Text = "Parola";
            kullaniciCevap.Text = "Cevap";
            kullaniciYeni.Text = "Yeni Parola";
            personelNo.Text = "Personel Numarası";
            personelParola.Text = "Parola";
            personelCevap.Text = "Cevap";
            personelYeni.Text = "Yeni Parola";

            kullaniciGuvenlik.Text = "Güvenlik Sorusu";
            personelGuvenlik.Text = "Güvenlik Sorusu";

            txt_kullanici.Size = new Size(56, 40);
            txt_kullanici.Location = new Point(110, 10);
            txt_kullanici.BackColor = Color.FromArgb(255,224,192); 
            txt_kullanici.Text = "KULLANICI";
            
            txt_personel.Size = new Size(56, 40);
            txt_personel.Location = new Point(570, 10);
            txt_personel.BackColor = Color.FromArgb(255, 224, 192);
            txt_personel.Text = "PERSONEL";
            
            kullaniciAdi.Size = new Size(137, 22);
            kullaniciAdi.Location = new Point(71, 59);

            kullaniciParola.Size = new Size(137, 22);
            kullaniciParola.Location = new Point(71, 114);

            kullaniciGuvenlik.Location = new Point(71, 164);
            kullaniciGuvenlik.Size = new Size(137, 22);

            personelGuvenlik.Location = new Point(550, 164);
            personelGuvenlik.Size = new Size(137, 22);

            kullaniciCevap.Size = new Size(137, 22);
            kullaniciCevap.Location = new Point(71, 222);

            kullaniciYeni.Size = new Size(137, 22);
            kullaniciYeni.Location = new Point(71, 276);

            personelNo.Size = new Size(137, 22);
            personelNo.Location = new Point(550, 59);

            personelParola.Size = new Size(137, 22);
            personelParola.Location = new Point(550, 114);

            personelCevap.Size = new Size(137, 22);
            personelCevap.Location = new Point(550, 222);

            personelYeni.Size = new Size(137, 22);
            personelYeni.Location = new Point(550, 276);

            kullaniciTamam.Location = new Point(71, 314);
            kullaniciTamam.Size = new Size(137, 22);

            personelTamam.Location = new Point(550, 314);
            personelTamam.Size = new Size(137, 22);

            kullaniciTamam.Text = "TAMAM";
            personelTamam.Text = "TAMAM";
        }

        private void kullaniciTamam_Click(object sender, EventArgs e)
        {
            string kullaniciAd = kullaniciAdi.Text;
            string parola = kullaniciParola.Text;
            string guvenlikSoru = kullaniciGuvenlik.Text;
            string cevabi = kullaniciCevap.Text;
            string yenisifre = kullaniciYeni.Text;
            Form4.anasayfa.sifdeg(kullaniciAd, parola, guvenlikSoru, cevabi, yenisifre);
        }

        private void personelTamam_Click(object sender, EventArgs e)
        {
            string perno = personelNo.Text;
            string parola = personelParola.Text;
            string guvenlikSoru = personelGuvenlik.Text;
            string cevabi = personelCevap.Text;
            string yenisifre = personelYeni.Text;
            Form4.anasayfa.persifdeg(perno, parola, guvenlikSoru, cevabi, yenisifre);
        }
    }
}
