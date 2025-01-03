using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Maestros;

namespace Infrastructure.Persistence.Configurations.Maestros
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("personas", "maestro");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id_persona");
            builder.Property(p => p.Nombres).HasColumnName("nombres");
            builder.Property(p => p.ApellidoPaterno).HasColumnName("apellido_paterno");
            builder.Property(p => p.ApellidoMaterno).HasColumnName("apellido_materno");
            
        }
    }
}