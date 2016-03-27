﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    [ElasticsearchType(IdProperty = "HotelId", Name = "Hotel")]
    public class Hotel
    {
        [Number(NumberType.Long)]
        public long HotelId { get; set; }
        [String]
        public Guid AgencyId { get; set; }
        [String]
        public string Name { get; set; }
        [Number(NumberType.Integer)]
        public int Stars { get; set; }
        [String]
        public string Description { get; set; }
        [Nested(IncludeInParent = true)]
        public Address Address { get; set; }
        [String]
        public string City { get; set; }
        [Number(NumberType.Long)]
        public long Latitude { get; set; }
        [Number(NumberType.Long)]
        public long Longitude { get; set; }
        [Nested(IncludeInParent = true)]
        public HashSet<EntityProperties> PropertyList { get; set; }
        public HashSet<HotelDetail> HotelDetailList { get; set; }
        public HashSet<Image> MediaList { get; set; }
    }
}
