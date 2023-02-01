using Drugovich.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Drugovich.Data.Mapping
{
    public class GrupoMap : IEntityTypeConfiguration<GrupoEntity>
    {
        public void Configure(EntityTypeBuilder<GrupoEntity> builder)
        {
            builder.ToTable("Grupo");
            builder.HasKey(p => p.Id);
            builder.HasIndex(c => c.Codigo).IsUnique();
            builder.Property(c => c.Codigo).IsRequired();
            builder.Property(c => c.Nome).IsRequired();
        }
    }
}
