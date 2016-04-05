using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    [ElasticsearchType(IdProperty = "PromotionId", Name = "Promotion")]
    public class InterfacePromotion
    {
        [Number(NumberType.Double)]
        public long PromotionId { get; set; }
        [Number(NumberType.Double)]
        public long AnnoncementId { get; set; }
        [Number(NumberType.Double)]
        public long AgencyId { get; set; }
        [String]
        public string PromotionName { get; set; }
        [String]
        public string PromotionImageUrl { get; set; }
        [String]
        public string PromotionImageTitle { get; set; }
        [Number(NumberType.Float)]
        public float RefPrice { get; set; }
        [Number(NumberType.Float)]
        public float Price { get; set; }
        [String]
        public string PromoText { get; set; }
        [String]
        public string AnnouncementLink { get; set; }
    }
}
