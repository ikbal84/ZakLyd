using System;
using System.Collections.Generic;
using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    public class InterfaceAirPlaneInfo
    {
        [Number(NumberType.Integer)]
        public long AirPlaneInfoId { get; set; }
        [String]
        public string AirPlaneInfoName { get; set; }
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

        public HashSet<string> Steps { get; set; }
    }
}