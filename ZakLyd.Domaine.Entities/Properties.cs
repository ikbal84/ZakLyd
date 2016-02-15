using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZakLyd.Domaine.Entities
{
    [Table("Properties", Schema = "zaklyd")]
    public class Properties
    {
        [Key]
        public long PropertiesId { get; set; }
        [Required]
        public long RealatedId { get; set; }
        [Required]
        public PropertyGroup PropertyGroup { get; set; }
        [Required]
        [MaxLength(20)]
        public string PropertyKey { get; set; }
        [Required]
        public string PropertyValue { get; set; }
    }
}