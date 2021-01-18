using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        Musteri[] musteriDizisi = new Musteri[100];
        int musteriAdet = 0;

        public void MusteriEkle(Musteri musteri)
        {

            musteriDizisi[musteriAdet] = musteri;
            musteriAdet++;


            Console.WriteLine($"{musteri.Name}{musteri.LastName} , müşterilerimiz arasına başarıyla eklenmiştir.");

        }
        public void MusteriSil(Musteri musteri)
        {
            Musteri[] musterilerYeni = new Musteri[100];
            var musteriAdetYeni = 0;

            foreach (var item in musteriDizisi)
            {
                if (item != null && musteri.Id != item.Id)
                {
                    musterilerYeni[musteriAdetYeni] = item;
                    musteriAdetYeni++;
                }
            }

            musteriDizisi = musterilerYeni;
            musteriAdet = musteriAdetYeni;
        }

        public void MusteriListele()
        {
            int counter = 0;

            foreach (var musteri in musteriDizisi)
            {
                Console.WriteLine($"{counter + 1}. müşteri '{musteri.Name}{musteri.LastName} #{musteri.Id}");
                counter++;

                if (counter >= musteriAdet)
                {
                    break;
                }
            }

            
        }


    }
}
