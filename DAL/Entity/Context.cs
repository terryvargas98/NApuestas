using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace DAL.Entity
{
    class Context:DbContext
    {
        public Context(string con) : base(con)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //DONT DO THIS ANYMORE
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Vote>().ToTable("Votes")
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Preguntas> Pregunta { get; set; }
        public DbSet<Alternativas> Alternativas { get; set; }
    }
}

