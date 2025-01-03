using Core.Entities.Maestros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITablaRepository
    {
        Task<IEnumerable<Tabla>> ObtenerTodoAsync();
        Task<Tabla> ObtenerPorIdAsync(int idregistro);
        Task<List<Tabla>> ObtenerPorTablaAsync(string tabla);       
        Task<Tabla> ObtenerPorTablaYCodigoAsync(string tabla, string codigo);

    }    
}
