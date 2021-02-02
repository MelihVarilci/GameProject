using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public class BaseSalesManager : ISalesService
    {
        public virtual void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            double indirim = game.Price * campaign.Discount / 100;
            double price = game.Price - indirim;
            Console.WriteLine(
                gamer.FirstName + " " +
                gamer.LastName + " purchased the name gamed " +
                game.GameName + " with the " +
                campaign.CampaignName + " campaing and paid a fee of " +
                price + "."
            );
        }
    }
}