//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibrary.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesItemSNAndExpiredDate
    {
        public long Id { get; set; }
        public Nullable<long> BillNum { get; set; }
        public string ItemCode { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<System.DateTime> ProductDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    }
}
