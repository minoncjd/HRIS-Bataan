//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRiS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceSH
    {
        public int AttendanceSHSID { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> Quarter { get; set; }
        public Nullable<int> Absences { get; set; }
        public Nullable<int> Tardy { get; set; }
        public string Diyos1 { get; set; }
        public string Diyos2 { get; set; }
        public string Tao1 { get; set; }
        public string Tao2 { get; set; }
        public string Kalikasan { get; set; }
        public string Bansa1 { get; set; }
        public string Bansa2 { get; set; }
    
        public virtual Period Period { get; set; }
        public virtual Student Student { get; set; }
    }
}
