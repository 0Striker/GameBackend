using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface ISaleOps
    {
        public void Sell(DefaultUser defaultUser);
        public void CampaingSale(DefaultUser defaultUser);
    }
}
