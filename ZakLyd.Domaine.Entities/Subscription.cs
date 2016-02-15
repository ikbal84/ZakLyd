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
    [Table("Subscription", Schema = "pricing")]
    public class Subscription: TrackedEntity
    {
        [Key]
        public long SubscriptionId { get; set; }
        [Required]
        public SubscriptionType SubscriptionType { get; set; }
        [Required]
        public DateTime SubscriptionDate { get; set; }
        [Required]
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        [Required]
        public SubscriptionStatus Status { get; set; }

    }
}
