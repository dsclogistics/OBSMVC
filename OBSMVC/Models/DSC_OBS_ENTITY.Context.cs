﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DSC_OBS_DB_ENTITY : DbContext
    {
        public DSC_OBS_DB_ENTITY()
            : base("name=DSC_OBS_DB_ENTITY")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<DSC_LC> DSC_LC { get; set; }
        public virtual DbSet<OBS_ANS_TYPE> OBS_ANS_TYPE { get; set; }
        public virtual DbSet<OBS_SUB_TYPE> OBS_SUB_TYPE { get; set; }
        public virtual DbSet<OBS_SUPER_TYPE> OBS_SUPER_TYPE { get; set; }
        public virtual DbSet<OBS_TYPE> OBS_TYPE { get; set; }
        public virtual DbSet<OBS_QUEST_ANS_TYPES> OBS_QUEST_ANS_TYPES { get; set; }
        public virtual DbSet<OBS_QUEST_ASSGND_MD> OBS_QUEST_ASSGND_MD { get; set; }
        public virtual DbSet<OBS_QUEST_SLCT_ANS> OBS_QUEST_SLCT_ANS { get; set; }
        public virtual DbSet<OBS_QUESTION> OBS_QUESTION { get; set; }
        public virtual DbSet<OBS_QUESTION_METADATA> OBS_QUESTION_METADATA { get; set; }
    }
}
