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
    
    public partial class SubjectEquivalent
    {
        public int SubjectEquivalentID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<int> EquivSubjectID { get; set; }
    
        public virtual Subject Subject { get; set; }
        public virtual Subject Subject1 { get; set; }
    }
}
