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
    
    public partial class CreditCardPayment
    {
        public int CreditCardPaymentID { get; set; }
        public Nullable<int> BankID { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public byte[] TranTimeStamp { get; set; }
        public Nullable<int> UserID { get; set; }
        public string BatchNo { get; set; }
        public string ApprovalID { get; set; }
        public string Particulars { get; set; }
    
        public virtual Bank Bank { get; set; }
    }
}