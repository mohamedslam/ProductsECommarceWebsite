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
    
    public partial class att_ShiftsTimes_SelectPeriods_Result
    {
        public Nullable<bool> Checked { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public Nullable<bool> StartPrayCheck { get; set; }
        public Nullable<long> StartTime { get; set; }
        public Nullable<long> StartPray { get; set; }
        public Nullable<bool> EndPrayCheck { get; set; }
        public Nullable<long> EndTime { get; set; }
        public Nullable<long> EndPray { get; set; }
        public short DayCode { get; set; }
    }
}
