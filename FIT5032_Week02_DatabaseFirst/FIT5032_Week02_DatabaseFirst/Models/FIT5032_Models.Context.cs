﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIT5032_Week02_DatabaseFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FIT5032_Week02_DatabaseFirstEntities1 : DbContext
    {
        public FIT5032_Week02_DatabaseFirstEntities1()
            : base("name=FIT5032_Week02_DatabaseFirstEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
    }
}
