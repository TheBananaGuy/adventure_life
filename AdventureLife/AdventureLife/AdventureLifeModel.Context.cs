﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureLife
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdventureLifeEntities : DbContext
    {
        public AdventureLifeEntities()
            : base("name=AdventureLifeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<activity> activities { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<eventTime> eventTimes { get; set; }
        public virtual DbSet<reservation> reservations { get; set; }
    }
}