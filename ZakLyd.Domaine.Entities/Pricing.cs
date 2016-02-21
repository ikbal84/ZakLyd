using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Domaine.Entities.Abstract;

namespace ZakLyd.Domaine.Entities
{
    [Table("Pricing", Schema = "zaklyd")]
    public class Pricing : TrackedEntity
    {
        [Key]
        public long PricingId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public HotelDetail Room { get; set; }
        [Required]
        public AirPlaneInformation AirPlane { get; set; }
        [Required]
        public float FreeTaxPrice {get; set;}
        [Required]
        public float VatRate { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public Currency Currency { get; set; } 
        public int? InitialStock { get; set; }
        public int? AvailableStock { get; set; }
    }
}
