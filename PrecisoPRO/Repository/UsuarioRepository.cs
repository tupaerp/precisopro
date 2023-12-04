using Microsoft.EntityFrameworkCore;
using PrecisoPRO.Data;
using PrecisoPRO.Interfaces;
using PrecisoPRO.Models;

namespace PrecisoPRO.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        //contexto do banco de dados
        private readonly PrecisoPRODbContext db;
        public UsuarioRepository(PrecisoPRODbContext context)
        {
            db = context;
        }
        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await db.Usuarios.ToListAsync();
        }
        public bool Adicionar(Usuario club)
        {
            throw new NotImplementedException();
        }

        public bool Add(Usuario usuario)
        {
            db.Add(usuario);
            return Save();
        }

      

        public bool Delete(Usuario club)
        {
            throw new NotImplementedException();
        }

        

        public Task<Usuario> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetByIdAsyncNoTracking(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetClubByCity(string city)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario club)
        {
            throw new NotImplementedException();
        }
    }
}
