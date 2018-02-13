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
    
    public partial class CDSVoucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CDSVoucher()
        {
            this.CDSVoucherDetails = new HashSet<CDSVoucherDetail>();
            this.APVouchers = new HashSet<APVoucher>();
        }
    
        public int CDSVoucherID { get; set; }
        public System.DateTime CDSVoucherDate { get; set; }
        public string CheckNo { get; set; }
        public string DocumentNo { get; set; }
        public int PayeeID { get; set; }
        public Nullable<int> APVoucherID { get; set; }
        public int BankAccountID { get; set; }
        public int SchoolYearID { get; set; }
        public string Particulars { get; set; }
        public string EncodedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<double> BankAmount { get; set; }
        public Nullable<int> BankAmount_CDSVoucherDetailsID { get; set; }
        public Nullable<int> EncodedByID { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
    
        public virtual APVoucher APVoucher { get; set; }
        public virtual Bank_Account Bank_Account { get; set; }
        public virtual CDSVoucherDetail CDSVoucherDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDSVoucherDetail> CDSVoucherDetails { get; set; }
        public virtual Payee Payee { get; set; }
        public virtual SchoolYear SchoolYear { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APVoucher> APVouchers { get; set; }
    }
}
