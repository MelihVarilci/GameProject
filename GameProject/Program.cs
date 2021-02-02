using System;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer1 = new Gamer();

            gamer1.DateOfBirth = new DateTime(2000, 10, 18);
            gamer1.FirstName = "Melih".ToUpper();
            gamer1.LastName = "Varilci".ToUpper();
            gamer1.Id = 1;
            gamer1.NationalityId = "10038170156";

            gamerManager.Save(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Game game1 = new Game
            {
                GameName = "CSGO",
                Id = 1,
                Price = 25
            };

            BaseGameManager gameManager = new GameManager();

            gameManager.Purchase(game1, gamer1);

            BaseCampaignManager campaignManager = new CampaignMenager();

            Campaign campaign1 = new Campaign();

            campaign1.CampaignName = "CSGO Games - Campaign";
            campaign1.Discount = 45;
            campaign1.GameId = 1;
            campaign1.Id = 1;

            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            BaseSalesManager salesManager = new SalesManager();
            salesManager.Sell(gamer1, game1, campaign1);

            Console.ReadLine();
        }
    }
}