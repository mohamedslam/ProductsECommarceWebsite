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
    
    public partial class InventoryDataLog_SelectOne_Result
    {
        public long Id { get; set; }
        public Nullable<long> InventoryId { get; set; }
        public Nullable<long> IdBill { get; set; }
        public Nullable<int> IdBillType { get; set; }
        public Nullable<long> StoreId { get; set; }
        public Nullable<long> PurchaseIdCode { get; set; }
        public Nullable<long> SalesIdCode { get; set; }
        public Nullable<long> ReturnsPurchaseIdCode { get; set; }
        public Nullable<long> ItemId { get; set; }
        public Nullable<int> SortSubtract { get; set; }
        public Nullable<long> Amount { get; set; }
        public Nullable<float> AmountUnitBefore { get; set; }
        public Nullable<float> AmountUnit { get; set; }
        public Nullable<long> UnitId { get; set; }
        public string OperationType { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> PeriodId { get; set; }
        public long Expr1 { get; set; }
        public string Barcode { get; set; }
        public string itemName { get; set; }
    }
}
