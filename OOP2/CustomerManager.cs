using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // iş sınıflarıdır. -- Business classes
    class CustomerManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşterimiz başarıyla eklenmiştir: "  +  musteri.MusteriNo);
        }  
        public void Uptaded(GercekMusteri musteri)
        {
            Console.WriteLine("Gerçek müşterimiz başarıyla güncellenmiştir."+ musteri.Adi);
        }
    }
}
