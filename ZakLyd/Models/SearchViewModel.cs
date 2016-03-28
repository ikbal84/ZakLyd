using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ZakLyd.Models
{
    public class SearchViewModel
    {
        public bool IsHajj { get; set; } //hajj or Omra
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PersonNumber { get; set; }

    }
}