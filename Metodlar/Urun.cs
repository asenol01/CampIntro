using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun
    {
        //property: bu menu prop tab tab ile çıkar
        //encapsulation için uygundur

        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }
    }
}