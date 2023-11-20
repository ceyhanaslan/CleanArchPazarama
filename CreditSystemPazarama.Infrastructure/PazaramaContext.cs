using CreditSystemPazarama.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CreditSystemPazarama.Infrastructure;

public class PazaramaContext: DbContext
{
    public PazaramaContext(DbContextOptions<PazaramaContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasKey(c => c.Id);
        modelBuilder.Entity<Customer>().Property(c => c.Id);
        modelBuilder.Entity<Customer>().Property(c => c.FirstName).HasMaxLength(150);
        modelBuilder.Entity<Customer>().Property(c => c.LastName).HasMaxLength(150);
        modelBuilder.Entity<Customer>().Property(c => c.Email).HasMaxLength(150);
        modelBuilder.Entity<Customer>().Property(c => c.IdentityNumber);
        
        base.OnModelCreating(modelBuilder);
    }
}