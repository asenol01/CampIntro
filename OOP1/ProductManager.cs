using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //aynı (string ad) gibi
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        //void: değer döndürmeyen. Emir Kipidir: Git-Yap-Bitir gibi

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        
    }
}
