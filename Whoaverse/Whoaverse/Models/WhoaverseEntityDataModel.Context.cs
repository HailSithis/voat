﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Whoaverse.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class whoaverseEntities : DbContext
    {
        public whoaverseEntities()
            : base("name=whoaverseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Commentvotingtracker> Commentvotingtrackers { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Votingtracker> Votingtrackers { get; set; }
        public virtual DbSet<Subverse> Subverses { get; set; }
        public virtual DbSet<Defaultsubverse> Defaultsubverses { get; set; }
    }
}
