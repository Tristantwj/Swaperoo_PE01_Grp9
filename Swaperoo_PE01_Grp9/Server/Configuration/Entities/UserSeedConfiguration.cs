using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = "2bf0d5d5-7691-418f-b2f7-266c7467a0b0",
                    Name = "Frank Ofoedu",
                    Email = "frankofoedu@blazor.com",
                    Region = "North",
                    Description = "empty",
                    Role = "User"
                },
                new User
                {
                    Id = "2bf0d5d5-7691-418f-b2f7-266c7467a0b1",
                    Name = "John",
                    Email = "john@blazor.com",
                    Region = "South",
                    Description = "empty",
                    Role = "User"
                },
                new User
                {
                    Id = "2bf0d5d5-7691-418f-b2f7-266c7467a0b2",
                    Name = "Alice",
                    Email = "alice@blazor.com",
                    Region = "West",
                    Description = "empty",
                    Role = "Admin"
                }
            );
        }
    }
}
