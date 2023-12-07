using PrecisoPRO.Models;

namespace PrecisoPRO.Interfaces
{
    public interface IEmpresaEstadoRepository
    {
        Task<IEnumerable<EmpresaEstado>> GetAll();

        Task<IEnumerable<EmpresaEstado>> GetAllAsyncNoTracking();

        Task<EmpresaEstado> GetByIdAsync(int id);

        Task<EmpresaEstado> GetByIdAsyncNoTracking(int id);

    }
}
