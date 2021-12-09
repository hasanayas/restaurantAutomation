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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Güvenlik Sorusu";
            comboBox2.Text = "Güvenlik Sorusu";

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;

            label1.Location = new Point(306, 9);
            label1.Size = new Size(130, 33);

            label2.Location = new Point(313, 226);
            label2.Size = new Size(123, 33);
            
            textBox1.Location = new Point(312, 58);
            textBox1.Size = new Size(138, 22);
            textBox1.Text = "Kullanıcı Adı";

            textBox2.Location = new Point(312, 140);
            textBox2.Size = new Size(138, 22);
            textBox2.Text = "Cevap";
            
            textBox3.Location = new Point(312, 279);
            textBox3.Size = new Size(138, 22);
            textBox3.Text = "Personel Numarası";

            textBox4.Location = new Point(312, 370);
            textBox4.Size = new Size(138, 20);
            textBox4.Text = "Cevap";

            comboBox1.Location = new Point(312, 97);
            comboBox1.Size = new Size(138, 24);

            comboBox2.Location = new Point(312, 326);
            comboBox2.Size = new Size(138, 24);

            label1.Text = "KULLANICI";
            label2.Text = "PERSONEL";

            kullaniciSifre.Location = new Point(312, 178);
            kullaniciSifre.Size = new Size(138, 33);
            kullaniciSifre.Text = "Şifreyi Göster";

            personelSifre.Location = new Point(312, 417);
            personelSifre.Size = new Size(138, 33);
            personelSifre.Text = "Şifreyi Göster";

            comboBox1.Items.Add("Favori Renginiz Nedir?");
            comboBox1.Items.Add("Evcil Hayvanınızın Adı Nedir?");
            comboBox1.Items.Add("Favori Filmizin Hangisidir?");
            comboBox1.Items.Add("Favori Şarkınız Nedir?");
            comboBox1.Items.Add("Favori Kitabınızın Adı Nedir?");
            comboBox1.Items.Add("Hangi Ülkeye Gitmek İstersiniz?");

            comboBox2.Items.Add("Favori Renginiz Nedir?");
            comboBox2.Items.Add("Evcil Hayvanınızın Adı Nedir?");
            comboBox2.Items.Add("Favori Filmizin Hangisidir?");
            comboBox2.Items.Add("Favori Şarkınız Nedir?");
            comboBox2.Items.Add("Favori Kitabınızın Adı Nedir?");
            comboBox2.Items.Add("Hangi Ülkeye Gitmek İstersiniz?");
        }

        private void kullaniciSifre_Click(object sender, EventArgs e)
        {
            string kullaniciAd = textBox1.Text;
            string guvenlikSoru = comboBox1.Text;
            string cevabi = textBox2.Text;
            Form4.anasayfa.sifunut(kullaniciAd, guvenlikSoru, cevabi);
        }

        private void personelSifre_Click(object sender, EventArgs e)
        {
            string pesonelNo = textBox3.Text;
            string guvenlikSoru = comboBox2.Text;
            string cevabi = textBox4.Text;
            Form4.anasayfa.persifunut(pesonelNo, guvenlikSoru, cevabi);
        }
    }
}
