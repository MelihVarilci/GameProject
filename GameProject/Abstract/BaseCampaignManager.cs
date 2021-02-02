using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public class BaseCampaignManager : ICampaignService
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi" + campaign.CampaignName);
        }

        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi" + campaign.CampaignName);
        }

        public virtual void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi" + campaign.CampaignName);
        }
    }
}