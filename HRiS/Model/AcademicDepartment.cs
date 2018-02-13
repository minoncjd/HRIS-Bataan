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
    
    public partial class AcademicDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AcademicDepartment()
        {
            this.APVoucherDetails = new HashSet<APVoucherDetail>();
            this.CDSVoucherDetails = new HashSet<CDSVoucherDetail>();
            this.GLBeginningBalances = new HashSet<GLBeginningBalance>();
            this.Curricula = new HashSet<Curriculum>();
            this.DiscountCategories = new HashSet<DiscountCategory>();
            this.DMCMs = new HashSet<DMCM>();
            this.Employees = new HashSet<Employee>();
            this.FacultyLoadings = new HashSet<FacultyLoading>();
            this.HRISApplicationCertificateEmployments = new HashSet<HRISApplicationCertificateEmployment>();
            this.EmployeeHistories = new HashSet<EmployeeHistory>();
        }
    
        public int AcaDeptID { get; set; }
        public string AcaDepartmentName { get; set; }
        public string AcaAcronym { get; set; }
        public bool IsAcad { get; set; }
        public string GLCode { get; set; }
        public Nullable<int> EmployeeDivisionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APVoucherDetail> APVoucherDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDSVoucherDetail> CDSVoucherDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLBeginningBalance> GLBeginningBalances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curriculum> Curricula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountCategory> DiscountCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMCM> DMCMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacultyLoading> FacultyLoadings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HRISApplicationCertificateEmployment> HRISApplicationCertificateEmployments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; }
    }
}
