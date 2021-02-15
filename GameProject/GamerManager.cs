using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu başarıyla eklenmiştir:" + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
        }

        public void Add()
        {
            Console.WriteLine("Oyuncu başarıyla eklenmiştir:");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu başarıyla silinmiştir:" +gamer.FirstName);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Uptaded(Gamer gamer)
        {
            Console.WriteLine("Oyuncu başarıyla güncellenmiştir.:" + gamer.FirstName);
        }

        public void Uptaded()
        {
            throw new NotImplementedException();
        }
    }
}
