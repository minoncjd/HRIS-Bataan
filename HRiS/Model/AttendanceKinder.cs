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
    
    public partial class AttendanceKinder
    {
        public int AttendanceKinder1 { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public Nullable<int> JuneAbsent { get; set; }
        public Nullable<int> JulyAbsent { get; set; }
        public Nullable<int> AugustAbsent { get; set; }
        public Nullable<int> SeptemberAbsent { get; set; }
        public Nullable<int> OctoberAbsent { get; set; }
        public Nullable<int> NovemberAbsent { get; set; }
        public Nullable<int> DecemberAbsent { get; set; }
        public Nullable<int> JanuaryAbsent { get; set; }
        public Nullable<int> FebruaryAbsent { get; set; }
        public Nullable<int> MarchAbsent { get; set; }
        public Nullable<int> JuneTardy { get; set; }
        public Nullable<int> JulyTardy { get; set; }
        public Nullable<int> AugustTardy { get; set; }
        public Nullable<int> SeptemberTardy { get; set; }
        public Nullable<int> OctoberTardy { get; set; }
        public Nullable<int> NovemberTardy { get; set; }
        public Nullable<int> DecemberTardy { get; set; }
        public Nullable<int> JanuaryTardy { get; set; }
        public Nullable<int> FebruaryTardy { get; set; }
        public Nullable<int> MarchTardy { get; set; }
        public Nullable<int> StudentID { get; set; }
    
        public virtual Period Period { get; set; }
        public virtual Student Student { get; set; }
    }
}