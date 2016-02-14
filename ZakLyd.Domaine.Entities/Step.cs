using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class Step
    {
        public long Id { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalPoint { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
