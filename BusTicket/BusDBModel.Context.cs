﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusTicket
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BusDBEntities : DbContext
    {
        public BusDBEntities()
            : base("name=BusDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BusInfoTB> BusInfoTBs { get; set; }
        public virtual DbSet<SuperViseorInfoTB> SuperViseorInfoTBs { get; set; }
        public virtual DbSet<RouteDetailsTB> RouteDetailsTBs { get; set; }
        public virtual DbSet<DriverInfoTB> DriverInfoTBs { get; set; }
        public virtual DbSet<CounterInfoTB> CounterInfoTBs { get; set; }
        public virtual DbSet<RouteInfoTB> RouteInfoTBs { get; set; }
        public virtual DbSet<TripInfoTB> TripInfoTBs { get; set; }
        public virtual DbSet<UserInfoTB> UserInfoTBs { get; set; }
    }
}
