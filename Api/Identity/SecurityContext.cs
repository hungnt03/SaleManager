using Api.Entities;
using Api.Entities.Inflastructor;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Identity
{
    public class SecurityContext : IdentityDbContext<IdentityUser>
    {
        public SecurityContext(DbContextOptions<SecurityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TransactionDetail>()
                .HasKey(c => new { c.Barcode, c.TracsactionId });
            base.OnModelCreating(builder);
            builder.Seed();
        }

        public DbSet<Category> Category { set; get; }
        public DbSet<Customer> Customer { set; get; }
        public DbSet<Discount> Discount { set; get; }
        public DbSet<Product> Product { set; get; }
        public DbSet<Supplier> Supplier { set; get; }
        public DbSet<Transaction> Transaction { set; get; }
        public DbSet<TransactionDetail> TransactionDetail { set; get; }
        public DbSet<SystemParameter> SystemParameter { set; get; }
    }
}
