//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    using System;
    using System.Collections.Generic;
    
    public partial class LessonDB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LessonDB()
        {
            this.StudentLessonDBs = new HashSet<StudentLessonDB>();
        }
    
        public string Lesson_ID { get; set; }
        public string Lesson_Name { get; set; }
        public int Lesson_Credit { get; set; }
        public string Assigned_Teacher { get; set; }
    
        public virtual StaffDB StaffDB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentLessonDB> StudentLessonDBs { get; set; }
    }
}
