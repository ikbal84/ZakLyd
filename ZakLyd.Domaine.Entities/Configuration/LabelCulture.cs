using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.Configuration
{
    [Table("LabelCulture", Schema = "config")]
    public class LabelCulture
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public Label Lable { get; set; }
        [Required]
        public Culture Culture { get; set; }
        [Required]
        public string LabelValue {get;set;}
    }
}
