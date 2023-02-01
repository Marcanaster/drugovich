using Drugovich.Domain.Entities;
using Drugovich.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Drugovich.Data.Mapping
{
    public class GerenteMap : IEntityTypeConfiguration<GerenteEntity>
    {
        public void Configure(EntityTypeBuilder<GerenteEntity> builder)
        {
            builder.ToTable("Gerente");
            builder.HasKey(p => p.Id);
            builder.HasIndex(c => c.Codigo).IsUnique();
            builder.Property(c => c.Codigo).IsRequired();
            builder.HasIndex(c => c.Email).IsUnique();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Nome).HasMaxLength(200).IsRequired();
            builder.Property(c => c.Nivel).HasDefaultValue(NivelGerenteEnum.nivelum);
        }
    }
}
