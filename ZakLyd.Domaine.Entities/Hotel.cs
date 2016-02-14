using System.Collections;
using System.Collections.Generic;

namespace ZakLyd.Domaine.Entities
{
    public class Hotel
    {
        public long HotelId { get; set; }
        public Agency Agency { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public ICollection<Properties> PropertyList { get; set; }
        public ICollection<HotelDetail> HotelDetailList { get; set; }
    }
}