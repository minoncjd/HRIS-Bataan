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
    
    public partial class HSClubMember
    {
        public int JHSClubMemberID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> JHSClubID { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public string Quarter1 { get; set; }
        public string Quarter2 { get; set; }
        public string Quarter3 { get; set; }
        public string Quarter4 { get; set; }
        public string Average { get; set; }
        public string ComputedAverage { get; set; }
    }
}