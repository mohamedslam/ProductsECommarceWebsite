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
    
    public partial class InventoryDataItemLastPeriod
    {
        public long Id { get; set; }
        public Nullable<long> PeriodId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Amount { get; set; }
        public Nullable<float> UnitsInAmount { get; set; }
        public Nullable<float> CountAmount { get; set; }
        public Nullable<decimal> PriceUnit { get; set; }
        public Nullable<float> TotalAmount { get; set; }
        public Nullable<long> StoreId { get; set; }
        public Nullable<long> IdBillPurchase { get; set; }
        public Nullable<long> IdBillSalesReturns { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string OperationType { get; set; }
        public Nullable<float> StockOnHand { get; set; }
        public Nullable<System.DateTime> InDate { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    }
}
