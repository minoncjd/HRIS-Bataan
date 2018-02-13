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
    
    public partial class CDSVoucherDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CDSVoucherDetail()
        {
            this.CDSVouchers = new HashSet<CDSVoucher>();
        }
    
        public int CDSVoucherDetailsID { get; set; }
        public Nullable<double> Debit { get; set; }
        public Nullable<double> Credit { get; set; }
        public int AcctID { get; set; }
        public Nullable<int> SubAcctID { get; set; }
        public Nullable<int> AcadDeptID { get; set; }
        public int CDSVoucherID { get; set; }
    
        public virtual AcademicDepartment AcademicDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDSVoucher> CDSVouchers { get; set; }
        public virtual CDSVoucher CDSVoucher { get; set; }
        public virtual ChartOfAccount ChartOfAccount { get; set; }
        public virtual SubChartOfAccount SubChartOfAccount { get; set; }
    }
}
