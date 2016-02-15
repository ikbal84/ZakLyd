using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    [Table("Currency", Schema = "pricing")]
    public class Currency
    {
        [Key]
        public long CurrencyId { get; set; }
        [Required]
        public string CurencyName { get; set; }
        [Required]
        public string CurrencySymbol { get; set; }
    }
}
