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
    
    public partial class GuidanceReferralReasonAnswer
    {
        public int GuidanceReferralReasonAnswerID { get; set; }
        public Nullable<int> GuidanceReferralID { get; set; }
        public Nullable<int> GuidanceReferralReasonID { get; set; }
        public string Others { get; set; }
    
        public virtual GuidanceReferral GuidanceReferral { get; set; }
        public virtual GuidanceReferralReason GuidanceReferralReason { get; set; }
    }
}
