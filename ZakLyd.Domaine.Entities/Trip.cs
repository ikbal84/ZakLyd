using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class Trip
    {
        public long TripId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public ICollection<Step> StepList { get; set; }
    }
}
