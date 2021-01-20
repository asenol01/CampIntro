using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //syntax
        //namin convention - büyük harfle başla
        public void Ekle(Urun urun) //parametre ekledik
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //bu yöntemle sürekli kendimizi tekrar ederiz çünkü update geldiği zaman program csde hepsini değiştirmek gerekir
                                                                                        //bu yüzden property ile çalışmak daha iyidir.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);


        }

    }
}