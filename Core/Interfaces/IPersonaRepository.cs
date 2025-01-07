using Core.Entities.Maestros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetAllAsync();
        Task<Persona> GetByIdAsync(long id);
        Task<long> AddAsync(Persona persona);
        Task<bool> UpdateAsync(Persona persona);
    }
}
