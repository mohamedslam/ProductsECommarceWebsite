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
    
    public partial class V_AllCustHist
    {
        public long IdCode { get; set; }
        public Nullable<long> GroupId { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string NationNum { get; set; }
        public Nullable<long> Nationalty { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public string Declaration { get; set; }
        public string Descrip { get; set; }
        public string Type { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    }
}
