using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    interface Sonuc
    {
        double fiyat
        {
            get;
            set;
        }
        double adet
        {
            get;
            set;
        }
        double toplamFiyat
        {
            get;
        }
    }
    class ToplamSonuc : Sonuc
    {
        public ToplamSonuc(double x, double y)
        {
            fiyat = x;
            adet = y;
        }
        public double fiyat { get; set; }
        public double adet { get; set; }
        public double toplamFiyat =>
          (fiyat * adet);
    }
}
