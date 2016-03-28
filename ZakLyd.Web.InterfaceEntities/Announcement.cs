using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    [ElasticsearchType(IdProperty = "AnnouncementId", Name = "Announcement")]
    public class Announcement
    {
        [Number(NumberType.Integer)]
        public int AnnouncementId { get; set; }
        [String]
        public string Title { get; set; }
        [String]
        public string ShortDescription { get; set; }
        [String]
        public string LongDescription { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime StartDate { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime EndDate { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime StartBookingDate { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime EndBookingDate { get; set; }

        public HashSet<Pricing> Pricings { get; set; }
        [Nested(IncludeInParent = true)]
        public AgencySummary AgencySummary { get; set; }

        [Nested(IncludeInParent = true)]
        public HashSet<Image> Images { get; set; }

        [Nested(IncludeInParent = true)]
        public HashSet<EntityProperties> Properties { get; set; }

        [Nested(IncludeInParent = true)]
        public HashSet<HotelSummary> HotelSummaries { get; set; }

        [Nested(IncludeInParent = true)]
        public AirPlaneInfo DepartureInfo { get; set; }
        [Nested(IncludeInParent = true)]
        public AirPlaneInfo ArrivalInfo { get; set; }

    }


}