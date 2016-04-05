using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZakLyd.Models
{
    public class AdvancedSearchViewModel : SearchModel
    {
        public string DepartureCity { get; set; }
        public string DepartureCountry { get; set; }
        public string ArrivalCity { get; set; }
        public string ArrivalCountry { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public IEnumerable<int> HotelStars { get; set; } 
        public int MaxHotelDistance { get; set; }
        public bool IsWithStep { get; set; }
        public IDictionary<string, bool> Steps { get; set; } 
    }
}