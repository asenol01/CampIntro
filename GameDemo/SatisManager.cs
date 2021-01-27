using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class SatisManager
    {
        public void Satis(Urun urun, Oyuncu oyuncu)
        {
            Console.WriteLine(urun.OyunAdi + " adlı oyun " + oyuncu.Ad + " " + oyuncu.Soyad+ " adlı oyuncuya satıldı.");
        }
    }
}
