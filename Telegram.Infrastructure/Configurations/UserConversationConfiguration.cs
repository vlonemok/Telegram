using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Domain;

namespace Telegram.Infrastructure.Configurations
{
    public class UserConversationConfiguration : IEntityTypeConfiguration<UserConversation>
    {
        public void Configure(EntityTypeBuilder<UserConversation> builder)
        {
            builder
                .HasKey(x => new { x.UserId, x.ConversationId });
            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Conversations)
                .HasForeignKey(x => x.UserId);
            builder
                .HasOne(x => x.Conversation)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.ConversationId);
        }
    }
}
