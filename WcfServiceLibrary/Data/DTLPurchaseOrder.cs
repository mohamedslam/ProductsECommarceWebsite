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
    
    public partial class DTLPurchaseOrder
    {
        public long Id { get; set; }
        public Nullable<long> HDId { get; set; }
        public Nullable<long> ItemId { get; set; }
        public Nullable<long> UnitId { get; set; }
        public Nullable<long> SupplierUnite { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string Notes { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> storeId { get; set; }
        public Nullable<long> currentQuantity { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<decimal> DefultPrice { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<decimal> TotalDefultPrice { get; set; }
    }
}
