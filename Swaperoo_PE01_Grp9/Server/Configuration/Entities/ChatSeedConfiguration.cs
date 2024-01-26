using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class ChatSeedConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasData(
                new Chat
                {
                    Id = 1,
                    Name = "Test Purchase Chat",
                    DateCreated = DateTime.Now,
                    PurchaseId = 1,
                    SwapId = null
                },
                new Chat
                {
                    Id = 2,
                    Name = "Test Swap Chat",
                    DateCreated = DateTime.Now,
                    PurchaseId = null,
                    SwapId = 1
                }
            );
        }
    }
}
