namespace ZakLyd.Web.InterfaceEntities
{
    public class HotelSummary
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int Stars { get; set; }
        public string ShortDescription { get; set; }
        public string City { get; set; }
        public Image Image { get; set; }
    }
}