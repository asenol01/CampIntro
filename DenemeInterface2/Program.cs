using System;

namespace DenemeInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKisiYonetimi kisi = new MusteriYonetimi();
            //IKisiYonetimi pers = new PersonelYonetimi();
            //kisi.Ekle();
            //pers.Ekle();

            KisiYonetimi kisiYonetimi = new KisiYonetimi();
            kisiYonetimi.Ekle(new PersonelYonetimi()); kisiYonetimi.Ekle(new MusteriYonetimi());

        }
    }

    interface IKisiYonetimi
    {
        void Ekle(); void Guncelle();
    }
    class MusteriYonetimi : IKisiYonetimi
    {
        public void Ekle()
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Guncelle()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class PersonelYonetimi : IKisiYonetimi
    {
        public void Ekle()
        {
            Console.WriteLine("Personel Eklendi");
        }
        public void Guncelle()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class KisiYonetimi
    {
        public void Ekle(IKisiYonetimi kisi)
        {
            kisi.Ekle();
        }
    }
}
