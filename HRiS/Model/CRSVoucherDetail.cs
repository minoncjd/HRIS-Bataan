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
    
    public partial class CRSVoucherDetail
    {
        public int CRSVoucherDetailsID { get; set; }
        public Nullable<double> Debit { get; set; }
        public Nullable<double> Credit { get; set; }
        public Nullable<int> AcaDeptID { get; set; }
        public int AcctID { get; set; }
        public Nullable<int> SubAcctID { get; set; }
        public int CRSVoucherID { get; set; }
    
        public virtual CRSVoucher CRSVoucher { get; set; }
        public virtual ChartOfAccount ChartOfAccount { get; set; }
        public virtual SubChartOfAccount SubChartOfAccount { get; set; }
    }
}
