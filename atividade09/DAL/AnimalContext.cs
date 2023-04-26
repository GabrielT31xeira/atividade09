using atividade09.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace atividade09.DAL
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base("AnimalContext") { }

        public DbSet<Invertebrados> Invertebrados { get; set; }
        public DbSet<Vertebrados> Vertebrados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}