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
    
    public partial class CoaBank
    {
        public int CoaBankID { get; set; }
        public int AcctID { get; set; }
        public int BankID { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual ChartOfAccount ChartOfAccount { get; set; }
    }
}
