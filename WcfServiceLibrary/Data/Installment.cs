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
    
    public partial class Installment
    {
        public Installment()
        {
            this.Payment_Data = new HashSet<Payment_Data>();
            this.Payment_Permission = new HashSet<Payment_Permission>();
        }
    
        public long InstallmentID { get; set; }
        public Nullable<decimal> InstallmentValue { get; set; }
        public Nullable<System.DateTime> InstallmentDate { get; set; }
        public Nullable<long> ContractID { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> IsPaid { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual ICollection<Payment_Data> Payment_Data { get; set; }
        public virtual ICollection<Payment_Permission> Payment_Permission { get; set; }
    }
}
