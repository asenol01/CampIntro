using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe
            foreach (Urun urun in urunler) //Urun yerine var da yazabilirsin. o otomatik bulur
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");


            }

            Console.WriteLine("------------Metotlar------------");
            //cw tab tab -- console writeline için kısayol
            //instance oluşturmak
            //encapsulation: kapsülleme demek. ayrı ayrı yazıp düzensiz yazmaktansa bir kapsülün içine sokarız. property yöntemiyle yazılmış calsslar buna yardımcı olur

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //argumenet ekledik
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 3);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);






        }
    }
}


//dont repeat yourself - DRY -Clean Code - Best Practice