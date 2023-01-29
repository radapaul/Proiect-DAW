using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
  public class Context : DbContext
  {
    public DbSet<Store> Stores { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeStore> EmployeesStores { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<StoreLocation> StoreLocations { get; set; }

    public Context(DbContextOptions<Context> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // One to Many
      modelBuilder.Entity<Owner>()
          .HasMany(m1 => m1.Stores)
          .WithOne(m2 => m2.Owner);


      // One to One
      modelBuilder.Entity<StoreLocation>()
          .HasOne(m5 => m5.Store)
          .WithOne(m6 => m6.Location)
          .HasForeignKey<Store>(x => x.Id);

      // One to Many
      modelBuilder.Entity<EmployeeStore>()
                  .HasKey(mr => new { mr.EmployeeId, mr.StoreId });


      modelBuilder.Entity<EmployeeStore>()
                  .HasOne(mr => mr.Store)
                  .WithMany(m3 => m3.EmployeesStores)
                  .HasForeignKey(mr => mr.StoreId);


      modelBuilder.Entity<EmployeeStore>()
                  .HasOne(mr => mr.Employee)
                  .WithMany(m4 => m4.EmployeesStores)
                  .HasForeignKey(mr => mr.EmployeeId);


      modelBuilder.Entity<Employee>()
                  .HasMany(b => b.EmployeesStores)
                  .WithOne(c => c.Employee);

      modelBuilder.AddConfigurations();
      base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
      ChangeTracker.ManageEntityStates();
      return base.SaveChanges();
    }

  }
}
