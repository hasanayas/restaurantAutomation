using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public class Birey
    {
        static public string ad;
        static public string soyad;
        static public string mail;
        static public string parola;
        static public string guvenlikSoru;
        static public string cevap;
        static public string cinsiyet;
        public Birey(string isim, string soyisim, string email, string parolasi, string soru, string cevabi, string cinsiyeti)
        {
            ad = isim;
            soyad = soyisim;
            parola = parolasi;
            mail = email;
            guvenlikSoru = soru;
            cevap = cevabi;
            cinsiyet = cinsiyeti;
        
        }
        public string Isim
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string soyIsim
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string eMail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
        public string birParola
        {
            get
            {
                return parola;
            }
            set
            {
                parola = value;
            }
        }
        public string birSoru
        {
            get
            {
                return guvenlikSoru;
            }
            set
            {
                guvenlikSoru = value;
            }
        }
        public string birCinsiyet
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
        public string birCevabi
        {
            get
            {
                return cevap;
            }
            set
            {
                cevap = value;
            }
        }
        public virtual void box()
        {

        }
    }
    public class Kullanici : Birey
    {
        static public string kullanici_adi;

        public Kullanici(string isim, string soyisim, string email, string kullanciAdi, string parolasi, string guvenlikSorusu, string cevabi, string cinsiyeti) : base(isim, soyisim, email, parolasi, guvenlikSorusu, cevabi, cinsiyeti)
        {
            kullanici_adi = kullanciAdi;

        }
        public string kullaniciadi
        {
            get
            {
                return kullanici_adi;
            }
            set
            {
                kullanici_adi = value;
            }
        }
        public override void box()
        {
            MessageBox.Show("Kullanici Olusturuldu.");
        }
    }
    public class Personel : Birey
    {
        static public string no;

        public Personel(string personelNo, string isim, string soyisim, string email, string parola, string guvenlikSorusu, string cevabi, string cinsiyeti) : base(isim, soyisim, email, parola, guvenlikSorusu, cevabi, cinsiyeti)
        {
            no = personelNo;
        }
        public string personelNo
        {
            get
            {
                return no;
            }
            set
            {
                no = value;
            }
        }
        public override void box()
        {
            MessageBox.Show("Personel Olusturuldu.");
        }
    }
}
