using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.Abstract
{
    public abstract class ToApprouveEntity : TrackedEntity
    {
        [Required]
        public ApprouvalStatus ApprouvalStatus { get; set; }
        [Required]
        public DateTime ApprouvalRequestDate { get; set; }
        public DateTime? ProcessingStartDate { get; set; }
        public DateTime? ApprouvalDate { get; set; }
        public string ApprouvalComment { get; set; }
    }
}
