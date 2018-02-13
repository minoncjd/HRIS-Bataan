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
    
    public partial class GradeCollege
    {
        public int GradeColID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<int> FacultyID { get; set; }
        public Nullable<System.DateTime> DateEncoded { get; set; }
        public string InitialGrade { get; set; }
        public string FinalGrade { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> ChangeOfGradeID { get; set; }
        public string CFGNO { get; set; }
        public Nullable<bool> IsLock { get; set; }
    
        public virtual Faculty Faculty { get; set; }
        public virtual Period Period { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
