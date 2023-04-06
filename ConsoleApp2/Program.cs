using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /* Bir öğrencinin, numarası, isim, soyisim, vize1, vize2, final ve okul isimlerini tutan değişkenler olacak. Erişim
        *belirliyicileri private olacak. Yapıcı metotlar ile değişkenlere değer ataması yapılacak. Öğrencinin ortalamasını
        *hesaplayan bir metot olacak. Öğrencinin ortalaması 50’nin altında ise ekrana “Kaldı” yazdıran bir metot olacak.
        *Öğrenci bilgilerini ekrana yazdıran bir metot olacak.
        *OgrenciBilgileriGoster()
        *ogrenciOrtalamasi()
        *okulGetir()
        *Öğrenci Bilgilerini Göster
        *Öğrenci Ortalaması
        *Okul Getir
        *Çıkış Yap */
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(21, "Taha", "Çiçek", "ADÜ", 70, 65, 92);

            Console.WriteLine("Uygulamaya hoşgeldiniz.. Yapmak istediğiniz işlemi seçiniz.");
            bool kontrol = true;

            while (kontrol)
            {
                IslemSecimi();
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 0: Console.WriteLine("Yanlış bir seçim yaptınız. Lütfen tekrar deneyiniz."); break;
                    case 1: ogrenci1.OgrenciBilgileriGoster(); break;
                    case 2: Console.WriteLine("Öğrencinin ortalaması: " + ogrenci1.OgrenciOrtalamasi()); break;
                    case 3: ogrenci1.OkulGetir(); break;
                    case 4: Console.WriteLine("Çıkış yapılıyor..."); kontrol = false; break;
                    default: Console.WriteLine("Yanlış bir seçim yaptınız. Lütfen tekrar deneyiniz."); break;
                }
            }
        }

        static void IslemSecimi()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrenci Ortalaması");
            Console.WriteLine("3- Okul Getir");
            Console.WriteLine("4- Çıkış Yap");
        }   
    }
}
