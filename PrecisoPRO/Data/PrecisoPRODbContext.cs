using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace PrecisoPRO.Data
{
    public class PrecisoPRODbContext : DbContext
    {
        public PrecisoPRODbContext(DbContextOptions<PrecisoPRODbContext> options) : base(options) { }




    }
}
