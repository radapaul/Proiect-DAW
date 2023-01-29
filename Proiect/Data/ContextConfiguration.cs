using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Proiect.Data.EntityConfiguration;
using Proiect.Models.Base;

namespace Proiect.Data
{
    internal static class ContextConfiguration
    {
      public static void AddConfigurations(this ModelBuilder modelBuilder)
      {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
      }
      public static void ManageEntityStates(this ChangeTracker changeTracker)
      {
      IEnumerable<EntityEntry> entries = changeTracker.Entries()
       .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

      foreach (EntityEntry entry in entries)
      {
        DateTime dateTimeNow = DateTime.UtcNow;
        ((BaseEntity)entry.Entity).DateModified = dateTimeNow;

        if (entry.State == EntityState.Added)
          ((BaseEntity)entry.Entity).DateCreated = dateTimeNow;
      };
      }

    }
}
