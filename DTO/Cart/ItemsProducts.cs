﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Cart
{
    public class ItemsProducts
    {
        public Products.ProductDto Products { get; set; }
        public int Count { get; set; }
        public double Total { get; set; }
    }
}