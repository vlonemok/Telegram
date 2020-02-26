using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Domain;

namespace Telegram.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
            builder
                .Property(x => x.Password)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
        }
    }
}
