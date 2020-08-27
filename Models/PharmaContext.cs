using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PharmaAPI.Model
{
  public class PharmaContext : DbContext
  {
    public PharmaContext(DbContextOptions<PharmaContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Drug>().Property(d => d.DiplayName).HasComputedColumnSql("[Name]+' '+[Dose]");
      modelBuilder.Entity<Drug>().HasIndex(d => new { d.Name, d.Dose });

      modelBuilder.Entity<Bill>().Property(b => b.IssueDate).HasDefaultValueSql("GETDATE()");

      modelBuilder.Entity<Dispense>().HasKey(d => new { d.BillId, d.DrugId });
      modelBuilder.Entity<Dispense>().HasOne(d => d.Drug).WithMany(d => d.Dispenses);
      modelBuilder.Entity<Dispense>().HasOne(d => d.Bill).WithMany(d => d.Dispenses);

      modelBuilder.Entity<Visit>().Property(v => v.Date).HasDefaultValueSql("GETDATE()");
      modelBuilder.Entity<Visit>().HasOne(v => v.Bill).WithOne(b => b.Visit).HasForeignKey<Bill>(b => b.VisitId);
    }
  }
}