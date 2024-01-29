using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class SwapSeedConfiguration : IEntityTypeConfiguration<Swap>
    {
        public void Configure(EntityTypeBuilder<Swap> builder)
        {
            builder.HasData(
                new Swap
                {
                    Id = 1,
                    SwapDate = DateTime.Now,
                    Status = null,
                    OfferItemId = 3,
                    SwapProductId = 4,
                    BuyerId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b0",
                    SellerId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b1"
                }
            );
        }
    }
}
