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
    
    public partial class SP_TransferMaterials_Result
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> DateHDTransferMaterials { get; set; }
        public Nullable<long> HDTransferRequest { get; set; }
        public string Request_Store { get; set; }
        public string Recieve_Store { get; set; }
        public string emp_request { get; set; }
        public string emp_recieve { get; set; }
        public string HD_Notes { get; set; }
        public string ItemName { get; set; }
        public string UnitName { get; set; }
        public Nullable<double> RequestQTY { get; set; }
        public Nullable<double> TransferQTY { get; set; }
        public string DTL_Notes { get; set; }
        public string formName { get; set; }
        public Nullable<int> formNumber { get; set; }
        public string CompanyNameArb { get; set; }
        public string CompanyDescrption { get; set; }
        public string LinePhone { get; set; }
        public string Adress { get; set; }
    }
}
