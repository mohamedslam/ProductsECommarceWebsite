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
    
    public partial class V_SalesPublicReturnAllData
    {
        public long Idcode { get; set; }
        public Nullable<long> IdcodeSalesMain { get; set; }
        public Nullable<long> StoreId { get; set; }
        public Nullable<decimal> Checkpay { get; set; }
        public Nullable<decimal> CashPay { get; set; }
        public Nullable<decimal> delayedPay { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> DateBill { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public Nullable<bool> IsInStore { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Amount { get; set; }
        public Nullable<float> UnitsInAmount { get; set; }
        public Nullable<float> CountAmount { get; set; }
        public Nullable<decimal> PriceUnit { get; set; }
        public Nullable<float> Amounts { get; set; }
        public Nullable<float> Total { get; set; }
        public Nullable<long> PeriodId { get; set; }
    }
}
