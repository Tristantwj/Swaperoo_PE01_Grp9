using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Configuration.Entities
{
    public class MessageSeedConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData(
                new Message
                {
                    Id = 1,
                    MessageContent = "Fashion",
                    DateCreated = DateTime.Now,
                    SenderId = "2bf0d5d5-7691-418f-b2f7-266c7467a0b0",
                    ChatId =1
                }
            );
        }
    }
}
