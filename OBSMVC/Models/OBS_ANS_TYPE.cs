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
    
    public partial class OBS_ANS_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBS_ANS_TYPE()
        {
            this.OBS_QUEST_ANS_TYPES = new HashSet<OBS_QUEST_ANS_TYPES>();
        }
    
        public short obs_ans_type_id { get; set; }
        public string obs_ans_type_name { get; set; }
        public string obs_ans_type_desc { get; set; }
        public string obs_ans_type_has_fxd_ans_yn { get; set; }
        public string obs_ans_type_comment_mand_yn { get; set; }
        public string obs_ans_type_category { get; set; }
        public string obs_ans_type_api_tag_val { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBS_QUEST_ANS_TYPES> OBS_QUEST_ANS_TYPES { get; set; }
    }
}
