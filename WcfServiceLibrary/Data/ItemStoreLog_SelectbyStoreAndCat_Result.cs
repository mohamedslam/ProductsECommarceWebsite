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
    
    public partial class ItemStoreLog_SelectbyStoreAndCat_Result
    {
        public Nullable<long> ItemID { get; set; }
        public Nullable<long> StoreID { get; set; }
        public Nullable<long> CurrentQTY { get; set; }
        public Nullable<long> SystemQTY { get; set; }
        public Nullable<System.DateTime> LastGardDate { get; set; }
        public string ItemLocation { get; set; }
        public string Barcode { get; set; }
        public string itemName { get; set; }
        public Nullable<long> UnitId { get; set; }
        public string Notes { get; set; }
        public Nullable<long> CatIDFK { get; set; }
    }
}
