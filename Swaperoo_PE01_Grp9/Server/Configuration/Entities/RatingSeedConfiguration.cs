using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class RatingSeedConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(
                new Rating
                {
                    Id = 1,
                    RatingValue = 4,
                    Description = "blahblah",
                    DateCreated = DateTime.Now,
                    UserId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b0",
                    PurchaseId = 1,
                    SwapId = null
                }
            );
        }
    }
}
