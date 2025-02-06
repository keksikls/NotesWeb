using Microsoft.EntityFrameworkCore;
using Notespr.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Data.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData
                (
                    new Category { id = 1 , Name = "LowPrior",DisplayOrder = 1 },
                    new Category { id = 2, Name = "MedPrior", DisplayOrder = 2 },
                    new Category { id = 3, Name = "HighPrior", DisplayOrder = 3 }
                );
                
        }
    }
}
