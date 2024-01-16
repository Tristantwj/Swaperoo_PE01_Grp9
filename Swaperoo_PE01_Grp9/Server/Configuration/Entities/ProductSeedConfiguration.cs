using Microsoft.CodeAnalysis;
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
                    ProductId = 1,
                    ItemName = "Nvidea GTX 2080",
                    CreatedDate = DateTime.Now,
                    ItemDescription = "Description",
                    imagepath = null,
                    price = 1000,
                    status = "ongoing",
                    UserID = 1,
                    SubCategoryId = 1
                }
            );
        }
    }
}
