using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    public class InterfaceImage
    {
        [String]
        public string Title { get; set; }
        [String]
        public string Url { get; set; }
        [Number(NumberType.Integer)]
        public int MediaType { get; set; } // 0: Image, 1: video
        [Boolean]
        public bool IsThumb { get; set; }
        [Boolean]
        public bool IsMain { get; set; }
    }
    
}