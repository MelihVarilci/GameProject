using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SalesManager : BaseSalesManager
    {
        public override void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            double indirim = game.Price * campaign.Discount / 100;
            double price = game.Price - indirim;
            Console.WriteLine(
                gamer.FirstName + " " +
                gamer.LastName + " purchased the game named " +
                game.GameName + " with the " +
                campaign.CampaignName + " campaing and paid a fee of " +
                price + "."
            );
        }
    }
}