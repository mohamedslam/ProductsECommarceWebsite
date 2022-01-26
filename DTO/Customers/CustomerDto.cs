using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Customers
{
    public class CustomerDto
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public List<string> AdressShipment { get; set; }

    }
}