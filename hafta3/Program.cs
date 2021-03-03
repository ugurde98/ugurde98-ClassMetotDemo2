using System;

namespace hafta3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.urunAdi = "telefon";
            urun1.urunFiyat = 1500;
            urun1.urunAciklama = "Akıllı Telefon";

            Urun urun2 = new Urun();
            urun2.urunAdi = "Bilgisayar";
            urun2.urunFiyat = 6000;
            urun2.urunAciklama = "32Gb Ram";

            Urun urun3 = new Urun();
            urun3.urunAdi = "Saat";
            urun3.urunFiyat = 1000;
            urun3.urunAciklama = "Akıllı Saat";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunFiyat);
                Console.WriteLine(urun.urunAciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("-----------İŞLEMLER-------------");
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle();
            
        }
    }
}
