﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZakLyd.Domaine.Entities.Abstract;

namespace ZakLyd.Domaine.Entities
{
    [Table("Hotel", Schema = "zaklyd")]
    public class Hotel: TrackedEntity
    {
        [Key]
        public long HotelId { get; set; }
        public Agency Agency { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Stars { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public ICollection<Properties> PropertyList { get; set; }
        public ICollection<HotelDetail> HotelDetailList { get; set; }
        public ICollection<Media> MediaList { get; set; }
    }
}