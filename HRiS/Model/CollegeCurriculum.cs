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
    
    public partial class CollegeCurriculum
    {
        public int CurriculumID { get; set; }
        public int Year { get; set; }
        public bool Active { get; set; }
        public string CurriculumCode { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public Nullable<bool> ActiveForAdmission { get; set; }
    }
}
