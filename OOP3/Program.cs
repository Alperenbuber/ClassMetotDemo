using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();        
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(tasıtKrediManager,fileLogerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasıtKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
