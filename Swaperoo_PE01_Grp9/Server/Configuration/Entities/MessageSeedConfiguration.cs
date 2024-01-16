﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class MessageSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Message
                {
                    Id = 1,
                    MessageContent = "Fashion",
                    DateCreated = DateTime.Now,
                    UserId = 1,
                    ChatId =1
                }
            );
        }
    }
}