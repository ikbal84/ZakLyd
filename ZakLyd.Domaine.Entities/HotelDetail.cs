using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class HotelDetail
    {
        public long HotelDetailId { get; set; }
        public string RoomType { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public ICollection<Media> MediaList { get; set; }
    }
}
