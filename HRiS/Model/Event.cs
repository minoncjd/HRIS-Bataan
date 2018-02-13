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
    
    public partial class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> EventStart { get; set; }
        public Nullable<System.DateTime> EventEnd { get; set; }
        public string Venue { get; set; }
        public string Tagline { get; set; }
        public string Admission { get; set; }
        public string Audience { get; set; }
        public string Contact { get; set; }
        public Nullable<bool> Featured { get; set; }
        public Nullable<int> EventTypeID { get; set; }
        public Nullable<int> EventSubjectID { get; set; }
        public byte[] Photo { get; set; }
        public string EventDetails { get; set; }
    
        public virtual EventSubject EventSubject { get; set; }
        public virtual EventType EventType { get; set; }
    }
}
