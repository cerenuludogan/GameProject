using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + campaign.CampaignName + campaign.DiscountRate + "eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + campaign.CampaignName + campaign.DiscountRate + "güncellendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId + campaign.CampaignName + campaign.DiscountRate + "silindi");
        }
    }
}
