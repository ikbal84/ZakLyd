using System.Collections.Generic;
using ZakLyd.Models;
using ZakLyd.Web.InterfaceEntities;

namespace ZakLyd.Factory.Abstract
{
    public abstract class ViewModelAbstractFactory
    {
        public abstract ZakLydViewModel CreateHomeViewModel(IEnumerable<InterfacePromotion> promoList);
       // public abstract SearchResultViewModel();
    }
}