using Microsoft.EntityFrameworkCore;
using PrecisoPRO.Data;
using PrecisoPRO.Interfaces;
using PrecisoPRO.Models;

namespace PrecisoPRO.Repository
{
    public class EmpresaEstadoRepository : IEmpresaEstadoRepository
    {
        //contexto do banco de dados
        private readonly PrecisoPRODbContext db;

        public EmpresaEstadoRepository(PrecisoPRODbContext context)
        {
            db = context;
        }

        public async Task<IEnumerable<EmpresaEstado>> GetAll()
        {
            return await db.EmpresasEstados.ToListAsync();
        }

        public async Task<IEnumerable<EmpresaEstado>> GetAllAsyncNoTracking()
        {
            return await db.EmpresasEstados.AsNoTracking().OrderBy(x => x.IdEmpresa).ToListAsync();
        }

        public async Task<EmpresaEstado> GetByIdAsync(int id)
        {
            return await db.EmpresasEstados.FirstOrDefaultAsync(i => i.IdEmpresa == id);
        }

        public async Task<EmpresaEstado> GetByIdAsyncNoTracking(int id)
        {
            return await db.EmpresasEstados.AsNoTracking().FirstOrDefaultAsync(i => i.IdEmpresa == id);
        }
    }
}
