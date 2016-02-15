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
    [Table("Comment", Schema = "zaklyd")]
    public class Comment : ToApprouveEntity
    {
        [Key]
        public long CommentId { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string CommentText { get; set; }
        [Required]
        public Agency TargetedAgency { get; set; }
        public DateTime? JourneyStartDate { get; set; }
        public DateTime? JourneyEndDate { get; set; }
        public string AdditionalJourneyInfo { get; set; }
        public bool IsResponse { get; set; }
        public Comment ResponseTo { get; set; }
        public Visitor Visitor { get; set; }
        public long AgentId { get; set; }
    }
}
