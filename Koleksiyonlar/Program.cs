using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ali","murta", "kerem", "halil"};
            //Console.WriteLine(isimler[0]); // Bu yöntemde araya ekleme yapma zor ve sona da. Bunun yerine List kullanılacak
           
            // ctrl+k ctrl+c    ya da ctrl+k ctrl+u
            //List bir sınıftır. İlk yazınca solda çıkan ampule tıklanır ve System.Collections.Generic otomatik eklenir.

            List<string> isimler2 = new List<string> { "ali", "murta", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("veli");

            Console.WriteLine(isimler2[4]);
        }
    }
}
