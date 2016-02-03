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
    
    public partial class OBS_INST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBS_INST()
        {
            this.OBS_COLLECT_FORM_INST = new HashSet<OBS_COLLECT_FORM_INST>();
            this.OBS_INST_EVENT_LOG = new HashSet<OBS_INST_EVENT_LOG>();
            this.OBS_RVW_FORM_INST = new HashSet<OBS_RVW_FORM_INST>();
        }
    
        public long obs_inst_id { get; set; }
        public int obs_type_id { get; set; }
        public int dsc_lc_id { get; set; }
        public Nullable<int> dsc_cust_id { get; set; }
        public Nullable<int> dsc_observed_emp_id { get; set; }
        public System.DateTime obs_inst_create_dt { get; set; }
        public string obs_inst_status { get; set; }
        public string obs_inst_del_yn { get; set; }
        public Nullable<System.DateTime> obs_inst_del_date { get; set; }
        public string obs_inst_del_reason { get; set; }
    
        public virtual DSC_CUSTOMER DSC_CUSTOMER { get; set; }
        public virtual EMPLOYEE DSC_EMPLOYEE { get; set; }
        public virtual DSC_LC DSC_LC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_COLLECT_FORM_INST> OBS_COLLECT_FORM_INST { get; set; }
        public virtual OBS_TYPE OBS_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_INST_EVENT_LOG> OBS_INST_EVENT_LOG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_RVW_FORM_INST> OBS_RVW_FORM_INST { get; set; }
    }
}
