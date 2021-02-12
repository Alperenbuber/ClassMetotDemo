using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Coorparate
    // :Musteri yaptık yani oda müşteri olduğunu gösterdik bu olaya miras yada inheritance deriz.
    //Musterinin icindeki olan tüm özellikler TuzelMusteri de var kabul ederiz.
    //TuzelMusteri miras alır Musteriden.
    
    class TuzelMusteri :Musteri
    {
 
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
