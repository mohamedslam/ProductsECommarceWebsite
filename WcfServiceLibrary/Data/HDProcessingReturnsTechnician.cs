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
    
    public partial class HDProcessingReturnsTechnician
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> DateProcessingReturnsTechnicians { get; set; }
        public Nullable<long> StoreID { get; set; }
        public Nullable<long> ReturnID { get; set; }
        public Nullable<long> EmpID { get; set; }
        public Nullable<bool> IsReturned { get; set; }
        public string Notes { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> PeriodId { get; set; }
    }
}
