using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Domain;

namespace Telegram.Infrastructure.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .Property(x => x.Text)
                .IsRequired()
                .HasColumnType("nvarchar(200)");
            builder
                .Property(x => x.MessageTime)
                .IsRequired()
                .HasColumnType("datetime");

            builder
                .HasOne(x => x.UserConversation)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => new { x.ConversationId, x.UserId});
        }
    }
}
