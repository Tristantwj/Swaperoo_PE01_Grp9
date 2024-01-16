using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class SwapSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Swap
                {
                    Id = 1,
                    SwapDate = DateTime.Now,
                    OfferItemID = 3,
                    ProductId = 4,
                    BuyerId = 1,
                    SellertId = 2
                }
            );
        }
    }
}
