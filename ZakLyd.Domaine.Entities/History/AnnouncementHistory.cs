using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.History
{
    [Table("AnnouncementHistory", Schema = "history")]
    public class AnnouncementHistory 
    {
        [Key]
        public long AnnouncementId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string ShortDescription { get; set; }
        [DataType(DataType.Html)]
        public string LongDescription { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? StartBookingDate { get; set; }
        public DateTime? EndBookingDate { get; set; }
        [Required]
        public string AgencyName { get; set; }
        [Required]
        public long AgentId { get; set; }
    }
}
