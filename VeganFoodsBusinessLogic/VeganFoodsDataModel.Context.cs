﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeganFoodsBusinessLogic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VeganFoodsEntities : DbContext
    {
        public VeganFoodsEntities()
            : base("name=VeganFoodsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ingredients> ingredients { get; set; }
        public virtual DbSet<recipes> recipes { get; set; }
        public virtual DbSet<recipeingredients> recipeingredients { get; set; }
    }
}
