using Nest;
using System;

namespace ZakLyd.Web.InterfaceEntities
{
    public class InterfacePricing
    {
        public long PricingId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [String]
        public string RoomType { get; set; }
        [Number(NumberType.Integer)]
        public int Capacity { get; set; }

        [Date(Format = "dd/mm/yyyy")]
        public DateTime DepartureDate { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime ArrivalDate { get; set; }
        [String]
        public string DepartureCity { get; set; }
        [String]
        public string DepartureAiroport { get; set; }
        [String]
        public string DepartureCountry { get; set; }
        [String]
        public string ArrivalCity { get; set; }
        [String]
        public string ArrivalAiroport { get; set; }
        [String]
        public string ArrivalCountry { get; set; }

        public float FreeTaxPrice { get; set; }

        public float VatRate { get; set; }

        public float Price { get; set; }

        public string Currency { get; set; }
        public int? InitialStock { get; set; }
        public int? AvailableStock { get; set; }
    }
}