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
    
    public partial class HRISOffCampusActivity
    {
        public int OffCampusActivityID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<System.DateTime> DateFiled { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
