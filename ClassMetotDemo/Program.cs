using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriTc = 12345678932;
            musteri1.MusteriAd = "Çiğdem";
            musteri1.MusteriSoyad = "Yıldız";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriTc = 12347658932;
            musteri2.MusteriAd = "Ahmet";
            musteri2.MusteriSoyad = "Yıldırım";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriTc = 32145678932;
            musteri3.MusteriAd = "Zümra";
            musteri3.MusteriSoyad = "Yılmaz";


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-----MÜŞTERİ EKLEME-----");
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            Console.WriteLine("\n");

            Console.WriteLine("-----MÜŞTERİLERİ LİSTELEME-----");
            musteriManager.Display(musteriler);
            Console.WriteLine("\n");

            Console.WriteLine("-----MÜŞTERİ GÜNCELLEME-----");
            musteriManager.Update(musteri2);
            Console.WriteLine("\n");
           
            Console.WriteLine("-----MÜŞTERİ SİLME-----");
            musteriManager.Delete(musteri3);
            Console.WriteLine("Silinen Müşteri Tc: " + musteri3.MusteriTc + " Müşteri Adı: " + musteri3.MusteriAd + " Müşteri Soyad: " + musteri3.MusteriSoyad);



        }
    }
}
