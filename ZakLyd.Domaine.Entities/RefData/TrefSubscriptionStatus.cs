using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.RefData
{
    [Table("SubscriptionStatus", Schema = "ref")]
    public class TrefSubscriptionStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
