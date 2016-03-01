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
    [Table("Label", Schema = "config")]
    public class Label : TrackedEntity
    {
        [Key]
        public long LabelId { get; set; }
        [Required]
        public string LabelKey { get; set; }

    }
}
