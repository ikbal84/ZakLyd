using System;
using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    public class AgencySummary
    {
        [String]
        public Guid AgencyId { get; set; }
        [String]
        public string AgencyName { get; set; }
        [String]
        public string City { get; set; }
        [Nested(IncludeInParent = true)]
        public Image Image { get; set; }
    }
}