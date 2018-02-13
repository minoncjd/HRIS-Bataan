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
    
    public partial class Fee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fee()
        {
            this.AdjustmentDetailFees = new HashSet<AdjustmentDetailFee>();
            this.Assessments = new HashSet<Assessment>();
        }
    
        public int FeeID { get; set; }
        public string FeeCategory { get; set; }
        public int PeriodID { get; set; }
        public Nullable<int> AcctID { get; set; }
        public Nullable<int> SubAcctID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdjustmentDetailFee> AdjustmentDetailFees { get; set; }
        public virtual Aircon Aircon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ChartOfAccount ChartOfAccount { get; set; }
        public virtual Period Period { get; set; }
        public virtual Lab Lab { get; set; }
        public virtual Others Others { get; set; }
        public virtual Variou Variou { get; set; }
        public virtual SubChartOfAccount SubChartOfAccount { get; set; }
        public virtual Miscellaneou Miscellaneou { get; set; }
        public virtual Supplemental Supplemental { get; set; }
        public virtual Tuition Tuition { get; set; }
    }
}
