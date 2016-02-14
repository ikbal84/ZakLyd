using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class Subscription
    {
        public long SubscriptionId { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public Agent Subscriptor { get; set; }
        public Agency Agency { get; set; }
    }
}
