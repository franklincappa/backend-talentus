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
    public class UbigeoConfiguration : IEntityTypeConfiguration<Ubigeo>
    {
        public void Configure(EntityTypeBuilder<Ubigeo> builder)
        {
            builder.ToTable("ubigeo", "maestro");

            builder.HasKey(p => p.Codigo);
            builder.Property(p => p.Codigo).HasColumnName("ubigeo");
            builder.Property(p => p.Departamento).HasColumnName("departamento");
            builder.Property(p => p.Provincia).HasColumnName("provincia");
            builder.Property(p => p.Distrito).HasColumnName("distrito");
        }
    }
}
