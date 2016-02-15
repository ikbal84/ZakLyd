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
    [Table("HotelDetail", Schema = "zaklyd")]
    public class HotelDetail: TrackedEntity
    {
        [Key]
        public long HotelDetailId { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public int Capacity { get; set; }
        [DataType(DataType.Html)]
        public string Description { get; set; }
        public ICollection<Media> MediaList { get; set; }
    }
}
