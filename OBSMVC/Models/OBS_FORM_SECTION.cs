//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OBSMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OBS_FORM_SECTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBS_FORM_SECTION()
        {
            this.OBS_COL_FORM_QUESTIONS = new HashSet<OBS_COL_FORM_QUESTIONS>();
            this.OBS_COL_FORM_QUESTIONS1 = new HashSet<OBS_COL_FORM_QUESTIONS>();
        }
    
        public int obs_form_section_id { get; set; }
        public string obs_form_section_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_COL_FORM_QUESTIONS> OBS_COL_FORM_QUESTIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_COL_FORM_QUESTIONS> OBS_COL_FORM_QUESTIONS1 { get; set; }
    }
}