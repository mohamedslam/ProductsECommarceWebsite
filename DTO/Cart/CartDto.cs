using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Cart
{
    public class CartDto
    {
        public Customers.CustomerDto Client { get; set; }
        public List<ItemsProducts> Products { get; set; }
        public double Sum { get; set; }
    }
}