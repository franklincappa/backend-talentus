using Core.Entities.Maestros;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UbigeoService
    {
        private readonly IUbigeoRepository _ubigeoRepository;
        public UbigeoService(IUbigeoRepository ubigeoRepository)
        {
            _ubigeoRepository = ubigeoRepository;
        }

        public async Task<IEnumerable<Ubigeo>> GetAllAsync() { 
            return await _ubigeoRepository.GetAllAsync();
        }
        public async Task<Ubigeo> GetByIdAsync(string codigo) { 
            return await _ubigeoRepository.GetByIdAsync(codigo);
        }

    }
}
