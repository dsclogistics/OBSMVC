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
    
    public partial class OBS_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBS_TYPE()
        {
            this.OBS_COLLECT_FORM_TMPLT = new HashSet<OBS_COLLECT_FORM_TMPLT>();
            this.OBS_INST = new HashSet<OBS_INST>();
            this.OBS_TYPE_SUB_TYPES = new HashSet<OBS_TYPE_SUB_TYPES>();
        }
    
        public int obs_type_id { get; set; }
        public short obs_super_type_id { get; set; }
        public string obs_type_name { get; set; }
        public string obs_type_desc { get; set; }
        public System.DateTime obs_type_eff_st_dt { get; set; }
        public System.DateTime obs_type_eff_end_dt { get; set; }
    
        public virtual OBS_SUPER_TYPE OBS_SUPER_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_COLLECT_FORM_TMPLT> OBS_COLLECT_FORM_TMPLT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_INST> OBS_INST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_TYPE_SUB_TYPES> OBS_TYPE_SUB_TYPES { get; set; }
    }
}
