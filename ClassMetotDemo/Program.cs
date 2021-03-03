using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 78956;
            musteri1.isim = "Uğur Delikanlıoğlu";
            musteri1.yas = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 62756;
            musteri2.isim = "Metin Koca";
            musteri2.yas = 22;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 25456;
            musteri3.isim = "Ahmet Koca";
            musteri3.yas = 23;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 55443;
            musteri4.isim = "Umut Naneci";
            musteri4.yas = 24;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.isim);
                Console.WriteLine(musteri.yas);
                Console.WriteLine("--------------------------");
            }

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Musteri_Ekle(musteri1);

            Console.WriteLine("--------------------------");
            musterimanager.Musteri_Sil(musteri3);
            Console.WriteLine("--------------------------");

            musterimanager.Musteri_Listele(musteri2);

        }
    }
}
