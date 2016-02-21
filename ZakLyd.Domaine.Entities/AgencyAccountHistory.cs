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
    [Table("AgencyAccountHistory", Schema = "zaklyd")]
    public class AgencyAccountHistory: TrackedEntity
    {
        [Key]
        public long AgencyAccountHistoryId { get; set; }
        [Required]
        public Agency Agency { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public SubscriptionAction Action { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Observation { get; set; }
    }
}
