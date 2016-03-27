﻿using System;
using Nest;
using Elasticsearch.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Web.InterfaceEntities
{
    [ElasticsearchType(IdProperty = "AgencyId", Name = "Agency")]
    public class Agency: InterfaceEntity
    {
        [String]
        public Guid AgencyId { get; set; }
        [String]
        public string AgencyName { get; set; }
        [String]
        public string SortDescription { get; set; }
        [String]
        public string LongDescription { get; set; }
        [String]
        public string PhoneNumber1 { get; set; }
        [String]
        public string PhoneNumber2 { get; set; }
        [String]
        public string PhoneNumber3 { get; set; }
        [String]
        public string Fax1 { get; set; }
        [String]
        public string Fax2 { get; set; }
        [String]
        public string Fax3 { get; set; }
        [String]
        public string Email1 { get; set; }
        [String]
        public string Email2 { get; set; }
        [String]
        public string Email3 { get; set; }

        [Nested(IncludeInParent = true)]
        public Address Address { get; set; }

        [Nested(IncludeInParent = true)]
        public Subscription Subscription { get; set; }

    }
}
