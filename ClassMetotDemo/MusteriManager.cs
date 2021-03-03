using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Musteri_Listele(Musteri musteri)
        {
            Console.WriteLine("Müsteri Listelendi"+ " "+musteri.Id+  ":"+musteri.isim);

        }
        public void Musteri_Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi" + " " + musteri.Id + ":" + musteri.isim);
        }
        public void Musteri_Sil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi" + " " + musteri.Id + ":" + musteri.isim);
        }
    }
}
