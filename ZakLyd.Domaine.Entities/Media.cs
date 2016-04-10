using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZakLyd.Domaine.Entities.Abstract;

namespace ZakLyd.Domaine.Entities
{
    [Table("Media", Schema = "zaklyd")]
    public class Media : TrackedEntity
    {
        public long MediaId { get; set; }
        [Required]
        public MediaType Type { get; set; }
        [Required]
        public MediaGroup MediaGroup { get; set; }
        [Required]
        public string MediaTitle { get; set; }
        public string MediaDescription { get; set; }
        [Required]
        public bool IsThumb { get; set; }
        [Required]
        public bool IsMain { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string MediaUri { get; set; }
    }

}
