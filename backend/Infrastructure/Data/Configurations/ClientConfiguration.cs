using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("clients");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .ValueGeneratedOnAdd();
    }

}
