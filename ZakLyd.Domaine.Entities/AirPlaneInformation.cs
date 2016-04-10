using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZakLyd.Domaine.Entities
{
    [Table("AirPlaneInformation", Schema = "zaklyd")]
    public class AirPlaneInformation
    {
        [Key]
        public long AirPlaneInformationId { get; set; }
        [Required]
        public string AirPlaneInfoName { get; set; }
        [Required]
        public Announcement Announcement { get; set; }
        public Trip Aller { get; set; }
        public Trip Retour { get; set; }
    }

}
