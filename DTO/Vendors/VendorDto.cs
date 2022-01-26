using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Vendors
{
    public class VendorDto
    {
        public long VendorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string ShopName { get; set; }

    }
}