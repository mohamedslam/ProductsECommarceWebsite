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
    
    public partial class Sp_PurchaseCheck_Result
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Emp_name { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public long BillId { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> ReturnQuantity { get; set; }
        public string ItemName { get; set; }
        public string UnitName { get; set; }
        public string hd_notes { get; set; }
        public string DTL_notes { get; set; }
    }
}
