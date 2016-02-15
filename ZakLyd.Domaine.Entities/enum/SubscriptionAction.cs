using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public enum SubscriptionAction
    {
        SubscriptionRequest = 0,
        InformationRequest= 1,
        AgentAffilationRequest = 2,
        AgentUnaffilliationRequest = 3,
        AgencyInformationUpdate = 4
        //...
    }
}
