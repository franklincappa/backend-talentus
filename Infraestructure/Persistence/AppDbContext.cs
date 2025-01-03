using Core.Entities.Maestros;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Maestros
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ubigeo> Ubigeos { get; set; }
        public DbSet<Tabla> Tablas { get; set; }

        //Asistencia


        //Legajo

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica todas las configuraciones automáticamente desde el assembly actual
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
