using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Musteri Takip Simulasyonu");
            Musteri musteri1 = new Musteri();
            musteri1.Id = "000001";
            musteri1.Name = "Goktug";
            musteri1.LastName = "Gunce";
            musteri1.Money = 105214.5;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "000002";
            musteri2.Name = "Hayat";
            musteri2.LastName = "Dost";
            musteri2.Money = 250150;

            Musteri musteri3 = new Musteri();
            musteri3.Id = "000003";
            musteri3.Name = "Mete";
            musteri3.LastName = "Pekesni";
            musteri3.Money = 150;

           Musteri[] musteriler = new Musteri[100];


            MusteriManager musterimanage = new MusteriManager();
            musterimanage.MusteriEkle(musteri1);
            musterimanage.MusteriEkle(musteri2);
            musterimanage.MusteriEkle(musteri3);
            musterimanage.MusteriListele();

            Console.WriteLine("Silme işlemi yapılıyor");
            musterimanage.MusteriSil(musteri2);
            musterimanage.MusteriListele();

            Console.ReadLine();



        }
    }
}
