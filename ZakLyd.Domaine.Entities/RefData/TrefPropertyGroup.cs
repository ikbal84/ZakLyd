using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.RefData
{
    [Table("PropertyGroup", Schema = "ref")]
    public class TrefPropertyGroup
    {
        public int Id { get; set; }
        public string Group { get; set; }
    }
}
