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
    
    public partial class StudentSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentSchedule()
        {
            this.sisSHS = new HashSet<sisSH>();
        }
    
        public int StudentScheduleID { get; set; }
        public int ScheduleID { get; set; }
        public int StudentSectionID { get; set; }
    
        public virtual Schedule Schedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sisSH> sisSHS { get; set; }
        public virtual Student_Section Student_Section { get; set; }
    }
}
