﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tiorem.editor.database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TIOREMEntities : DbContext
    {
        public TIOREMEntities()
            : base("name=TIOREMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleTag> ArticleTag { get; set; }
        public DbSet<CatalogueCategory> CatalogueCategory { get; set; }
        public DbSet<CatalogueSource> CatalogueSource { get; set; }
        public DbSet<CatalogueTag> CatalogueTag { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<VW_ARTICLE_SUMMARY> VW_ARTICLE_SUMMARY { get; set; }
    }
}