using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Domaine.Entities.Abstract;

namespace ZakLyd.Domaine.Entities.Configuration
{
    [Table("Culture", Schema = "config")]
    public class Culture: TrackedEntity
    {
        [Key]
        public long CultureId { get; set; }
        [Required]
        public string CultureValue { get; set; }
        public string Description { get; set; }

    }
}
