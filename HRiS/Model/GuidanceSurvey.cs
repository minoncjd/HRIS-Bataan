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
    
    public partial class GuidanceSurvey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GuidanceSurvey()
        {
            this.GuidanceSurveyDetails = new HashSet<GuidanceSurveyDetail>();
        }
    
        public int GuidanceSurveyID { get; set; }
        public string SurveyName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuidanceSurveyDetail> GuidanceSurveyDetails { get; set; }
    }
}
