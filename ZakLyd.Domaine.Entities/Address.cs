using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    [Table("Address", Schema ="zaklyd")]
    public class Address
    {
        [Key]
        public long AddressId {get; set;}
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
    }
}
