using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Domaine.Entities.Abstract;

namespace ZakLyd.Domaine.Entities.Configuration
{
    [Table("Configuration", Schema = "config")]
    public class Configuration : TrackedEntity
    {
        [Key]
        public long ConfigurationId { get; set; }
        [Required]
        public string ConfigurationKey { get; set; }
        [Required]
        public string ConfigurationValue { get; set; }
        public string Description { get; set; }
    }
}
