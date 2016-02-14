using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class Comment
    {
        public long CommentId { get; set; }
        public CommentStatus CommentStatus { get; set; }
        public string CommentText { get; set; }
        public Agency TargetedAgency { get; set; }
        public DateTime JourneyStartDate { get; set; }
        public DateTime JourneyEndDate { get; set; }
        public string AdditionalJourneyInfo { get; set; }
        public string CommentApprouvalText { get; set; }
        public bool IsResponse { get; set; }
        public Comment ResponseTo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartProcessDate { get; set; }
        public DateTime ApprouvalDate { get; set; }
        public Visitor Visitor { get; set; }
        public Agent Agent { get; set; }
    }
}
