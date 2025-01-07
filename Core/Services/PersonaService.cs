using Core.Entities.Maestros;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        { 
            _personaRepository = personaRepository;
        }

        public async Task<IEnumerable<Persona>> GetAllAsync() { 
            return await _personaRepository.GetAllAsync();
        }

        public async Task<Persona> GetByIdAsync(long idPersona) { 
            return await _personaRepository.GetByIdAsync(idPersona);
        }
        public async Task<long> AddAsync(Persona persona, long userId, string host) { 
            return await _personaRepository.AddAsync(persona);
        }
        public async Task<bool> UpdateAsync(long idPersona, Persona persona, long userId, string host) { 
            return await _personaRepository.UpdateAsync(persona);
        }
    }
}



