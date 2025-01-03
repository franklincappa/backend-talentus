using Core.Entities.Maestros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUbigeoRepository
    {
        Task<IEnumerable<Ubigeo>> GetAllAsync();
        Task<Ubigeo> GetByIdAsync(string codigo);
    }
}
