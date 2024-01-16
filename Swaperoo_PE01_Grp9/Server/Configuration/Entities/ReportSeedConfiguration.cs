using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class ReportSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Report
                {
                    Id = 1,
                    ReportType = "site",
                    Description = "Description",
                    DateCreated = DateTime.Now,
                    status = "unsolved",
                    ReporterUserId = 1,
                    ReportedUserId = null,
                    ReportedProductId = null
                }
            );
        }
    }
}
