﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hospital
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hastane_yonetimEntities : DbContext
    {
        public hastane_yonetimEntities()
            : base("name=hastane_yonetimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doktor> Doktor { get; set; }
        public virtual DbSet<Giris> Giris { get; set; }
        public virtual DbSet<Hasta> Hasta { get; set; }
        public virtual DbSet<Ilac> Ilac { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<Recete> Recete { get; set; }
    }
}
