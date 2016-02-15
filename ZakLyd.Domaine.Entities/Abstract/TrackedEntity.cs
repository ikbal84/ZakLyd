using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZakLyd.Domaine.Entities.Abstract
{
    public abstract class TrackedEntity
    {
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [Required]
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
    }
}
