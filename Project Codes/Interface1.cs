using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    interface Hesaplama
    {
        double fiyat
        {
            get;
            set;
        }
        double alinan
        {
            get;
            set;
        }
        double paraustu
        {
            get;
        }
    }
    class Hesap : Hesaplama
    {
        public Hesap(double x, double y)
        {
            fiyat = x;
            alinan = y;
        }
        public double fiyat { get; set; }
        public double alinan { get; set; }
        public double paraustu =>
          (alinan - fiyat);
    }
}
