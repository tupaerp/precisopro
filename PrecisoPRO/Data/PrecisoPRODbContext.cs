using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace PrecisoPRO.Data
{
    public class PrecisoPRODbContext : DbContext
    {
        public PrecisoPRODbContext(DbContextOptions<PrecisoPRODbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }



    }
}
