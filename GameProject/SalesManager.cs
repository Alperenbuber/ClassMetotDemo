using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService

    {
        public void CampaignSales(SalesManager sales)

        {
            Console.WriteLine("Kampanyalı Satış başarıyla gerçeklemiştir.");
        }

        public void Sales(SalesManager sales)
        {
            Console.WriteLine(" Ürünün satış fiyati:");
        }
    }
}
