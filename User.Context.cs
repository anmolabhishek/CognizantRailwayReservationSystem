﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RailwayReservationSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RailwayReservationSystemEntities1 : DbContext
    {
        public RailwayReservationSystemEntities1()
            : base("name=RailwayReservationSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Passenger_Details> Passenger_Details { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<Train_Details> Train_Details { get; set; }
        public virtual DbSet<User_Details> User_Details { get; set; }
        public virtual DbSet<Payment_Details> Payment_Details { get; set; }
        public virtual DbSet<Search_Details> Search_Details { get; set; }
        public virtual DbSet<Calculate_Amount> Calculate_Amount { get; set; }
    
        public virtual ObjectResult<Station_details_Result> Station_details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Station_details_Result>("Station_details");
        }
    }
}