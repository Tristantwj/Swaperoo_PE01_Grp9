﻿using Microsoft.EntityFrameworkCore;
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
                    UserId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b0",
                    Name = "Frank",
                    Email = "frank@blazor.com",
                    Region = "North",
                    Description = "empty",
                    profilepicture = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                    Role = "Admin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    UserId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b1",
                    Name = "John",
                    Email = "john@blazor.com",
                    Region = "South",
                    Description = "empty",
                    profilepicture = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                    Role = "User",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new User
                {
                    Id = 3,
                    UserId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b2",
                    Name = "Alice",
                    Email = "alice@blazor.com",
                    Region = "West",
                    Description = "empty",
                    profilepicture = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                    Role = "Admin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
