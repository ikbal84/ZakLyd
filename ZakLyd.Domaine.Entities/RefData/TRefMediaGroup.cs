using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.RefData
{
    [Table("MediaGroup", Schema = "ref")]
    public class TRefMediaGroup
    {
        [Key]
        public int Id { get; set; }
        public string MediaGroup { get; set; }
    }
}
