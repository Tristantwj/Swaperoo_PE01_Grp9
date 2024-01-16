﻿using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class PurchaseSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Purchase
                {
                    Id = 1,
                    SellDate = DateTime.Now,
                    OfferPrice = 400,
                    UserId = 2,
                    ProductId = 2
                }
            );
        }
    }
}