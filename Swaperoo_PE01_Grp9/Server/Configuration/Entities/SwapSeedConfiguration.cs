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
                    SwapProductId = 4
                }
            );
        }
    }
}
