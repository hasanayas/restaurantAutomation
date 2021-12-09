using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje
{
    abstract class kayitOlmak
    {
        public abstract void kayit(string isim, string soyisim, string email, string kullanciAdi, string parolasi, string guvenlikSorusu, string cevabi, string cinsiyeti);
        public abstract bool giris(string kullanici_adi, string parola);
        public abstract void cikis();
        public abstract bool sifreDegis(string kullanici_adi, string parola, string guvenlikSoru, string cevap, string yeni);
        public abstract void sifremiUnuttum(string kullanici_adi, string guvenlikSoru, string cevap);
    }
    class uye : kayitOlmak
    {
        public static int sayac=0;
        List<string> uyeler = new List<string>();
        public static string suanki_kullanici;
        public static bool online;
        public static bool kontrol;
        public static bool dogru;
        public override void kayit(string isim, string soyisim, string email, string kullaniciAdi, string parolasi, string guvenlikSorusu, string cevabi, string cinsiyeti)
        {
            uyeler.Add(isim);
            uyeler.Add(soyisim);
            uyeler.Add(email);
            uyeler.Add(kullaniciAdi);
            uyeler.Add(parolasi);
            uyeler.Add(guvenlikSorusu);
            uyeler.Add(cevabi);
            uyeler.Add(cinsiyeti);
            sayac++;
   
        }
        public override void cikis()
        {
            online = false;
            suanki_kullanici = null;
        }
        public override bool giris(string kullanici_adi, string parola)
        {
            try
            {
                for (int i = 3; i < sayac * 8; i += 8)
                {
                    if (uyeler[i] == kullanici_adi && uyeler[i + 1] == parola)
                    {
                        suanki_kullanici = kullanici_adi;
                        online = true;
                        dogru = true;
                        break;
                    }
                }
                if (online == true && dogru == true)
                    return true;
                else
                    return false;
            }
            catch(Exception)
            {
                return false;
            }
           
        } 
        public override bool sifreDegis(string kullanici_adi,string parola,string guvenlikSoru,string cevap,string yeni)
        {
            try
            {
                for (int i = 3; i < sayac * 8; i += 8)
                {
                    if (uyeler[i] == kullanici_adi && uyeler[i + 1] == parola && uyeler[i+2] == guvenlikSoru && uyeler[i+3] == cevap)
                    {
                        uyeler[i + 1] = yeni;
                        kontrol = true;
                    }
                }
                if (kontrol == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override void sifremiUnuttum(string kullanici_adi,string guvenlikSoru, string cevap)
        {
            try
            {
                for (int i = 3; i < sayac * 8; i += 8)
                {
                    if (uyeler[i] == kullanici_adi && uyeler[i + 2] == guvenlikSoru && uyeler[i + 3] == cevap)
                    {
                        MessageBox.Show(uyeler[i + 1]);
                    }
                }
            }
            catch (Exception)
            {

            }
}
    }
    class personeler : kayitOlmak
    {
        public static int persayac=0;
        List<string> personeller = new List<string>();
        public bool online;
        public bool dogru;
        public bool kontrol;
        public static string suanki_personel;
        public override void kayit(string isim, string soyisim, string email, string personelNo, string parolasi, string guvenlikSorusu, string cevabi, string cinsiyeti)
        {
            personeller.Add(isim);
            personeller.Add(soyisim);
            personeller.Add(email);
            personeller.Add(personelNo);
            personeller.Add(parolasi);
            personeller.Add(guvenlikSorusu);
            personeller.Add(cevabi);
            personeller.Add(cinsiyeti);
            persayac++;

        }
        public override void cikis()
        {
            online = false;
            suanki_personel = null;
        }
        public override bool giris(string personel_no, string parola)
        {
            try
            {
                for (int i = 3; i < persayac * 8; i += 8)
                {
                    if (personeller[i] == personel_no && personeller[i + 1] == parola)
                    {
                        online = true;
                        dogru = true;
                        break;
                    }
                }
                if (online == true && dogru == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public override bool sifreDegis(string personelNo, string parola, string guvenlikSoru, string cevap, string yeni)
        {
            try
            {
                for (int i = 3; i < persayac * 8; i += 8)
                {
                    if (personeller[i] == personelNo && personeller[i + 1] == parola && personeller[i + 2] == guvenlikSoru && personeller[i + 3] == cevap)
                    {
                        personeller[i + 1] = yeni;
                        kontrol = true;
                    }
                }
                if (kontrol == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override void sifremiUnuttum(string personelNo, string guvenlikSoru, string cevap)
        {
            try
            {
                for (int i = 3; i < persayac * 8; i += 8)
                {
                    if (personeller[i] == personelNo && personeller[i + 2] == guvenlikSoru && personeller[i + 3] == cevap)
                    {
                        MessageBox.Show(personeller[i + 1]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Bilgiler");
            }
        }
    }
}
