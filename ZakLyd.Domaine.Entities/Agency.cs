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
    [Table("Agency", Schema = "zaklyd")]
    public class Agency : TrackedEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AgencyId { get; set; }
        [Required]
        [MaxLength(100)]
        public string AgencyName { get; set; }
        [Required]
        [MaxLength(255)]
        [DataType(DataType.Html)]
        public string ShortDescription { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string LongDescription { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber3 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Fax1 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Fax2 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Fax3 { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email1 {get; set;}
        [DataType(DataType.EmailAddress)]
        public string Email2 { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email3 { get; set; }
        [Required]
        public Subscription Subscription { get; set; }

        public ICollection<Media> MediaList { get; set; }
        public ICollection<Announcment> AnnouncementList { get; set; }
        public ICollection<AgencyAccountHistory> AgencyAccountHistory { get; set; }
        public ICollection<CommercialOffer> CommercialOffersListe { get; set; }
        public ICollection<Agent> AgentList { get; set; }
        public ICollection<Comment> CommentList { get; set; }
    }
}
