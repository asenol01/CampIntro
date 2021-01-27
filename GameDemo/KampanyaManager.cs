using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class KampanyaManager
    {
        public void Add(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi+ " adındaki kampanya eklendi. İndirim Oranı: %" + kampanya.IndirimOrani);
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " adındaki kampanya güncellendi. Yeni İndirim Oranı: %" + kampanya.IndirimOrani);
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " adındaki kampanya silindi.");
        }
    }
}
