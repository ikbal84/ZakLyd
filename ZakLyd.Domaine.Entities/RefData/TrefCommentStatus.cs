﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities.RefData
{
    [Table("CommentStatus", Schema = "ref")]
    public class TrefCommentStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}