using PrecisoPRO.Models;

namespace PrecisoPRO.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAll();

        Task<Usuario> GetByIdAsync(int id);

        Task<Usuario> GetByIdAsyncNoTracking(int id);
        Task<IEnumerable<Usuario>> GetClubByCity(string city);


        bool Add(Usuario club);

        bool Adicionar(Usuario club);


        bool Update(Usuario club);

        bool Delete(Usuario club);
        bool Save();
    }
}
