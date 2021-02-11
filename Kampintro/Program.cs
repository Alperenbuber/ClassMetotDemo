using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // do not repeat yourself =kendini tekrarlama
            //type safety=tip güvenliği
            //değer tutucu=kategoriEtiketi bu metin için takma metindir.Bizim için bir anlamı vardır.Kodsal olarak. 
            // int tam sayılar için kullanılır.
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMİ = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalıs Butonu");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else 
            {
                Console.WriteLine("Sabit Butonu");
            }



            if (sistemeGirisYapmisMİ== true)

            {
                Console.WriteLine("Kullanıcı Ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap Butonu");
            }

            Console.WriteLine(ogrenciSayisi);         


        }
    }
}
