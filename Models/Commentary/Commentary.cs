﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Commentary
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public string Text { get; set; }    
    }
}
