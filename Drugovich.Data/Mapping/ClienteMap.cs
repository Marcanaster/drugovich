using Drugovich.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Drugovich.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteEntity>
    {
        public void Configure(EntityTypeBuilder<ClienteEntity> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(p => p.Id);
            builder.HasIndex(c => c.Codigo).IsUnique();
            builder.Property(c => c.Codigo).IsRequired();
            builder.Property(c => c.Nome).HasMaxLength(200).IsRequired();
            builder.Property(c => c.DataFundacao);
            builder.Property(c => c.CNPJ).IsRequired();
        }
    }
}
