﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventForYou
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Event_categories> Event_categories { get; set; }
        public virtual DbSet<Event_Managers> Event_Managers { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Service_packages> Service_packages { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User_registration> User_registration { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
