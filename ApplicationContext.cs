using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        public ApplicationContext()
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JL1OLL9\PIXEL327;Database=helloappdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<PhoneNumber>().HasKey(p => p.Id);
            modelBuilder.Entity<Customer>().HasOne(p => p.PhoneNumber).WithOne(c => c.Customer)
                .HasForeignKey<PhoneNumber>(n => n.Id);
                
        }

    }
}
