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
    
    public partial class DMCM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMCM()
        {
            this.BackAccounts = new HashSet<BackAccount>();
        }
    
        public int DMCMID { get; set; }
        public Nullable<int> PeriodID { get; set; }
        public string Remarks { get; set; }
        public Nullable<double> Amount { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<int> DocNum { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string DC { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<bool> ChargeToStudentAr { get; set; }
        public Nullable<bool> ChargeToAssessment { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> AcaDeptID { get; set; }
        public Nullable<int> AcctID { get; set; }
        public Nullable<int> SubAcctID { get; set; }
    
        public virtual AcademicDepartment AcademicDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BackAccount> BackAccounts { get; set; }
        public virtual ChartOfAccount ChartOfAccount { get; set; }
        public virtual Period Period { get; set; }
        public virtual Student Student { get; set; }
        public virtual SubChartOfAccount SubChartOfAccount { get; set; }
    }
}
