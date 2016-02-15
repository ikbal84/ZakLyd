﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.RefData
{
    [Table("SubscriptionType", Schema = "ref")]
    public class TrefSubscriptionType
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
