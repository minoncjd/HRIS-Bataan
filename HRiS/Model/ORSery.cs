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
    
    public partial class ORSery
    {
        public int orseriesID { get; set; }
        public int userid { get; set; }
        public int NextORNo { get; set; }
        public int BSeries { get; set; }
        public int ESeries { get; set; }
        public System.DateTime DateIssued { get; set; }
        public bool Active { get; set; }
    }
}