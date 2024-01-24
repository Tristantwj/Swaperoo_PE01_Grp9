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
                    Name = "First Chat",
                    ChatProfilePicture = null,
                    DateCreated = DateTime.Now,
                    ProductId = 1
                }
            );
        }
    }
}
