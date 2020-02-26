using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Domain;

namespace Telegram.Infrastructure.Configurations
{
    public class ConversationConfiguration : IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .Property(x => x.ConversationName)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
            builder
                .Property(x => x.CreateDate)
                .IsRequired()
                .HasColumnType("datetime");
        }
    }
}
