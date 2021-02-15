using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameName = "CsGo";
            game.Price = 35;
            game.Id = 123456789;

            Game game1 = new Game();
            game1.GameName = "Pubg";
            game1.Id = 987632100;
            game1.Price = 43;


            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yılbaşı";
            campaign1.DiscountRate = 30;
            campaign1.CampaignId = 1;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "11.11";
            campaign2.DiscountRate = 50;
            campaign2.CampaignId = 2;

            Sales sales1 = new Sales();
            sales1.GamePrice = 30;

            Sales sales2 = new Sales();
            sales2.GamePrice = 45;


            Gamer gamer1 = new Gamer();
            gamer1.Id = 3;
            gamer1.FirstName = "Alperen";
            gamer1.LastName = "Büber";
            gamer1.TcNo = "123456789";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 4;
            gamer2.FirstName = "Kerem";
            gamer2.LastName = "Kerem";
            gamer2.TcNo = "987654321";

            Gamer gamer3 = new Gamer();
            gamer3.BirthDay = "1985";
            gamer3.FirstName = "Alperen";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer3);


            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game1);

            UserValidationManager userValidationManager = new UserValidationManager();
            userValidationManager.Validate(gamer1);


        }
    }
}
