using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Id = 777;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "123465789";
            

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "123456";
            musteri2.Id = 888;
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";




            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new TuzelMusteri();

           
            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);






            //Gerçek Müşteri - Tüzel Müşteri

        }
    }
}
