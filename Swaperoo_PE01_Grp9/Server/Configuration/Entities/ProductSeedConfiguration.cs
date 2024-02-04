﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;
using static System.Net.WebRequestMethods;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Nvidea GTX 2080",
                    DateCreated = DateTime.Now,
                    Description = "Description",
                    imagepath = "https://images.nvidia.com/aem-dam/Solutions/geforce/news/geforce-rtx-graphics-cards/geforce-rtx-2080-technical-photography-front.png",
                    price = 1000,
                    status = "Ongoing",
                    UserId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 2,
                    Name = "Intel i9",
                    DateCreated = DateTime.Now,
                    Description = "Description",
                    imagepath = "data:image/jpeg;base64,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",
                    price = 500,
                    status = "Sold",
                    UserId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 3,
                    Name = "Air jordon 12",
                    DateCreated = DateTime.Now,
                    Description = "Brand new",
                    imagepath = "data:image/jpeg;base64,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",
                    price = 500,
                    status = "Ongoing",
                    UserId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Name = "Computer",
                    DateCreated = DateTime.Now,
                    Description = "Brand new",
                    imagepath = "data:image/jpeg;base64,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",
                    price = 800,
                    status = "Ongoing",
                    UserId = 2,
                    SubCategoryId = 5
                }
            );
        }
    }
}
