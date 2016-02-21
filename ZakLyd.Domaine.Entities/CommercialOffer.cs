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
    [Table("CommercialOffer", Schema = "pricing")]
    public class CommercialOffer : ToApprouveEntity
    {
        [Key]
        public long CommercialOfferId { get; set; }
        [Required]
        public CommercialOfferType CommercialOfferType { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }
        [Required]
        public Agency Agency { get; set; }
        [Required]
        public long AgentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
    }
}
