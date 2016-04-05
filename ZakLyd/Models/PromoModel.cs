
namespace ZakLyd.Models
{
    public class PromoModel
    {
        public long PromotionId { get; set; }
        public long AnnoncementId { get; set; }
        public long AgencyId { get; set; }
        public string PromotionName { get; set; }
        public string PromotionImageUrl { get; set; }
        public string PromotionImageTitle { get; set; }
        public float RefPrice { get; set; }
        public float Price { get; set; }
        public string PromoText { get; set; }
        public string AnnouncementLink { get; set; }
    }
}