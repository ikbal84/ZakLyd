using System;

namespace ZakLyd.Models
{
    public class SearchModel
    {
        public bool IsHajj { get; set; } //hajj or Omra
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PersonNumber { get; set; }

    }
}