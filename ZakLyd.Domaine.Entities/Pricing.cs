using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class Pricing
    {
        public long PricingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public HotelDetail Room { get; set; }
        public AirPlaneInformation AirPlane { get; set; }
        public float FreeTaxPrice {get; set;}
        public float VatRate { get; set; }
        public float Price { get; set; }
        public Currency Currency { get; set; } 
        public int? InitialStock { get; set; }
        public int? AvailableStock { get; set; }
    }
}
