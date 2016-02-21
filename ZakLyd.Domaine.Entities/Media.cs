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
    [Table("Media", Schema = "zaklyd")]
    public class Media : TrackedEntity
    {
        public long MediaId { get; set; }
        [Required]
        public MediaType Type { get; set; }
        [Required]
        public MediaGroup MediaGroup { get; set; }
        [Required]
        public string MediaTitle { get; set; }
        public string MediaDescription { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string MediaUri { get; set; }
    }

}
