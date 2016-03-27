using System;
using System.Collections.Generic;
using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    public class AirPlaneInfo
    {
        [Number(NumberType.Integer)]
        public int AirPlaneInfoId { get; set; }
        [String]
        public string AirPlaneInfoName { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime DepartureDate { get; set; }
        [Date(Format = "dd/mm/yyyy")]
        public DateTime ArrivalDate { get; set; }
        
        public HashSet<string> Steps { get; set; }
    }
}