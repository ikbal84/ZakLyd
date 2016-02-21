using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Domaine.Entities.Abstract;
using ZakLyd.Domaine.Entities.History;

namespace ZakLyd.Domaine.Entities
{
    [Table("Agent", Schema = "zaklyd")]
    public class Agent : TrackedEntity
    {
        [Key]
        public long AgentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public Agency Agency { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public AgentRole Role { get; set; }
        public ICollection<AgentHistory> HistoryList { get; set; }
    }
}
