using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ogrenci
    {
        private int numara;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okul;

        public Ogrenci(int _ogrno, string _isim, string _soyisim, string _okul, int _final, int _vize1, int _vize2)
        {
            numara = _ogrno;
            isim = _isim;
            soyisim = _soyisim;
            this.okul = _okul;
            this.final = _final;
            this.vize1 = _vize1;
            this.vize2 = _vize2;
            this.final = _final;
        }
        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası: " + numara);
            Console.WriteLine("Öğrenci İsmi: " + isim);
            Console.WriteLine("Öğrenci Soyismi: " + soyisim);
            Console.WriteLine("Öğrenci Vize 1: " + vize1);
            Console.WriteLine("Öğrenci Vize 2: " + vize2);
            Console.WriteLine("Öğrenci Final: " + final);
            Console.WriteLine("Öğrenci Okul: " + okul);
        }

        public double OgrenciOrtalamasi()
        {
            double ortalama = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
            return ortalama;
        }

        public void OkulGetir()
        {
            Console.WriteLine("Öğrencinin Okul İsmi: " + okul);
        }
    }
}
