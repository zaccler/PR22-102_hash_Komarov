﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class construction_organizationEntities1 : DbContext
    {
        public construction_organizationEntities1()
            : base("name=construction_organizationEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdditionalServices> AdditionalServices { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentUsage> EquipmentUsage { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<MaterialDeliveries> MaterialDeliveries { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderServices> OrderServices { get; set; }
        public virtual DbSet<ProjectStages> ProjectStages { get; set; }
        public virtual DbSet<ProjectSubcontractors> ProjectSubcontractors { get; set; }
        public virtual DbSet<QualityControl> QualityControl { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Subcontractors> Subcontractors { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Taxes> Taxes { get; set; }
    }
}