using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZakLyd.Models
{
    public class HomeViewModel : ZakLydViewModel
    {
        public SearchModel Search { get; set; }
        public IEnumerable<PromoModel> PromotionsList { get; set; } 
    }
}