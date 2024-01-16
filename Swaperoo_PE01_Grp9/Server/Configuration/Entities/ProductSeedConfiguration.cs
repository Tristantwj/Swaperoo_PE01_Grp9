using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

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
                    imagepath = null,
                    price = 1000,
                    status = "ongoing",
                    UserId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Intel i9",
                    DateCreated = DateTime.Now,
                    Description = "Description",
                    imagepath = null,
                    price = 500,
                    status = "sold",
                    UserId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Air jordon 12",
                    DateCreated = DateTime.Now,
                    Description = "Brand new",
                    imagepath = null,
                    price = 500,
                    status = "ongoing",
                    UserId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Computer",
                    DateCreated = DateTime.Now,
                    Description = "Brand new",
                    imagepath = null,
                    price = 800,
                    status = "ongoing",
                    UserId = 1,
                    SubCategoryId = 1
                }
            );
        }
    }
}
