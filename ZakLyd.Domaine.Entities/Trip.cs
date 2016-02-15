using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    [Table("Trip", Schema = "zaklyd")]
    public class Trip
    {
        [Key]
        public long TripId { get; set; }
        [Required]
        public AirPlaneInformation AirPlaneInformation { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        public ICollection<Step> StepList { get; set; }
    }
}
