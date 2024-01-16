using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class RatingSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Rating
                {
                    Id = 1,
                    RatingValue = 4,
                    Description = "blahblah",
                    DateCreated = DateTime.Now,
                    UserId = 1,
                    PurchaseId = 1,
                    SwapId = null
                }
            );
        }
    }
}
