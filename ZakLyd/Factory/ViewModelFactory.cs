using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZakLyd.Factory.Abstract;
using ZakLyd.Models;
using ZakLyd.Web.InterfaceEntities;

namespace ZakLyd.Factory
{
    public class ViewModelFactory : ViewModelAbstractFactory
    {
        public override ZakLydViewModel CreateHomeViewModel(IEnumerable<InterfacePromotion> promoList)
        {
            return new HomeViewModel
            {
                Search = new SearchModel(),
                PromotionsList = GetPromoListModelFromPormoList(promoList)
            };
        }

        private static IEnumerable<PromoModel> GetPromoListModelFromPormoList(IEnumerable<InterfacePromotion> promoList)
        {
            return promoList.Select(p =>  new PromoModel
            {
                AnnoncementId = p.AnnoncementId,
                AgencyId =  p.AgencyId,
                PromotionName = p.PromotionName,
                Price = p.Price,
                RefPrice = p.RefPrice,
                AnnouncementLink =  p.AnnouncementLink,
                PromotionImageUrl = p.PromotionImageUrl,
                PromotionImageTitle = p.PromotionImageTitle,
                PromoText = p.PromoText,
                PromotionId = p.PromotionId
            }
            );
        } 
    }
}
