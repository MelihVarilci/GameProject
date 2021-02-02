using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignMenager : BaseCampaignManager
    {
        public override void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi " + campaign.CampaignName);
        }

        public override void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi " + campaign.CampaignName);
        }

        public override void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi " + campaign.CampaignName);
        }
    }
}