using System;
using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    public class InterfaceSubscription
    {
        [Number(NumberType.Integer)]
        public long SubscriptionId { get; set; }
        [Number(NumberType.Integer)]
        public int SubscriptionType { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime SubscriptionDate { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime SubscriptionStartDate { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime? SubscriptionEndDate { get; set; }
        [Number(NumberType.Integer)]
        public int Status { get; set; }
    }
}