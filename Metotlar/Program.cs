using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi1 = "Elma";
            //double fiyati = 15;
            //string aciklama = "Isparta Elması";

            //string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Isparta Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };  //ürün arayı oluşturduk.
            //type-safe ==>tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("----------Metotlar------------");
            //instance-örnek (classı böyle çağırırız)
            //encapsulation==>

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "diyarbakır karpuzu", 13, 23);
        }
    }
}




// Tekrar tekrar kullanılabilirliği sağlayan yerlerde metotlar kullanılır.
// Don't repeat yourself - Kendini tekrar etme.
//Clean Code
//Best practice - Doğru uygulama Teknikleri