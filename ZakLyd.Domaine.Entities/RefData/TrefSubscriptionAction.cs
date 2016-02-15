using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.RefData
{
    [Table("SubscriptionAction", Schema = "ref")]
    public class TrefSubscriptionAction
    {
        public int Id { get; set; }
        public string Action { get; set; }
    }
}
