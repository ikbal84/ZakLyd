using System;
using System.Collections;
using System.Collections.Generic;

namespace ZakLyd.Domaine.Entities
{
    public class Announcment
    {
        public long AnnouncmentId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? StartBookingDate { get; set; }
        public DateTime? EndBookingDate { get; set; }
        public ICollection<Media> MediaList { get; set; }
        public ICollection<Properties> PropertyList { get; set; }
        public ICollection<Hotel> HotelList { get; set; }
        public ICollection<AirPlaneInformation> AirPlaneTripInformationList { get; set; }

    }
}