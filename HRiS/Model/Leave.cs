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
    
    public partial class Leave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leave()
        {
            this.HRISChangeVacationLeaveDetails = new HashSet<HRISChangeVacationLeaveDetail>();
            this.HRISLeaveCancellations = new HashSet<HRISLeaveCancellation>();
        }
    
        public int LeaveID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> LeaveTypeID { get; set; }
        public Nullable<decimal> Days { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> FiledDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HRISChangeVacationLeaveDetail> HRISChangeVacationLeaveDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HRISLeaveCancellation> HRISLeaveCancellations { get; set; }
        public virtual LeaveType LeaveType { get; set; }
    }
}