﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.History
{
    [Table("HotelDetailHistory", Schema = "history")]
    public class HotelDetailHistory : HotelDetail
    {
    }
}
