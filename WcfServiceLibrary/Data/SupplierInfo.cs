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
    
    public partial class SupplierInfo
    {
        public SupplierInfo()
        {
            this.HDPurchaseReturns = new HashSet<HDPurchaseReturn>();
            this.ItemSources = new HashSet<ItemSource>();
            this.SupplierInfo_Detail = new HashSet<SupplierInfo_Detail>();
        }
    
        public long IdCode { get; set; }
        public Nullable<long> GroupId { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CompanyName { get; set; }
        public string NationNum { get; set; }
        public Nullable<long> Nationalty { get; set; }
        public Nullable<long> IsFogin { get; set; }
        public Nullable<System.DateTime> FirstDate { get; set; }
        public Nullable<System.DateTime> LastDate { get; set; }
        public string Tel { get; set; }
        public string homeTel { get; set; }
        public string CellPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public Nullable<long> Country { get; set; }
        public Nullable<long> State { get; set; }
        public Nullable<long> Tawon { get; set; }
        public string Adress { get; set; }
        public string PstelCode { get; set; }
        public Nullable<decimal> FirsAcount { get; set; }
        public Nullable<decimal> MaxAcount { get; set; }
        public string Notice { get; set; }
        public string Category { get; set; }
        public string Priorty { get; set; }
        public string ComercialNum { get; set; }
        public string TaxNum { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> CityID { get; set; }
        public Nullable<long> AccountID { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public Nullable<long> CountryID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<long> BranchID { get; set; }
        public long ID { get; set; }
        public string Path { get; set; }
        public string Code { get; set; }
    
        public virtual ICollection<HDPurchaseReturn> HDPurchaseReturns { get; set; }
        public virtual ICollection<ItemSource> ItemSources { get; set; }
        public virtual SupplierGroup SupplierGroup { get; set; }
        public virtual ICollection<SupplierInfo_Detail> SupplierInfo_Detail { get; set; }
    }
}
