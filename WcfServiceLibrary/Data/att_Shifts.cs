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
    
    public partial class att_Shifts
    {
        public att_Shifts()
        {
            this.att_attendance = new HashSet<att_attendance>();
            this.att_ShiftsTimes = new HashSet<att_ShiftsTimes>();
        }
    
        public long ID { get; set; }
        public string IDCode { get; set; }
        public string Name { get; set; }
        public bool OpenShift { get; set; }
        public Nullable<int> MinTime { get; set; }
        public Nullable<int> TotalTime { get; set; }
        public Nullable<int> DaysCount { get; set; }
        public bool NotActive { get; set; }
        public string Notes { get; set; }
    
        public virtual ICollection<att_attendance> att_attendance { get; set; }
        public virtual ICollection<att_ShiftsTimes> att_ShiftsTimes { get; set; }
    }
}
