﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using TMDT_BanHang.Models;

namespace TMDT_BanHang.Models
{
    [Table("NewsTags")]
    public class NewsTags
    {
        [Key]
        [Column(Order=1)]
        public int news_id { get; set; }

        [Key]
        [Column(Order=2)]
        public int tag_id { get; set; }

        public virtual News News { get; set; }
        public virtual Tags Tags { get; set; }
    }
}