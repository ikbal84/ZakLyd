using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZakLyd.Domaine.Entities.Abstract;
using ZakLyd.Domaine.Entities.History;

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
        public Hotel Hotel { get; set; }
        [Required]
        public int Capacity { get; set; }
        [DataType(DataType.Html)]
        public string Description { get; set; }
        public ICollection<Media> MediaList { get; set; }
        public ICollection<Announcment> AnnouncmentList { get; set; }
        public ICollection<HotelDetailHistory> HistoryList { get; set; }
    }
}
