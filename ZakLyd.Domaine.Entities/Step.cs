using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    [Table("Step", Schema = "zaklyd")]
    public class Step
    {
        [Key]
        public long StepId { get; set; }
        [Required]
        [MaxLength(50)]
        public string DeparturePoint { get; set; }
        [Required]
        [MaxLength(50)]
        public string ArrivalPoint { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
    }
}
