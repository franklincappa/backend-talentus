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

            builder.HasKey(p => p.IdPersona);
            builder.Property(p => p.IdPersona).HasColumnName("id_persona");
            builder.Property(p => p.IdTipoDocumento).HasColumnName("id_tipo_documento");
            builder.Property(p => p.NroDocumento).HasColumnName("nro_documento");
            builder.Property(p => p.Nombres).HasColumnName("nombres");
            builder.Property(p => p.ApellidoPaterno).HasColumnName("apellido_paterno");
            builder.Property(p => p.ApellidoMaterno).HasColumnName("apellido_materno");

            builder.Property(p => p.FechaNacimiento).HasColumnName("fecha_nacimiento");
            builder.Property(p => p.IdPais).HasColumnName("id_pais");
            builder.Property(p => p.Ubigeo).HasColumnName("ubigeo");
            builder.Property(p => p.IdSexo).HasColumnName("id_sexo");
            builder.Property(p => p.IdEstadoCivil).HasColumnName("id_estado_civil");
            builder.Property(p => p.Ciudad).HasColumnName("ciudad");
            builder.Property(p => p.Direccion).HasColumnName("direccion");
            builder.Property(p => p.Telefono).HasColumnName("telefono");

            builder.Property(p => p.IdProfesion).HasColumnName("id_profesion");
            builder.Property(p => p.Ruc).HasColumnName("ruc");
            builder.Property(p => p.IdTipoSangre).HasColumnName("id_tipo_sangre");
            builder.Property(p => p.IdRegimenPension).HasColumnName("id_Regimen_pension");
            builder.Property(p => p.Notas).HasColumnName("notas");
            builder.Property(p => p.Activo).HasColumnName("activo");

            builder.Property(p => p.UsuarioCreacion).HasColumnName("reg_usuario_creacion");
            builder.Property(p => p.FechaCreacion).HasColumnName("reg_fecha_creacion");
            builder.Property(p => p.HostCreacion).HasColumnName("reg_host_creacion");
            builder.Property(p => p.UsuarioModifica).HasColumnName("reg_usuario_modifica");
            builder.Property(p => p.FechaModifica).HasColumnName("reg_fecha_modifica");
            builder.Property(p => p.HostModifica).HasColumnName("reg_host_modifica");

        }
    }
}