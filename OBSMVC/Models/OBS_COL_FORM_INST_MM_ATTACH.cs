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
    
    public partial class OBS_COL_FORM_INST_MM_ATTACH
    {
        public long obs_cfima_id { get; set; }
        public long obs_cfi_id { get; set; }
        public Nullable<int> obs_question_id { get; set; }
        public short obs_mm_type_id { get; set; }
        public string obs_cfima_ntwk_path { get; set; }
        public string obs_cfima_filename { get; set; }
        public System.DateTime obs_cfima_add_dt { get; set; }
    
        public virtual OBS_COLLECT_FORM_INST OBS_COLLECT_FORM_INST { get; set; }
        public virtual OBS_MULTIMEDIA_TYPE OBS_MULTIMEDIA_TYPE { get; set; }
        public virtual OBS_QUESTION OBS_QUESTION { get; set; }
    }
}
