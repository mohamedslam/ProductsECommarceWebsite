﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DTO.Products
{
    public class Products
    {
        [DataMember]
        public long ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public double? Price { get; set; }
    }
}