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
    
    public partial class HRISEmployeeAbsent
    {
        public int EmployeeAbsentID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Reason { get; set; }
    }
}
