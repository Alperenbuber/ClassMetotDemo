using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanyanız Başarıyla eklenmiştir.Kullandığınız Kampanya:" + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanyanız Başarıyla Silinmiştir.Kullandığınız Kampanya:" + campaign.CampaignName);
        }

        public void Uptaded(Campaign campaign)
        {
            Console.WriteLine("Kampanyanız Başarıyla Güncellenmiştir.Kullandığınız Kampanya:" + campaign.CampaignName);
        }
    }
}
