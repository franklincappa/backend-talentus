using Core.Entities.Maestros;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class TablaService
    {
        private readonly ITablaRepository _tablaRepository;

        public TablaService(ITablaRepository tablaRepository)
        {
            _tablaRepository = tablaRepository;
        }

        public async Task<List<Tabla>> ObtenerPorTablaAsync(string tabla)
        {
            return await _tablaRepository.ObtenerPorTablaAsync(tabla);
        }

        public async Task<Tabla> ObtenerPorTablaYCodigoAsync(string tabla, string codigo)
        {
            return await _tablaRepository.ObtenerPorTablaYCodigoAsync(tabla, codigo);
        }
    }
}


        

        
