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
    
    public partial class GradeCredit
    {
        public int CreditedID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public string SchoolName { get; set; }
        public string Semester { get; set; }
        public string SchoolYear { get; set; }
        public string OldGrade { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
