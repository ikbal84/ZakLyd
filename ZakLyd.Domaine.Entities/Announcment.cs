using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZakLyd.Domaine.Entities.Abstract;
using ZakLyd.Domaine.Entities.History;

namespace ZakLyd.Domaine.Entities
{
    [Table("Announcment", Schema = "zaklyd")]
    public class Announcment: TrackedEntity
    {
        [Key]
        public long AnnouncmentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string ShortDescription { get; set; }
        [DataType(DataType.Html)]
        public string LongDescription { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? StartBookingDate { get; set; }
        public DateTime? EndBookingDate { get; set; }
        public Agency Agency { get; set; }
        [Required]
        public long AgentId { get; set; }
        public ICollection<Pricing> PricingList { get; set; }
        public ICollection<Media> MediaList { get; set; }
        public ICollection<Properties> PropertyList { get; set; }
        public ICollection<Hotel> HotelList { get; set; }
        public ICollection<HotelDetail> HotelDetailList { get; set; }
        public ICollection<AirPlaneInformation> AirPlaneTripInformationList { get; set; }
        public ICollection<AnnouncmentHistory> HistoryList { get; set; }
    }
}