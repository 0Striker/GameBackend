using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class SellingManager : ISaleOps
    {
        public void Sell(DefaultUser defaultUser)
        {
            Console.WriteLine(defaultUser.Name + " İsimli Kullanıcı Kampanyasız Satın Alma İşlemini Gerçekleştirmiştir.");
        }
        public void CampaingSale(DefaultUser defaultUser)
        {
            Console.WriteLine(defaultUser.Name + " İsimli Kullanıcı Kampanyalı Satın Alma İşlemini Gerçekleştirmiştir.");
        }
    }
}
