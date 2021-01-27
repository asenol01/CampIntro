using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class OyuncuManager
    {
        public void Add(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu sisteme kayıt edildi : " + oyuncu.Ad + " " + oyuncu.Soyad);
        }
        
        public void Update(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi : " + oyuncu.Ad + " " + oyuncu.Soyad);
        }

        public void Delete(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu sistemden silindi : " + oyuncu.Ad + " " + oyuncu.Soyad);
        }
    }
}
