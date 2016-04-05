namespace ZakLyd.Web.InterfaceEntities
{
    public class InterfaceHotelSummary
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int Stars { get; set; }
        public int DistanceFromHaram { get; set; }
        public string ShortDescription { get; set; }
        public string City { get; set; }
        public InterfaceImage Image { get; set; }
    }
}