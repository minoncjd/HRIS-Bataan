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
    
    public partial class HRISOnlineJobApplicationWorkExperience
    {
        public int ApplicationWorkID { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string InclusiveDate { get; set; }
        public string LastSalary { get; set; }
        public string ReasonLeaving { get; set; }
        public Nullable<int> ApplicationID { get; set; }
    
        public virtual HRISOnlineJobApplication HRISOnlineJobApplication { get; set; }
    }
}
