using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class AppDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set a clustered index for ClusteredName
            modelBuilder.Entity<Model>().HasIndex(b => b.ClusteredName).IsClustered();

            // Set an index for Name
            modelBuilder.Entity<Model>().HasIndex(b => b.Name);
        }

    }
}
