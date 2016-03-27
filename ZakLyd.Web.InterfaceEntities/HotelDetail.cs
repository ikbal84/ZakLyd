using System.Collections.Generic;
using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    public class HotelDetail
    {
        [Number(NumberType.Long)]
        public long HotelDetailId { get; set; }
        [String]
        public string RoomType { get; set; }
        [Number(NumberType.Integer)]
        public int Capacity { get; set; }
        [String]
        public string Description { get; set; }
        [Nested(IncludeInParent = true)]
        public HashSet<Image> MediaList { get; set; }
    }
}