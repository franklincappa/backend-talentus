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
    public class TablaRepository: ITablaRepository
    {
        private readonly AppDbContext _context;
        public TablaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tabla>> ObtenerTodoAsync()
        {
            return await _context.Tablas.ToListAsync();
        }

        public async Task<Tabla> ObtenerPorIdAsync(int idregistro)
        {
            return await _context.Tablas.FindAsync(idregistro);
        }

        public async Task<List<Tabla>> ObtenerPorTablaAsync(string tabla)
        {
            return await _context.Set<Tabla>()
                .Where(m => m.NombreTabla == tabla ) //&& m.Activo)
                .ToListAsync(); 
        }
        public async Task<Tabla> ObtenerPorTablaYCodigoAsync(string tabla, string codigo)
        {
            return await _context.Set<Tabla>()
                .FirstOrDefaultAsync(m => m.NombreTabla == tabla && m.Codigo == codigo) // && m.Activo)
                   ?? throw new KeyNotFoundException("Registro no encontrado");
        }

    }
}
