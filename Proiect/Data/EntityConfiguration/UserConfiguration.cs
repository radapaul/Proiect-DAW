using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect.Models;

namespace Proiect.Data.EntityConfiguration
{ 
  internal class UserConfiguration : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired();
    }
  }
}
