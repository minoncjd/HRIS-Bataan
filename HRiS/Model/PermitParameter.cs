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
    
    public partial class PermitParameter
    {
        public int PermitParameterID { get; set; }
        public Nullable<System.DateTime> PermitDate { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public Nullable<int> EducLevelID { get; set; }
        public Nullable<byte> SemID { get; set; }
    
        public virtual EducationalLevel EducationalLevel { get; set; }
        public virtual Period Period { get; set; }
    }
}