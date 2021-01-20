using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "GEL";
            musteri1.Yasi = 40;

            Musteri musteri2 = new Musteri();
            musteri1.Id = 2;
            musteri2.Adi = "Veli";
            musteri2.Soyadi = "GIT";
            musteri2.Yasi = 21;

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                musteriManager.Listele(musteri);
                Console.WriteLine("---------------------------");

            }
            
            //musteriManager.Ekle(musteri1);
            //musteriManager.Sil(musteri2);
        }
    }
}
