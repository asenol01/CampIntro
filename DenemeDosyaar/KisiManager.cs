using System;
using System.Collections.Generic;
using System.Text;

namespace DenemeInterface
{
    class KisiManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " isimli kişi eklendi. Adresi: ");
        }
    }
}
