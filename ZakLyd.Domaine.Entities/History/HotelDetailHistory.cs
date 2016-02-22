using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.History
{
    [Table("HotelDetailHistory", Schema = "history")]
    public class HotelDetailHistory 
    {
        [Key]
        public long HotelDetailId { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public string HotelName { get; set; }
        [Required]
        public int Capacity { get; set; }
        [DataType(DataType.Html)]
        public string Description { get; set; }
    }
}
