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
    
    public partial class att_EmpSettings
    {
        public long ID { get; set; }
        public bool HasAttendance { get; set; }
        public Nullable<bool> IsAllIn { get; set; }
        public Nullable<bool> IsAllOut { get; set; }
        public Nullable<bool> IsAutoIn { get; set; }
        public Nullable<bool> IsAutoOut { get; set; }
        public Nullable<bool> IsOverTimeBefore { get; set; }
        public Nullable<bool> IsOverTimeAfter { get; set; }
        public Nullable<bool> IsHolidayOverTime { get; set; }
        public Nullable<bool> IsDiscount { get; set; }
        public Nullable<bool> IsDelay { get; set; }
        public Nullable<int> DelayMax { get; set; }
        public Nullable<bool> HasOverTimeMax { get; set; }
        public Nullable<int> OverTimeMax { get; set; }
        public long LUU { get; set; }
        public System.DateTime LUD { get; set; }
    
        public virtual EmployedInfo EmployedInfo { get; set; }
    }
}
