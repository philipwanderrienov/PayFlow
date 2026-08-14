using Microsoft.EntityFrameworkCore;
using PayFlow.Domain.Payments;

namespace PayFlow.Infrastructure.Persistence;

public sealed class PayFlowDbContext(DbContextOptions<PayFlowDbContext> options) : DbContext(options)
{
    public DbSet<Payment> Payments => Set<Payment>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var payment = modelBuilder.Entity<Payment>();
        payment.ToTable("payments"); payment.HasKey(x => x.Id);
        payment.HasIndex(x => x.Reference).IsUnique();
        payment.Property(x => x.Reference).HasMaxLength(64).IsRequired();
        payment.Property(x => x.Currency).HasMaxLength(3).IsRequired();
        payment.Property(x => x.Amount).HasPrecision(18, 2);
        payment.Property(x => x.Status).HasConversion<string>().HasMaxLength(32);
    }
}
