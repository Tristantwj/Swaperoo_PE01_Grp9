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
                    Id = 1,
                    Name = "Frank Ofoedu",
                    Email = "frankofoedu@blazor.com",
                    Region = "North",
                    Description = "empty"
                },
                new User
                {
                    Id = 2,
                    Name = "John",
                    Email = "john@blazor.com",
                    Region = "South",
                    Description = "empty"
                },
                new User
                {
                    Id = 3,
                    Name = "Tom",
                    Email = "tom@blazor.com",
                    Region = "East",
                    Description = "empty"
                }
            );
        }
    }
}
