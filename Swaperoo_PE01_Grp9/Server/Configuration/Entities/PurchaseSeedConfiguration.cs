using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class PurchaseSeedConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasData(
                new Purchase
                {
                    Id = 1,
                    SellDate = DateTime.Now,
                    OfferPrice = 400,
                    UserId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b1",
                    PurchaseProductId = 2
                }
            );
        }
    }
}
