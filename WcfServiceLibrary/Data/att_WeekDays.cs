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
    
    public partial class att_WeekDays
    {
        public att_WeekDays()
        {
            this.att_attendance = new HashSet<att_attendance>();
            this.att_ShiftsTimes = new HashSet<att_ShiftsTimes>();
        }
    
        public short ID { get; set; }
        public string Name { get; set; }
        public short Code { get; set; }
    
        public virtual ICollection<att_attendance> att_attendance { get; set; }
        public virtual ICollection<att_ShiftsTimes> att_ShiftsTimes { get; set; }
    }
}
