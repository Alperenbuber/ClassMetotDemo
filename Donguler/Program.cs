using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs ";
            string kurs3 = "Java";
            string kurs4 = "c++";


            //array = dizi



            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kurs ", 
                "Java","Pyhton","C++","Matlab" };




            for (int i =0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                //dizi temelli yapıları tek tek dönmeye yarar.Kursları tek tek dolaş demek.Dizilere uygulanır.FOREACH YAPISI
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
