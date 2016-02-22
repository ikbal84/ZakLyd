using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.History
{
    [Table("AgencyHistory", Schema = "history")]
    public class AgencyHistory
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
        [MaxLength(255)]
        public string AddresseValue { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
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
        public string Email1 { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email2 { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email3 { get; set; }
        [Required]
        public SubscriptionType SubscriptionType { get; set; }
        [Required]
        public DateTime SubscriptionDate { get; set; }
        [Required]
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        [Required]
        public SubscriptionStatus Status { get; set; }
    }
}
