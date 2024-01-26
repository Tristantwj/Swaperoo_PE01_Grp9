using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class SubCategorySeedConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(
                new SubCategory
                {
                    Id = 1,
                    Name = "Shirt",
                    CategoryId = 1
                },
                new SubCategory
                {
                    Id = 2,
                    Name = "Shoes",
                    CategoryId = 1
                }
            );
        }
    }
}
