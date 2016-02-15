using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.RefData
{
    [Table("AgentRole", Schema = "ref")]
    public class TrefAgentRole
    {
        public int Id { get; set; }
        public string Role { get; set; }
    }
}
