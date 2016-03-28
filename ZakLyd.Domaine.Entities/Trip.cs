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
        [Required]
        public string DepartureCity { get; set; }
        [Required]
        public string DepartureAiroport { get; set; }
        [Required]
        public string DepartureCountry { get; set; }
        [Required]
        public string ArrivalCity { get; set; }
        [Required]
        public string ArrivalAiroport { get; set; }
        [Required]
        public string ArrivalCountry { get; set; }
        public ICollection<Step> StepList { get; set; }
    }
}
