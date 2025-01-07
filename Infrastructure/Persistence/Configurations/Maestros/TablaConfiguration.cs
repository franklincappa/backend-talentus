using Core.Entities.Maestros;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations.Maestros
{
    public class TablaConfiguration : IEntityTypeConfiguration<Tabla>
    {
        public void Configure(EntityTypeBuilder<Tabla> builder)
        {
            builder.ToTable("tablas", "maestro");

            builder.HasKey(p => p.IdRegistro);
            builder.Property(p => p.IdRegistro)
                .HasColumnName("id_registro")
                .HasColumnType("smallint");
            builder.Property(p => p.NombreTabla).HasColumnName("tabla");
            builder.Property(p => p.Codigo).HasColumnName("codigo");
            builder.Property(p => p.Descripcion).HasColumnName("descripcion");
            builder.Property(p => p.Orden).HasColumnName("orden");
            builder.Property(p => p.Activo).HasColumnName("activo");
        }
    }
}
