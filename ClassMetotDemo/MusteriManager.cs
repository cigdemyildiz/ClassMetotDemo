using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.MusteriId + " Müşteri Adı: "+ musteri.MusteriAd+ " Müşteri Soyad: "+musteri.MusteriSoyad);

        }
        public void Display(Musteri[] musteriler)
        {

            foreach (var musteri in musteriler)
            { 
            Console.WriteLine("Müşteri Tc: " + musteri.MusteriTc + " Müşteri Adı: " + musteri.MusteriAd + " Müşteri Soyad: " + musteri.MusteriSoyad);

            }
        }
        public void Update(Musteri musteri)
        {
            musteri.MusteriAd = "Mehmet";
            Console.WriteLine("Müşteri Tc: " + musteri.MusteriTc + " Müşteri Adı: " + musteri.MusteriAd + " Müşteri Soyad: " + musteri.MusteriSoyad);
        }
        public void Delete(Musteri musteri)
        {
            GC.SuppressFinalize(musteri);
        }
    }
}
