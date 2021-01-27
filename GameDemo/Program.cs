using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu {Ad="Ali", Soyad="GEL" };
            Urun urun1 = new Urun {OyunAdi="PES 2021", OyunTipi="e-spor" };
           
            OyuncuManager oyuncuManager = new OyuncuManager();
            oyuncuManager.Add(oyuncu1);

            SatisManager satisManager = new SatisManager();
            satisManager.Satis(urun1, oyuncu1);

            Kampanya kampanya1 = new Kampanya {KampanyaAdi= "Hoşgeldin Kampanyası", IndirimOrani=5 };
  
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Add(kampanya1);
                     

        }
    }
}
