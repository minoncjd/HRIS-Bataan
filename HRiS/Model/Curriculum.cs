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
    
    public partial class Curriculum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curriculum()
        {
            this.Curriculum_Subject = new HashSet<Curriculum_Subject>();
            this.Sections = new HashSet<Section>();
            this.PreReqs = new HashSet<PreReq>();
            this.Payments = new HashSet<Payment>();
            this.ProgamCurriculums = new HashSet<ProgamCurriculum>();
            this.Student_Curriculum = new HashSet<Student_Curriculum>();
            this.Student_Section = new HashSet<Student_Section>();
            this.StudentWithQualifyings = new HashSet<StudentWithQualifying>();
            this.Tuitions = new HashSet<Tuition>();
        }
    
        public int CurriculumID { get; set; }
        public string Curriculum1 { get; set; }
        public Nullable<int> EducationalLevel { get; set; }
        public Nullable<int> AcaDeptID { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<bool> ActiveForAdmission { get; set; }
    
        public virtual AcademicDepartment AcademicDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curriculum_Subject> Curriculum_Subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Section> Sections { get; set; }
        public virtual EducationalLevel EducationalLevel1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreReq> PreReqs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgamCurriculum> ProgamCurriculums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Curriculum> Student_Curriculum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Section> Student_Section { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentWithQualifying> StudentWithQualifyings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tuition> Tuitions { get; set; }
    }
}
