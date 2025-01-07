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
    public class UbigeoRepository: IUbigeoRepository
    {
        private readonly AppDbContext _context;

        public UbigeoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ubigeo>> GetAllAsync()
        {
            return await _context.Ubigeos.ToListAsync();
        }

        public async Task<Ubigeo> GetByIdAsync(string codigo)
        {
            return await _context.Ubigeos.FindAsync(codigo);
        }

    }
}
