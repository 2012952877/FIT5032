﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIT5032Assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AssignmentNewEntities : DbContext
    {
        public AssignmentNewEntities()
            : base("name=AssignmentNewEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Karaoke> Karaokes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}
