using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.History
{
    [Table("HotelHistory", Schema = "history")]
    public class HotelHistory 
    {
        [Key]
        public long HotelId { get; set; }
        public string AgencynName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Stars { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
    }
}
