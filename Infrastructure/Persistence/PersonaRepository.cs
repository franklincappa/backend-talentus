using Core.Entities.Maestros;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class PersonaRepository: IPersonaRepository
    {
        private readonly AppDbContext _context;

        public PersonaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Persona>> GetAllAsync()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<Persona> GetByIdAsync(long id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<long> AddAsync(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona.IdPersona;
        }

        public async Task<bool> UpdateAsync(Persona persona)
        {
            var existingPersona = await _context.Personas.FindAsync(persona.IdPersona);
            if (existingPersona == null)
                return false;
            //campos persona
            existingPersona.IdTipoDocumento = persona.IdTipoDocumento;
            existingPersona.NroDocumento = persona.NroDocumento;
            existingPersona.Nombres = persona.Nombres;
            existingPersona.ApellidoPaterno = persona.ApellidoPaterno;
            existingPersona.ApellidoMaterno = persona.ApellidoMaterno;
            existingPersona.FechaNacimiento = persona.FechaNacimiento;
            existingPersona.IdPais = persona.IdPais;
            existingPersona.Ubigeo = persona.Ubigeo;
            existingPersona.IdSexo = persona.IdSexo;
            existingPersona.IdEstadoCivil = persona.IdEstadoCivil;
            existingPersona.Ciudad = persona.Ciudad;
            existingPersona.Direccion = persona.Direccion;
            existingPersona.Telefono = persona.Telefono;
            existingPersona.IdProfesion = persona.IdProfesion;
            existingPersona.Ruc = persona.Ruc;
            existingPersona.IdTipoSangre = persona.IdTipoSangre;
            existingPersona.IdRegimenPension = persona.IdRegimenPension;
            existingPersona.Notas = persona.Notas;
            existingPersona.Activo = persona.Activo;

            //campos auditoria
            existingPersona.UsuarioModifica = persona.UsuarioModifica;
            existingPersona.FechaModifica = persona.FechaModifica;
            existingPersona.HostModifica = persona.HostModifica;

            _context.Personas.Update(existingPersona);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
